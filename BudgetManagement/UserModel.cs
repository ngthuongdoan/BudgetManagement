using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public class UserModel
    {
        private string username;
        private string fullname;
        private string email;
        private string password;
        private byte[] avatar;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string FullName
        {
            get { return this.fullname; }
            set { this.fullname = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public byte[] Avatar
        {
            get { return this.avatar; }
            set { this.avatar = value; }
        }

        public UserModel()
        {
            this.username = "";
            this.fullname = "";
            this.email = "";
            this.password = "";
            this.avatar = Enumerable.Repeat((byte)0x20, 0).ToArray();
        }

        public UserModel(UserModel user)
        {
            this.username = user.Username;
            this.fullname = user.FullName;
            this.email = user.Email;
            this.password = user.Password;
            this.avatar = user.Avatar;
        }
        public string ChangeUTF8(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            return fullname = Encoding.GetEncoding(1252).GetString(bytes);
        }

        public string ChangeToNormal(string s)
        {
            byte[] bytes = Encoding.GetEncoding(1252).GetBytes(s);
            return Encoding.UTF8.GetString(bytes);
        }

        public string HashPassword(string password)
        {
            return SecurePasswordHasher.Hash(password);
        }

        public byte[] ChangeAvatar(string url)
        {
            FileInfo finfo = new FileInfo(url);
            byte[] btImage = new byte[finfo.Length];
            FileStream fStream = finfo.OpenRead();
            fStream.Read(btImage, 0, btImage.Length);
            fStream.Close();
            return btImage;
        }
    }
}
