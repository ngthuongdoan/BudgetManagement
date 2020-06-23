using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public class TransactionModel
    {
        private string username;
        private string type;
        private string walletName;
        private string categogyName;
        private double value;
        private string note;
        private DateTime time;

        public TransactionModel()
        {
            this.username ="";
            this.type = "";
            this.walletName = "";
            this.categogyName = "";
            this.value = 0;
            this.note = "";
            this.time = new DateTime();
        }
        public TransactionModel(TransactionModel t)
        {
            this.username=t.username;
            this.type=t.type;
            this.walletName=t.walletName;
            this.categogyName=t.categogyName;
            this.value=t.value;
            this.note=t.note;
            this.time=t.time;
    }
        public string Username {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string WalletName
        {
            get { return this.walletName; }
            set { this.walletName = value; }
        }
        public string CategogyName
        {
            get { return this.categogyName; }
            set { this.categogyName = value; }
        }
        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

    }
}
