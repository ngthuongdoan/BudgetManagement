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

        public byte[] Icon
        {
            get { return this.icon; }
            set
            {
                this.icon = value;
                this.WalletIcon.Image = ByteToImage(this.icon);
            }
        }
        public Image ByteToImage(byte[] image)
        {
            using (var ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }
        public Wallet()
        {
            InitializeComponent();

        }
    }
}
