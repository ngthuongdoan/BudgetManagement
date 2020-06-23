using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class Form1 : Form
    {
        public string category;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetName(object sender, MouseEventArgs e)
        {
            this.category = (sender as PictureBox).Name;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.Connect();
            SqlDataReader reader = Connection.Select("SELECT * FROM categogies");
            try
            {
                while (reader.Read())
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = ImageProccess.ByteToImage((byte[])reader["categogyImage"]);
                    pic.Name = (string)reader["categogyName"];
                    pic.Cursor = Cursors.Hand;
                    pic.MouseClick += new MouseEventHandler(GetName);
                    this.flowLayoutPanel1.Controls.Add(pic);
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
