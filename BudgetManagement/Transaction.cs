using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class Transaction : UserControl
    {
        private string type;
        private UserModel user;
        public int id;
        public string note;
        private Color IncomeColor = Color.FromArgb(133, 237, 137);
        private Color ExpenseColor = Color.FromArgb(243, 142, 135);

        public Transaction(string type, UserModel user)
        {
            InitializeComponent(); 
            Init();
            this.type = type;
            this.user = user;
        }

        private void Init()
        {
            this.Value.Text = "";
            this.Wallet.Text = "";
            this.Time.Text = "";
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            if (type == "Income")
            {
                this.BackColor = IncomeColor;
                this.Type.Image = Image.FromFile(@"E:\Code\.NET\BudgetManagement\img\increase_48px.png");
            }
            else
            {
                this.BackColor = ExpenseColor;
                this.Type.Image = Image.FromFile(@"E:\Code\.NET\BudgetManagement\img\decrease_48px.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Connection.Connect();
                    Connection.Delete($"DELETE FROM transactions WHERE id={this.id}");
                    double amount = (double)Connection.SelectScalar($"SELECT amount FROM wallets WHERE username='{this.user.Username}' AND walletName='{this.Wallet.Text}'");
                    Connection.Update($"UPDATE wallets SET amount={amount-Convert.ToDouble(this.Value.Text)} WHERE username='{this.user.Username}' AND walletName='{this.Wallet.Text}'");
                    Connection.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
