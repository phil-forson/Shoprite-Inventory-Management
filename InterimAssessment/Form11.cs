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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void addProd_Click(object sender, EventArgs e)
        {
            if (attusername.Text != "")
            {
                shopritedb.openConn();
                MySqlCommand command;
                try
                {
                    string countQuery = "select count(*) from attendants where username = '" + attusername.Text + "'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        if (attfname.Text != "")
                        {
                            string query = "update attendants set fname = '" + attfname.Text + "' where username = '" + attusername.Text + "'";
                            command = new MySqlCommand(query, shopritedb.conn);
                            command.ExecuteNonQuery();
                            attfname.Text = "";
                            attusername.Text = "";
                            MessageBox.Show("Updated Successfully");
                        }
                        else if (attlname.Text != "")
                        {
                            string query = "update attendants set lname = '" + attlname.Text + "' where username = '" + attusername.Text + "'";
                            command = new MySqlCommand(query, shopritedb.conn);
                            command.ExecuteNonQuery();
                            attusername.Text = "";
                            attlname.Text = "";
                            MessageBox.Show("Updated Successfully");
                        }
                        else if (attPass.Text != "")
                        {
                            string query = "update attendants set password = '" + attPass.Text + "' where username = '" + attusername.Text + "'";
                            command = new MySqlCommand(query, shopritedb.conn);
                            command.ExecuteNonQuery();
                            attusername.Text = "";
                            attPass.Text = "";
                            MessageBox.Show("Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Provide Another Field To Update");
                        }


                        shopritedb.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Attendant does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error 404");
                }
            }
            else
            {
                MessageBox.Show("Product ID is required!");
            }
        }

        private void backF5_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void attID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void attNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
