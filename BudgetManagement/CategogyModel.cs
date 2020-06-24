using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public static class CategogyModel
    {
        public static void InsertCategogy()
        {
            string[] a = {
                "Award",
                "Bill",
                "Drink",
                "Eat",
                "Education",
                "Entertainment",
                "Family",
                "Health",
                "Interest",
                "Other",
                "Relationship",
                "Rent",
                "Salary",
                "Selling",
                "Shopping"
            };
            foreach (string item in a)
            {
                FileInfo finfo = new FileInfo(@"E:\Code\.NET\BudgetManagement\img\icons\" + item + ".png");
                byte[] btImage = new byte[finfo.Length];
                FileStream fStream = finfo.OpenRead();
                fStream.Read(btImage, 0, btImage.Length);
                fStream.Close();
                Connection.Connect();
                SqlCommand cmd = new SqlCommand($"INSERT INTO categogies VALUES ('{item}', @AVATAR)", Connection.conn);
                SqlParameter imageParameter = new SqlParameter("@AVATAR", SqlDbType.Image);
                imageParameter.Value = btImage;
                cmd.Parameters.Add(imageParameter);
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
        }
    }
}
