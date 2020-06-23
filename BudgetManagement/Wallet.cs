using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BudgetManagement
{
    public partial class Wallet : UserControl
    {
        private UserModel user;
        private double amount;
        private string wname;
        private byte[] icon;

        public double Amount
        {
            get { return this.amount; }
            set
            {
                this.amount = value;
                this.AmountLabel.Text = this.amount.ToString();
            }
        }

        public string WName
        {
            get { return this.wname; }
            set
            {
                this.wname = value;
                this.WalletName.Text = this.wname;
            }
        }

        public UserModel User
        {
            get { return this.user; }
            set
            {
                this.user = value;
            }
        }

        public byte[] Icon
        {
            get { return this.icon; }
            set
            {
                this.icon = value;
                this.WalletIcon.Image = ImageProccess.ByteToImage(this.icon);
            }
        }

        public Wallet()
        {
            InitializeComponent();
        }

        private void DeleteWallet_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    Connection.Connect();
                    Connection.Delete($"DELETE FROM wallets WHERE username = '{this.user.Username}' AND walletName = '{this.WalletName.Text}'");
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
