using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class AddWalletForm : Form
    {

        public WalletModel wallet;
        private Image icon = null;
        public AddWalletForm()
        {
            InitializeComponent();
            Amount.Maximum = Decimal.MaxValue;
            Amount.Minimum = Decimal.MinValue;

        }


        private bool valid()
        {
            if (this.WalletName.Text == "") return false;
            if (this.icon == null) return false;
            return true;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                this.wallet = new WalletModel(this.WalletName.Text, (double)this.Amount.Value, ImageProccess.ImageToByte(icon));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.icon = this.pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.icon = this.pictureBox3.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.icon = this.pictureBox1.Image;
        }
    }

}
