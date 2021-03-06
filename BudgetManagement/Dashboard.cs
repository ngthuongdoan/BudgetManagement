﻿using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core;
using Microsoft.VisualBasic;

namespace BudgetManagement
{
    public partial class Dashboard : Form
    {
        private UserModel user;
        private const int CS_DROPSHADOW = 0x00020000;
        public Dashboard()
        {
            InitializeComponent();
            AdditionUI();
        }
        public Dashboard(UserModel user)
        {
            this.user = new UserModel(user);
            InitializeComponent();
            AdditionUI();
        }
        private void AdditionUI()
        {
            this.Username.Text = this.user.ChangeToNormal(this.user.FullName);
            UpdateAvatar();
        }
        private void UpdateAvatar()
        {
            MemoryStream ms = new MemoryStream(this.user.Avatar);
            this.Avatar.Image = Image.FromStream(ms);
            this.Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Avatar.Refresh();
        }
        private void ChangeAvatar()
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FileInfo finfo = new FileInfo(open.FileName);
                    byte[] btImage = new byte[finfo.Length];
                    FileStream fStream = finfo.OpenRead();
                    fStream.Read(btImage, 0, btImage.Length);
                    fStream.Close();
                    Connection.Connect();
                    string updateString = $"UPDATE users SET avatar=@AVATAR WHERE username = '{this.user.Username}'";
                    SqlCommand cmd = new SqlCommand(updateString, Connection.conn);
                    SqlParameter imageParameter = new SqlParameter("@AVATAR", SqlDbType.Image);
                    imageParameter.Value = btImage;
                    cmd.Parameters.Add(imageParameter);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    this.user.Avatar = btImage;
                    UpdateAvatar();
                }
            }
        }
        private void Avatar_Click(object sender, EventArgs e)
        {
            ChangeAvatar();
        }
        private void ModifyWallet(object sender, MouseEventArgs e)
        {
            string result = Interaction.InputBox("Change initial value:", "Update Wallet", (sender as Wallet).Amount.ToString());
            try
            {
                Connection.Connect();
                Connection.Update($"UPDATE wallets SET amount={Convert.ToDecimal(result)} WHERE username = '{this.user.Username}' AND walletName = '{(sender as Wallet).WName}'");
                Connection.Close();
                WalletShowContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ModifyTransaction(object sender, MouseEventArgs e)
        {
            AddTransactionForm frm = new AddTransactionForm(user);
            frm.label1.Text = "UPDATE TRANSACTION";
            frm.button1.Visible = false;
            string type = (sender as Transaction).Value.Text;
            double finalAmount = Convert.ToDouble(type);
            if (Convert.ToDecimal(type) > 0)
            {
                frm.income.Checked = true;
                frm.expense.Checked = false;
                frm.value.Value = Convert.ToDecimal((sender as Transaction).Value.Text);
            }
            else
            {
                frm.income.Checked = false;
                frm.expense.Checked = true;
                frm.value.Value = -Convert.ToDecimal((sender as Transaction).Value.Text);
            }
            frm.income.Enabled = false;
            frm.expense.Enabled = false;
            frm.wallet.Text = (sender as Transaction).Wallet.Text;
            frm.wallet.Enabled = false;
            frm.note.Text = (sender as Transaction).note;
            frm.time.Value = DateTime.ParseExact((sender as Transaction).Time.Text, "dd-MM-yyyy", null);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                TransactionModel transactionModel = new TransactionModel(frm.transaction);
                double value = (transactionModel.Type == "Income") ? transactionModel.Value : -transactionModel.Value;
                string updateString = $"UPDATE transactions SET " +
                    $"transactionValue={value}," +
                    $"transactionNote='{transactionModel.Note}'," +
                    $"transactionTime='{transactionModel.Time.ToString("yyyy-MM-dd")}'" +
                    $"WHERE id={(sender as Transaction).id}";
                try
                {
                    Connection.Connect();
                    Connection.Update(updateString);
                    if (finalAmount != transactionModel.Value)
                    {
                        double amount = (double)Connection.SelectScalar($"SELECT amount FROM wallets WHERE username='{this.user.Username}' AND walletName='{transactionModel.WalletName}'");
                        double a = amount - finalAmount + value;

                        Connection.Update($"UPDATE wallets SET amount={a} WHERE username='{this.user.Username}' AND walletName='{transactionModel.WalletName}'");
                        Connection.Close();
                    }
                    TransactionShowContent();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void IncomeChartTypeLoading(string type)
        {
            this.IncomeExpenseChart.Series.Clear();
            this.IncomeExpenseChart.Series.Add("MySeries");
            this.IncomeExpenseChart.Series["MySeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Connection.Connect();
            double income = 0, expense = 0;
            DateTime today = DateTime.Now;
            int day = today.Day;
            int month = today.Month;
            int year = today.Year;
            ArrayList validDate = new ArrayList();
            Connection.Connect();
            try
            {
                SqlDataReader reader = Connection.Select($"SELECT transactionTime FROM transactions WHERE username = '{this.user.Username}' AND transactionType='Income'");
                while (reader.Read())
                {
                    string date1 = reader.GetDateTime(0).ToString("yyyy-MM-dd");
                    switch (type)
                    {
                        case "yearly":
                            if (DateTime.Parse(date1).Year == year) validDate.Add(DateTime.Parse(date1));
                            break;
                        case "monthly":
                            if (DateTime.Parse(date1).Year == year && DateTime.Parse(date1).Month == month) validDate.Add(DateTime.Parse(date1));
                            break;
                        case "daily":
                            if (DateTime.Parse(date1).Year == year && DateTime.Parse(date1).Month == month && DateTime.Parse(date1).Day == day) validDate.Add(DateTime.Parse(date1));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (validDate.Count == 0) return;
            DateTime minDate = DateTime.MaxValue;
            DateTime maxDate = DateTime.MinValue;
            foreach (DateTime date in validDate)
            {
                if (date < minDate)
                    minDate = date;
                if (date > maxDate)
                    maxDate = date;
            }
            try
            {
                income = (double)Connection.SelectScalar(
                    $"SELECT SUM(transactionValue) FROM transactions" +
                    $" WHERE username = '{this.user.Username}' " +
                    $"AND transactionType='Income' " +
                    $"AND transactionTime BETWEEN '{minDate.ToString("yyyy-MM-dd")}' AND '{maxDate.ToString("yyyy-MM-dd")}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            validDate = new ArrayList();
            try
            {
                SqlDataReader reader = Connection.Select($"SELECT transactionTime FROM transactions WHERE username = '{this.user.Username}' AND transactionType='Expense'");
                while (reader.Read())
                {
                    string date1 = reader.GetDateTime(0).ToString("yyyy-MM-dd");
                    switch (type)
                    {
                        case "yearly":
                            if (DateTime.Parse(date1).Year == year) validDate.Add(DateTime.Parse(date1));
                            break;
                        case "monthly":
                            if (DateTime.Parse(date1).Year == year && DateTime.Parse(date1).Month == month) validDate.Add(DateTime.Parse(date1));
                            break;
                        case "daily":
                            if (DateTime.Parse(date1).Year == year && DateTime.Parse(date1).Month == month && DateTime.Parse(date1).Day == day) validDate.Add(DateTime.Parse(date1));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (validDate.Count == 0) return;
            minDate = DateTime.MaxValue;
            maxDate = DateTime.MinValue;
            foreach (DateTime date in validDate)
            {
                if (date < minDate)
                    minDate = date;
                if (date > maxDate)
                    maxDate = date;
            }
            try
            {
                expense = -(double)Connection.SelectScalar(
                    $"SELECT SUM(transactionValue) FROM transactions" +
                    $" WHERE username = '{this.user.Username}' " +
                    $"AND transactionType='Expense' " +
                    $"AND transactionTime BETWEEN '{minDate.ToString("yyyy-MM-dd")}' AND '{maxDate.ToString("yyyy-MM-dd")}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Connection.Close();

            this.IncomeExpenseChart.Series["MySeries"].Points.AddXY("Income", income);
            this.IncomeExpenseChart.Series["MySeries"].Points.AddXY("Expense", expense);
        }
        private void IncomeChartAllLoading()
        {
            this.IncomeExpenseChart.Series.Clear();
            this.IncomeExpenseChart.Series.Add("MySeries");
            this.IncomeExpenseChart.Series["MySeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Connection.Connect();
            double income = 0, expense = 0;
            try
            {
                income = (double)Connection.SelectScalar($"SELECT SUM(transactionValue) FROM transactions WHERE username = '{this.user.Username}' AND transactionType='Income'");
                expense = -(double)Connection.SelectScalar($"SELECT SUM(transactionValue) FROM transactions WHERE username = '{this.user.Username}' AND transactionType='Expense'"); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Connection.Close();
            this.IncomeExpenseChart.Series["MySeries"].Points.AddXY("Income", income);
            this.IncomeExpenseChart.Series["MySeries"].Points.AddXY("Expense", expense);
        }
        private void CategoryTypeLoading(string type)
        {
            this.CategogyChart.Series.Clear();
            this.CategogyChart.Series.Add("MySeries");
            this.CategogyChart.Series["MySeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            ArrayList AllCategory = new ArrayList();
            DateTime today = DateTime.Now;
            int day = today.Day;
            int month = today.Month;
            int year = today.Year;
            ArrayList validDate = new ArrayList();
            Connection.Connect();
            try
            {
                SqlDataReader reader = Connection.Select($"SELECT categogyName,transactionTime FROM transactions WHERE username = '{this.user.Username}' AND transactionType='Expense'");
                while (reader.Read())
                {
                    AllCategory.Add((string)reader["categogyName"]);
                    string date1 = reader.GetDateTime(1).ToString("yyyy-MM-dd");
                    switch (type)
                    {
                        case "yearly":
                            if (DateTime.Parse(date1).Year == year) validDate.Add(DateTime.Parse(date1));
                            break;
                        case "monthly":
                            if (DateTime.Parse(date1).Year == year && DateTime.Parse(date1).Month == month) validDate.Add(DateTime.Parse(date1));
                            break;
                        case "daily":
                            if (DateTime.Parse(date1).Year == year && DateTime.Parse(date1).Month == month && DateTime.Parse(date1).Day == day) validDate.Add(DateTime.Parse(date1));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
            if (validDate.Count == 0) return;
            DateTime minDate = DateTime.MaxValue;
            DateTime maxDate = DateTime.MinValue;
            foreach (DateTime date in validDate)
            {
                if (date < minDate)
                    minDate = date;
                if (date > maxDate)
                    maxDate = date;
            }
            Connection.Connect();
            foreach (string category in AllCategory)
            {
                try
                {
                    double val = (double)Connection.SelectScalar(
                    $"SELECT SUM(transactionValue) FROM transactions " +
                    $"WHERE username = '{this.user.Username}' " +
                    $"AND categogyName='{category}' " +
                    $"AND transactionTime BETWEEN '{minDate.ToString("yyyy-MM-dd")}' AND '{maxDate.ToString("yyyy-MM-dd")}'");
                    this.CategogyChart.Series["MySeries"].Points.AddXY(category, val);
                }
                catch
                {
                    //Error
                };
            }
            Connection.Close();
        }
        private void CategoryAllLoading()
        {
            this.CategogyChart.Series.Clear();
            this.CategogyChart.Series.Add("MySeries");
            this.CategogyChart.Series["MySeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            ArrayList AllCategory = new ArrayList();

            Connection.Connect();
            try
            {
                SqlDataReader reader = Connection.Select($"SELECT categogyName FROM transactions WHERE username = '{this.user.Username}' AND transactionType='Expense'");
                while (reader.Read())
                {
                    AllCategory.Add((string)reader["categogyName"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (string categogy in AllCategory)
            {
                double val = (double)Connection.SelectScalar($"SELECT SUM(transactionValue) FROM transactions WHERE username = '{this.user.Username}' AND categogyName='{categogy}'");
                this.CategogyChart.Series["MySeries"].Points.AddXY(categogy, val);
            }
            Connection.Close();
        }
        private void OverviewShowContent()
        {
            this.tabControl1.SelectedTab = this.OverviewTab;
            this.FilterAllBtn.Checked = true;
            this.FilterYearlyBtn.Checked = false;
            this.FilterMonthlyBtn.Checked = false;
            this.FilterDailyBtn.Checked = false;
            //INCOME_EXPENSE
            IncomeChartAllLoading();
            //CATEGOGY
            CategoryAllLoading();
            //TODAY TRANSACTION
            Connection.Connect();
            try
            {
                DateTime today = DateTime.Now;
                SqlDataReader reader = Connection.Select($"SELECT * FROM transactions JOIN categogies ON transactions.categogyName = categogies.categogyName WHERE username = '{this.user.Username}' AND transactionTime = '{today.ToString("yyyy-MM-dd")}'");
                if (reader.HasRows) this.TodayTransactionPanel.Controls.Clear();
                while (reader.Read())
                {
                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.Username = (string)reader["username"];
                    transactionModel.WalletName = (string)reader["walletName"];
                    transactionModel.Type = (string)reader["transactionType"];
                    transactionModel.Value = (double)reader["transactionValue"];
                    transactionModel.Note = (string)reader["transactionNote"];
                    OverviewWallet transaction = new OverviewWallet(transactionModel.Type, this.user);
                    transaction.Value.Text = String.Format("{0:n0}", transactionModel.Value);
                    transaction.Wallet.Text = transactionModel.WalletName;
                    transaction.Categogy.Image = ImageProccess.ByteToImage((byte[])reader["categogyImage"]);
                    transaction.MouseClick += TransactionMenu_Click;
                    this.TodayTransactionPanel.Controls.Add(transaction);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Connection.Close();


        }
        private void WalletShowContent()
        {
            this.WalletContainer.Controls.Clear();
            WalletContainer.AutoScroll = false;
            WalletContainer.HorizontalScroll.Enabled = false;
            WalletContainer.HorizontalScroll.Visible = false;
            WalletContainer.HorizontalScroll.Maximum = 0;
            WalletContainer.AutoScroll = true;
            Connection.Connect();
            SqlDataReader reader = Connection.Select($"SELECT * FROM wallets WHERE username = '{this.user.Username}'");
            try
            {
                while (reader.Read())
                {
                    WalletModel wallet = new WalletModel((string)reader["walletName"],
                                                         (double)reader["amount"],
                                                         (byte[])reader["icon"]);
                    Wallet w = new Wallet();
                    w.WName = wallet.WalletName;
                    w.Amount = wallet.Amount;
                    w.Icon = wallet.Icon;
                    w.User = this.user;
                    w.MouseClick += ModifyWallet;
                    this.WalletContainer.Controls.Add(w);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
        }


        private void TransactionShowContent()
        {
            this.TransactionContainer.Controls.Clear();
            TransactionContainer.AutoScroll = false;
            TransactionContainer.HorizontalScroll.Enabled = false;
            TransactionContainer.HorizontalScroll.Visible = false;
            TransactionContainer.HorizontalScroll.Maximum = 0;
            TransactionContainer.AutoScroll = true;
            Connection.Connect();
            SqlDataReader reader = Connection.Select($"SELECT * FROM transactions JOIN categogies ON transactions.categogyName = categogies.categogyName WHERE username = '{this.user.Username}' ORDER BY transactionTime DESC");
            try
            {
                while (reader.Read())
                {
                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.Username = (string)reader["username"];
                    transactionModel.WalletName = (string)reader["walletName"];
                    transactionModel.Type = (string)reader["transactionType"];
                    transactionModel.Value = (double)reader["transactionValue"];
                    transactionModel.Note = (string)reader["transactionNote"];
                    string date1 = reader.GetDateTime(7).ToString("yyyy-MM-dd");
                    transactionModel.Time = DateTime.Parse(date1);
                    Transaction transaction = new Transaction(transactionModel.Type, this.user);
                    transaction.Value.Text = String.Format("{0:n0}", transactionModel.Value);
                    transaction.id = (int)reader["id"];
                    transaction.Wallet.Text = transactionModel.WalletName;
                    transaction.note = (string)reader["transactionNote"];
                    transaction.Time.Text = transactionModel.Time.ToString("dd-MM-yyyy");
                    transaction.Categogy.Image = ImageProccess.ByteToImage((byte[])reader["categogyImage"]);
                    transaction.MouseClick += ModifyTransaction;
                    this.TransactionContainer.Controls.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
        }
        private void WalletMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.WalletTab;
            WalletShowContent();
        }
        private void TransactionMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.TransactionTab;
            TransactionShowContent();
        }
        private void OverviewMenu_Click(object sender, EventArgs e)
        {
            OverviewShowContent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            OverviewShowContent();
        }
        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AddWalletBtn_Click(object sender, EventArgs e)
        {
            AddWalletForm frm = new AddWalletForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                WalletModel wallet = new WalletModel(frm.wallet);

                string insertString = $"INSERT INTO wallets VALUES (" +
                    $"'{this.user.Username}'," +
                    $"'{wallet.WalletName}'," +
                    $"{wallet.Amount}," +
                    $"@ICON)";
                try
                {
                    Connection.Connect();
                    SqlCommand cmd = new SqlCommand(insertString, Connection.conn);
                    SqlParameter imageParameter = new SqlParameter("@ICON", SqlDbType.Image);
                    imageParameter.Value = wallet.Icon;
                    cmd.Parameters.Add(imageParameter);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    WalletShowContent();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            AddTransactionForm frm = new AddTransactionForm(user);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                TransactionModel transactionModel = new TransactionModel(frm.transaction);

                double value = (transactionModel.Type == "Income") ? transactionModel.Value : -transactionModel.Value;
                string insertString = $"INSERT INTO transactions VALUES (" +
                    $"'{transactionModel.Username}'," +
                    $"'{transactionModel.WalletName}'," +
                    $"'{transactionModel.CategogyName}'," +
                    $"'{transactionModel.Type}'," +
                    $"{value}," +
                    $"'{transactionModel.Note}'," +
                    $"'{transactionModel.Time.ToString("yyyy-MM-dd")}')";
                try
                {
                    Connection.Connect();
                    Connection.Insert(insertString);
                    double amount = (double)Connection.SelectScalar($"SELECT amount FROM wallets WHERE username='{this.user.Username}' AND walletName='{transactionModel.WalletName}'");
                    double finalAmount = amount + value;

                    Connection.Update($"UPDATE wallets SET amount={finalAmount} WHERE username='{this.user.Username}' AND walletName='{transactionModel.WalletName}'");
                    Connection.Close();

                    TransactionShowContent();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void FilterAllBtn_Click(object sender, EventArgs e)
        {
            this.FilterAllBtn.Checked = true;
            this.FilterYearlyBtn.Checked = false;
            this.FilterMonthlyBtn.Checked = false;
            this.FilterDailyBtn.Checked = false;
            CategoryAllLoading();
            IncomeChartAllLoading();
        }

        private void FilterYearlyBtn_Click(object sender, EventArgs e)
        {
            this.FilterAllBtn.Checked = false;
            this.FilterYearlyBtn.Checked = true;
            this.FilterMonthlyBtn.Checked = false;
            this.FilterDailyBtn.Checked = false;
            CategoryTypeLoading("yearly");
            IncomeChartTypeLoading("yearly");
        }

        private void FilterMonthlyBtn_Click(object sender, EventArgs e)
        {
            this.FilterAllBtn.Checked = false;
            this.FilterYearlyBtn.Checked = false;
            this.FilterMonthlyBtn.Checked = true;
            this.FilterDailyBtn.Checked = false;
            CategoryTypeLoading("monthly");
            IncomeChartTypeLoading("monthly");
        }

        private void FilterDailyBtn_Click(object sender, EventArgs e)
        {
            this.FilterAllBtn.Checked = false;
            this.FilterYearlyBtn.Checked = false;
            this.FilterMonthlyBtn.Checked = false;
            this.FilterDailyBtn.Checked = true;
            CategoryTypeLoading("daily");
            IncomeChartTypeLoading("daily");
        }
    }
}
