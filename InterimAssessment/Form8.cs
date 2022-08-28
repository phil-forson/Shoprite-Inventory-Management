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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void addProd_Click(object sender, EventArgs e)
        {
            if(prodID.Text != "")
            {
                shopritedb.openConn();
                MySqlCommand command;
                try
                {
                    string countQuery = "select count(*) from products where prodID = '" + prodID.Text + "'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        if (prodName.Text != "" & prodCat.Text == "" & prodReadLevel.Text == "")
                        {
                            try
                            {
                                string query = "update products set prodName = '" + prodName.Text + "' where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                prodName.Text = "";
                                prodID.Text = "";
                                MessageBox.Show("Updated Product Name Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Name Already Exists, try increasing the quantity instead");
                            }
                        }
                        else if (prodCat.Text != "" & prodReadLevel.Text == "" & prodName.Text == "")
                        {
                            try
                            {
                                string query = "update products set prodCategory = '" + prodCat.Text + "' where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                prodCat.Text = "";
                                prodID.Text = "";
                                MessageBox.Show("Updated Product Category Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (prodReadLevel.Text != "" & prodName.Text == "" & prodCat.Text == "")
                        {
                            try
                            {
                                string query = "update products set prodReaderLevel = '" + prodReadLevel.Text + "' where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                prodID.Text = "";
                                prodReadLevel.Text = "";
                                MessageBox.Show("Updated Product Reader Level Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (prodName.Text != "" & prodCat.Text != "")
                        {
                            try
                            {
                                string query = "update products set prodCategory = '" + prodCat.Text + "' , prodName = '" + prodName.Text + "' where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                prodID.Text = "";
                                prodName.Text = "";
                                prodCat.Text = "";
                                MessageBox.Show("Name and Category Updated Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Name Already Exists, try increasing the quantity instead");
                            }

                        }
                        else if (prodName.Text != "" & prodReadLevel.Text != "")
                        {
                            try
                            {
                                string query = "update products set prodReaderLevel = '" + prodReadLevel.Text + "' , prodName = '" + prodName.Text + "' where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                prodID.Text = "";
                                prodName.Text = "";
                                prodReadLevel.Text = "";
                                MessageBox.Show("Name and Reader Level Updated Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Name Already Exists, try increasing the quantity instead");
                            }
                        }
                        else if (prodCat.Text != "" & prodReadLevel.Text != "")
                        {
                            try
                            {
                                string query = "update products set prodReaderLevel = '" + prodReadLevel.Text + "' , prodCategory = '" + prodCat.Text + "' where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                prodID.Text = "";
                                prodCat.Text = "";
                                prodReadLevel.Text = "";
                                MessageBox.Show("Category and Reader Level Updated Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else if (prodName.Text != "" & prodCat.Text != "" & prodReadLevel.Text != "")
                        {
                            try
                            {
                                string query = "update products set prodReaderLevel = '" + prodReadLevel.Text + "' , prodName = '" + prodName.Text + "' , prodCategory = '" + prodCat.Text + "'where prodID = '" + prodID.Text + "'";
                                command = new MySqlCommand(query, shopritedb.conn);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Name, Category and Reader Level Updated Successfully");
                                prodName.Text = "";
                                prodCat.Text = "";
                                prodReadLevel.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Name Already Exists, try increasing the quantity instead");
                            }
                        }
                        else if (prodName.Text != "" & prodPrice.Text != "")
                        {
                            MessageBox.Show("Enter Product Category to Update");
                        }
                    else
                    {
                        if (prodPrice.Text != "" & prodQuant.Text == "")
                        {
                            MessageBox.Show("Enter the product quantity to update");
                        }
                        else if (prodPrice.Text == "" & prodQuant.Text != "")
                        {
                            MessageBox.Show("Enter the product price to update");
                        }
                        else if (prodPrice.Text != "" & prodQuant.Text != "")
                        {
                                try
                                {
                                    double totalPrice = Convert.ToDouble(prodPrice.Text) * Convert.ToInt32(prodQuant.Text);
                                    string query = "update products set prodPrice = '" + prodPrice.Text + "', totalPrice = '" + totalPrice + "', prodQuantity = '" + prodQuant.Text + "'  where prodID = '" + prodID.Text + "'";
                                    command = new MySqlCommand(query, shopritedb.conn);
                                    command.ExecuteNonQuery();
                                    prodID.Text = "";
                                    prodReadLevel.Text = "";
                                    prodPrice.Text = "";
                                    prodQuant.Text = "";
                                    MessageBox.Show("Updated Successfully");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                        }
                        else
                        {
                            MessageBox.Show("Fields Are Required To Update");
                        }

                    }
                        if (prodPrice.Text != "")
                        {
                            MessageBox.Show("Enter only the Product Price and Category To Update");
                        }
                        else if (prodQuant.Text != "")
                        {
                            MessageBox.Show("Enter only the Product Price and Category To Update");
                        }


                        shopritedb.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Product does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Product ID is required!");
            }
        }

        private void backF5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void prodCat_TextChanged(object sender, EventArgs e)
        {

        }
    }
   }
