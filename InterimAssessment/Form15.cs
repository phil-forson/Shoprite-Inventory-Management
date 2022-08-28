using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterimAssessment
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            shopritedb.openConn();
            MySqlCommand command;

            if (fname.Text != "" & lname.Text != "" & usernametxt.Text != "" & passwordtxt.Text != "")
            {
                try
                {

                    string countQuery = "select count(*) from attendants where username = '" + usernametxt.Text + "'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists");
                        shopritedb.closeConn();
                    }
                    else
                    {
                        string queryy = "insert into attendants(fname, lname, username, password) values ('" + fname.Text + "', '" + lname.Text + "', '" + usernametxt.Text + "', '" + passwordtxt.Text + "')";
                        command = new MySqlCommand(queryy, shopritedb.conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Attendant Added Successfully");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter all the details", "Warning");
            }
        }
    }
}
