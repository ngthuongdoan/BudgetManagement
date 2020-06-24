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
        private Color IncomeColor = Color.FromArgb(133, 237, 137);
        private Color ExpenseColor = Color.FromArgb(243, 142, 135);

        public Transaction(string type)
        {
            InitializeComponent();
            Init();
            this.type = type;
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
    }
}
