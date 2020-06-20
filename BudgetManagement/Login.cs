using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class login : Form
    {

        private bool isChecked = false;
        private const int CS_DROPSHADOW = 0x00020000;
        private bool isSignupEyeClicked = false;
        private bool isLoginEyeClicked = false;


        public login()
        {
            InitializeComponent();
            Init();
            AdditionUI();
            Connection.Connect();

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
            this.Close();
        }

        private bool checkUsername()
        {
            // trùng username
            if (this.SignupUsername.Text == "") return false;
            string selectString = $"SELECT * FROM users WHERE username = '{this.SignupUsername.Text}'";
            SqlDataReader reader = Connection.Select(selectString);
            try
            {
                reader.Read();
                string username = reader["username"].ToString();
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

        private bool checkPassword()
        {
            string password = this.SignupPassword.Text;
            if (password == "") return false;
            if (password.Length < 8) return false;
            if (password.Contains(" ")) return false;
            return true;
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            ClearError();
            if (!checkUsername()) this.SignupUsernameError.Text = "Username duplicated";
            if (!checkEmail()) this.SignupEmailError.Text = "Email invalid";
            if (!checkPassword()) this.SignupPasswordError.Text = "Password must at least 8 chars, not contains spaces";
            isChecked = checkUsername() && checkEmail() && checkPassword();
            if (isChecked)
            {
                //INSERT DATABASE
                // Hash
                var hashedPassword = SecurePasswordHasher.Hash("mypassword");
                // Verify
                //var result = SecurePasswordHasher.Verify("mypassword", hash);
                string insertString = $"INSERT INTO users VALUES (" +
                    $"'{this.SignupUsername.Text}'," +
                    $"'{this.SignupEmail.Text}'," +
                    $"'{hashedPassword}')";
                Connection.Insert(insertString);
                MessageBox.Show(
                    "You have been registered!!!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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
    }
}
