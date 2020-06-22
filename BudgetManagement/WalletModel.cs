using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public class WalletModel
    {
        private string walletName;
        private double amount;
        private byte[] icon;

        public WalletModel()
        {
            this.walletName = "";
            this.amount = 0;
            this.icon = Enumerable.Repeat((byte)0x20, 0).ToArray();
        }

        public WalletModel(string name, double amount, byte[] icon)
        {
            this.walletName = name;
            this.amount = amount;
            this.icon = icon;
        }

        public WalletModel(WalletModel w)
        {
            this.walletName = w.walletName;
            this.amount = w.amount;
            this.icon = w.icon;
        }

        public string WalletName
        {
            get { return this.walletName; }
            set { this.walletName = value; }
        }
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public byte[] Icon
        {
            get { return this.icon; }
            set { this.icon = value; }
        }

        public override string ToString()
        {
            return $"Name: {WalletName}\nAmount: {Amount}\nIcon: {Icon.ToString()}";
        }
    }
}
