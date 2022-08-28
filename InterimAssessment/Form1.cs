using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace InterimAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            shopritedb.openConn();
            MySqlCommand command;

            if (usernametxt.Text != "" & passwordtxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from admins where username = '" + usernametxt.Text + "' and password = '"+passwordtxt.Text+"'";
                    command = new MySqlCommand(countQuery, shopritedb.conn);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {

                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();

                        shopritedb.closeConn();
                    }
                    else
                    {
                        string query = "select * from attendants where username = '" + usernametxt.Text + "' and password = '" + passwordtxt.Text + "'";
                        try
                        {
                            command = new MySqlCommand(query, shopritedb.conn);
                            MySqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                reader.Close();
                                shopritedb.closeConn();

                                Form3 form3 = new Form3();
                                form3.Show();
                                this.Hide();
                            }
                            else
                            {
                                reader.Close();
                                shopritedb.closeConn();
                                MessageBox.Show("Invalid Details");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error 404");
                }
            }
            else
            {
                MessageBox.Show("Please enter all the details", "Warning");
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == false)
                passwordtxt.UseSystemPasswordChar = true;
            else
                passwordtxt.UseSystemPasswordChar = false;
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}