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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            collectProducts();
        }

        private void collectProducts()
        {
            string query = "select * from products";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                shopritedb.openConn();
                MySqlCommand command = new MySqlCommand(query, shopritedb.conn);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                shopritedb.closeConn();

                dv = ds.Tables[0].DefaultView;
                tableView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryy = "select * from products where prodName like '" + searchBox.Text + "%'";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (searchBox.Text != "")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(queryy, shopritedb.conn);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    shopritedb.closeConn();

                    dv = ds.Tables[0].DefaultView;
                    tableView.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                collectProducts();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string queryy = "select * from products where prodName like '" + searchBox.Text + "%'";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (searchBox.Text != "")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(queryy, shopritedb.conn);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    shopritedb.closeConn();

                    dv = ds.Tables[0].DefaultView;
                    tableView.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                collectProducts();
            }

        }

        private void tableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void backtoF5_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
