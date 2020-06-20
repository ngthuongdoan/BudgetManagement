using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class Login : Form
    {

        private bool isChecked = false;
        private const int CS_DROPSHADOW = 0x00020000;
        private bool isSignupEyeClicked = false;
        private bool isLoginEyeClicked = false;


        public Login()
        {
            InitializeComponent();
            Init();
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

        private void Init()
        {
            this.LoginUsername.Text = "";
            this.LoginPassword.Text = "";
            this.SignupUsername.Text = "";
            this.SignupUsernameError.Text = "";
            this.SignupEmail.Text = "";
            this.SignupEmailError.Text = "";
            this.SignupPassword.Text = "";
            this.SignupPasswordError.Text = "";
            this.SignupFullName.Text = "";
            this.SignupFullNameError.Text = "";
        }

        private void ClearError()
        {
            this.SignupUsernameError.Text = "";
            this.SignupEmailError.Text = "";
            this.SignupPasswordError.Text = "";
        }

        private void AdditionUI()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.FromArgb(243, 249, 254);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool checkUsername()
        {
            // trùng username
            if (this.SignupUsername.Text == "") return false;
            string selectString = $"SELECT * FROM users WHERE username = '{this.SignupUsername.Text}'";
            Connection.Connect();
            SqlDataReader reader = Connection.Select(selectString);
            try
            {
                reader.Read();
                string username = reader["username"].ToString();
                Connection.Close();
                if (username == this.SignupUsername.Text) return false;

            }
            catch
            {
                return true;
            }
            return true;
        }

        private bool checkEmail()
        {
            if (this.SignupEmail.Text == "") return false;
            return (new EmailAddressAttribute().IsValid(this.SignupEmail.Text));
        }

        private bool checkFullName()
        {
            return this.SignupFullName.Text != "";
        }

        private bool checkPassword()
        {
            string password = this.SignupPassword.Text;
            if (password == "") return false;
            if (password.Length < 8) return false;
            if (password.Contains(" ")) return false;
            return true;
        }

        public byte[] OpenImage(string path)
        {
            Image img = Image.FromFile(path);
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, ImageFormat.Png); // change to other format
            return tmpStream.GetBuffer();
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            ClearError();
            if (!checkUsername()) this.SignupUsernameError.Text = "Username duplicated";
            if (!checkEmail()) this.SignupEmailError.Text = "Email invalid";
            if (!checkFullName()) this.SignupFullNameError.Text = "Required";
            if (!checkPassword()) this.SignupPasswordError.Text = "Password must at least 8 chars, not contains spaces";
            isChecked = checkUsername() && checkEmail() && checkPassword() && checkFullName();
            if (isChecked)
            {
                // Convert name to UTF-8
                byte[] bytes = Encoding.UTF8.GetBytes(this.SignupFullName.Text);
                string fullname = Encoding.GetEncoding(1252).GetString(bytes);
                //Hash password
                var hashedPassword = SecurePasswordHasher.Hash(this.SignupPassword.Text);
                //Read avatar
                FileInfo finfo = new FileInfo(@"E:\Code\.NET\BudgetManagement\img\avatar-placeholder.png");
                byte[] btImage = new byte[finfo.Length];
                FileStream fStream = finfo.OpenRead();
                fStream.Read(btImage, 0, btImage.Length);
                fStream.Close();
                string insertString = $"INSERT INTO users VALUES (" +
                    $"'{this.SignupUsername.Text}'," +
                    $"'{this.SignupEmail.Text}'," +
                    $"'{fullname}'," +
                    $"'{hashedPassword}'," +
                    $"@AVATAR)";
                try
                {
                    Connection.Connect();
                    SqlCommand cmd = new SqlCommand(insertString, Connection.conn);
                    SqlParameter imageParameter = new SqlParameter("@AVATAR", SqlDbType.Image);
                    imageParameter.Value = btImage;
                    cmd.Parameters.Add(imageParameter);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show(
                        "You have been registered!!!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Init();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(
                        "Something Wrong. Please try again",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

            }
        }

        private void SignupShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (!isSignupEyeClicked)
            {
                this.SignupPassword.PasswordChar = '\0';
                isSignupEyeClicked = true;
            }
            else
            {
                this.SignupPassword.PasswordChar = '*';
                isSignupEyeClicked = false;
            }
        }

        private void LoginShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (!isLoginEyeClicked)
            {
                this.LoginPassword.PasswordChar = '\0';
                isLoginEyeClicked = true;
            }
            else
            {
                this.LoginPassword.PasswordChar = '*';
                isLoginEyeClicked = false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string selectString = $"SELECT * FROM users WHERE username = '{this.LoginUsername.Text}'";
            try
            {
                Connection.Connect();
                SqlDataReader reader = Connection.Select(selectString);
                reader.Read();
                bool isAuthenticated = SecurePasswordHasher.Verify(this.LoginPassword.Text, reader["password"].ToString());
                if (isAuthenticated)
                {
                    byte[] bytes = Encoding.GetEncoding(1252).GetBytes((string)reader["fullname"]);
                    string fullname = Encoding.UTF8.GetString(bytes);
                    Connection.Close();
                    Dashboard dashboard = new Dashboard(this.LoginUsername.Text, fullname);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Incorrect username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
