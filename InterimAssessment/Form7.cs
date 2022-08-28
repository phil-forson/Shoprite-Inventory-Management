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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void delProd_Click(object sender, EventArgs e)
        {
            shopritedb.openConn();
            MySqlCommand command;


            if (prodID.Text != "" )
            {
                try
                {

                    string countQuery = "select count(*) from products where prodID = '" + prodID.Text + "'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {

                        string queryy = "delete from products where prodID = '" + prodID.Text + "'";
                        command = new MySqlCommand(queryy, shopritedb.conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product Deleted Successfully");

                        shopritedb.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("ID not valid");
                    }

                    prodID.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter the product ID");
            }
        }

        private void prodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void backF5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prodID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
