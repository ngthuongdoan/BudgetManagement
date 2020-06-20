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
        private static Wallet _instance;
        public static Wallet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Wallet();   
                }
                return _instance;
            }
        }
        public Wallet()
        {
            InitializeComponent();
        }
    }
}
