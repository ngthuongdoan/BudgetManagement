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
    public partial class Wallet : UserControl
    {
        private string amount;
        private string wname;
        private Image icon;

        public string Amount
        {
            get { return this.amount; }
            set
            {
                this.amount = value;
                this.AmountLabel.Text = this.amount;
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

        public Image Icon
        {
            get { return this.icon; }
            set
            {
                this.icon = value;
                this.WalletIcon.Image = this.icon;
            }
        }
        public Wallet()
        {
            InitializeComponent();

        }
    }
}
