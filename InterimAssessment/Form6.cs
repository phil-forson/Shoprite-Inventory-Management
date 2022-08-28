using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace InterimAssessment
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }



        private void addProd_Click(object sender, EventArgs e)
        {
            shopritedb.openConn();
            MySqlCommand command;


            if (prodName.Text != "" & prodCat.Text != "" & prodReadLevel.Text != "" & prodQuant.Text != "" & prodPrice.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from products where prodName = '" + prodName.Text + "'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Product Name Already Exists, Try Increasing the Quantity");
                        prodName.Text = "";
                        prodCat.Text = "";
                        prodReadLevel.Text = "";
                        prodPrice.Text = "";
                        prodQuant.Text = "";
                    }
                    else
                    {
                        double totalPrice = Convert.ToInt32(prodQuant.Text) * Convert.ToDouble(prodPrice.Text);
                        string queryy = "insert into products(prodName, prodCategory, prodReaderLevel, prodQuantity, prodPrice, totalPrice) values ('" + prodName.Text + "', '" + prodCat.Text + "', '" + prodReadLevel.Text + "', '" + prodQuant.Text + "', '" + prodPrice.Text + "', '" + totalPrice + "')";
                        command = new MySqlCommand(queryy, shopritedb.conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product Added Successfully at " + DateTime.Now);
                        prodName.Text = "";
                        prodCat.Text = "";
                        prodReadLevel.Text = "";
                        prodPrice.Text = "";
                        prodQuant.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter all details");
            }
        }

        private void backF5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void prodCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodReadLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prodNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
