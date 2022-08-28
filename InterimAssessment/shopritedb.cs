using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterimAssessment
{
    internal class shopritedb
    {   
        public static string cString = "server=localhost; database=shoprite; uid=root; pwd=\"\";";
        public static MySqlConnection conn = new MySqlConnection(cString);

        public static void openConn()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fatal! Connection to Database Error");
            }
        }

        public static void closeConn()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to see my bestie!!!!!!!!!!!!!!!!!!");
            }
        }
    }
}
