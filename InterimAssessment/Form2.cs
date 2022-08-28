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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                        MessageBox.Show("Signed Up Successfully");
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter all the details", "Warning");
            }
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
