using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace FPTA.Model
{
    class SambungDB
    {
        private static SqlConnection connect;

        public static SqlConnection GetConnection()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=TA;Integrated Security=True";
            return connect;
        }


        public void TestConnect()
        {
            GetConnection();
            try
            {
                connect.Open();
                MessageBox.Show("Connection success");
            }
            catch (SqlException se)

            {
                MessageBox.Show("Connection Failed " + se);
            }
        }
    }
}
