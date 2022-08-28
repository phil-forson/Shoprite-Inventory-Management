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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            collectAttendants();
        }

        private void collectAttendants()
        {
            string query = "select * from attendants";
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

        private void backtoF5_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string queryy = "select * from attendants where username like '" + searchBox.Text + "%'";
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
                collectAttendants();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryy = "select * from attendants where username like '" + searchBox.Text + "%'";
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
                MessageBox.Show("Its empty");
                collectAttendants();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }

}
