using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public static class Connection
    {
        public static SqlConnection conn;

        public static void Connect()
        {
            try
            {
                string ConnectionString = "Server=localhost;Database=BudgetManagement;Trusted_Connection=True;MultipleActiveResultSets=true;";
                conn = new SqlConnection(ConnectionString);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static SqlDataReader Select(string selectString)
        {

            SqlCommand cmd = new SqlCommand(selectString, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static object SelectScalar(string selectString)
        {

            SqlCommand cmd = new SqlCommand(selectString, conn);
            return cmd.ExecuteScalar();
        }
        public static void Insert(string insertString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(string updateString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Delete(string deleteString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
