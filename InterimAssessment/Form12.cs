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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void backF10_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void delAtt_Click(object sender, EventArgs e)
        {
            shopritedb.openConn();
            MySqlCommand command;


            if (attusername.Text != "")
            {
                try
                {

                    string countQuery = "select count(*) from attendants where username = '" + attusername.Text + "'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {

                        string queryy = "delete from attendants where username = '" + attusername.Text + "'";
                        command = new MySqlCommand(queryy, shopritedb.conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Attendant Deleted Successfully");

                        shopritedb.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Username not valid");
                    }

                    attusername.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter the attendant username");
            }
        }
    }
}
