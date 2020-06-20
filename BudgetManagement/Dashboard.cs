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
        private string user;
        private string fullname;
        public Dashboard(string username, string fullname)
        {
            this.user = username;
            this.fullname = fullname;
            InitializeComponent();
            AdditionUI();
        }


        private void AdditionUI()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Username.Text = this.fullname;
            UpdateAvatar();
        }

        private void UpdateAvatar()
        {
            Connection.Connect();
            SqlDataReader reader = Connection.Select($"SELECT avatar FROM users WHERE username = '{this.user}'");
            reader.Read();
            MemoryStream ms = new MemoryStream((byte[])reader["avatar"]);
            this.Avatar.Image = Image.FromStream(ms);
            this.Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Avatar.Refresh();
            Connection.Close();
            ms.Close();
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
                    string updateString = $"UPDATE users SET avatar=@AVATAR WHERE username = '{this.user}'";
                    SqlCommand cmd = new SqlCommand(updateString, Connection.conn);
                    SqlParameter imageParameter = new SqlParameter("@AVATAR", SqlDbType.Image);
                    imageParameter.Value = btImage;
                    cmd.Parameters.Add(imageParameter);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
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

        private void WalletMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.WalletTab;
        }

        private void TransactionMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.TransactionTab;

        }

        private void DebtMenu_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.DebtTab;
        }
    }
}
