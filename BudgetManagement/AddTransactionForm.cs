using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class AddTransactionForm : Form
    {
        public TransactionModel transaction;
        private UserModel user;
        private string categogy = "";


        public AddTransactionForm()
        {
            InitializeComponent();
            this.user = new UserModel();
            time.Format = DateTimePickerFormat.Custom;
            time.Value = DateTime.Now;
            time.CustomFormat = "yyyy-MM-dd";
            value.Maximum = Decimal.MaxValue;
            this.categogyName.Text = "";

        }

        public AddTransactionForm(UserModel user)
        {
            InitializeComponent();
            this.user = new UserModel(user);
            time.Format = DateTimePickerFormat.Custom;
            time.Value = DateTime.Now;
            time.CustomFormat = "yyyy-MM-dd";
            value.Maximum = Decimal.MaxValue;
            this.categogyName.Text = "";
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            Connection.Connect();
            SqlDataReader reader = Connection.Select($"SELECT walletName FROM wallets WHERE username = '{this.user.Username}'");
            try
            {
                while (reader.Read())
                {
                    this.wallet.Items.Add((string)reader["walletName"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                this.categogy = frm.category;
                this.categogyName.Text = this.categogy;
            }
        }

        private bool valid()
        {
            bool walletCheck = this.wallet.Text != "";
            return walletCheck;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                this.transaction = new TransactionModel();
                transaction.CategogyName = this.categogyName.Text;
                transaction.Note = this.note.Text;
                transaction.Time = this.time.Value;
                transaction.Type = (this.income.Checked) ? "Income" : "Expense";
                transaction.Username = this.user.Username;
                transaction.Value = (double)this.value.Value;
                transaction.WalletName = this.wallet.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
