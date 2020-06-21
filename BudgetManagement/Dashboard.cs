using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core;

namespace BudgetManagement
{
    public partial class Dashboard : Form
    {
        private UserModel user;
        private const int CS_DROPSHADOW = 0x00020000;

        public Dashboard(UserModel user)
        {
            this.user = new UserModel(user);
            InitializeComponent();
            AdditionUI();
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void AdditionUI()
        {

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Username.Text = this.user.ChangeToNormal(this.user.FullName);
            UpdateAvatar();
        }

        private void UpdateAvatar()
        {

            MemoryStream ms = new MemoryStream(this.user.Avatar);
            this.Avatar.Image = Image.FromStream(ms);
            this.Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Avatar.Refresh();
        }
        private void ChangeAvatar()
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FileInfo finfo = new FileInfo(open.FileName);
                    byte[] btImage = new byte[finfo.Length];
                    FileStream fStream = finfo.OpenRead();
                    fStream.Read(btImage, 0, btImage.Length);
                    fStream.Close();
                    Connection.Connect();
                    string updateString = $"UPDATE users SET avatar=@AVATAR WHERE username = '{this.user.Username}'";
                    SqlCommand cmd = new SqlCommand(updateString, Connection.conn);
                    SqlParameter imageParameter = new SqlParameter("@AVATAR", SqlDbType.Image);
                    imageParameter.Value = btImage;
                    cmd.Parameters.Add(imageParameter);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    this.user.Avatar = btImage;
                    UpdateAvatar();
                }
            }
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            ChangeAvatar();
        }

        private void ShowContent()
        {
            this.WalletContainer.Controls.Clear();
            WalletContainer.AutoScroll = false;
            WalletContainer.HorizontalScroll.Enabled = false;
            WalletContainer.HorizontalScroll.Visible = false;
            WalletContainer.HorizontalScroll.Maximum = 0;
            WalletContainer.AutoScroll = true;
            Connection.Connect();
            SqlDataReader reader = Connection.Select($"SELECT * FROM wallets WHERE username = '{this.user}'");
            //select wallet and show
            Connection.Close();
        }
        private void WalletMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.WalletTab;
            ShowContent();
        }

        private void TransactionMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.TransactionTab;
        }

        private void DebtMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.DebtTab;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ShowContent();
        }
    }
}
