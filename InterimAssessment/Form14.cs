using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using MySql.Data.MySqlClient;

namespace InterimAssessment
{
    public partial class Form14 : Form
    {
        int order = 0;
        int sales = 1;
        public Form14()
        {
            InitializeComponent();
            tillTxt.Text = "Till Started at " + DateTime.Now.ToString();
        }
        private VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;


        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            orderno.Text = Convert.ToString(sales);
            receiptBindingSource.DataSource = new List<Receipt>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void startCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void scan_btn_Click(object sender, EventArgs e)
        {
            startCamera();
            MessageBox.Show("Camera Started");
        }
        

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (quantBox.Text != "")
            {
                double totalPrice = Convert.ToDouble(priceBox.Text) * Convert.ToDouble(quantBox.Text);
                totalBox.Text = totalPrice.ToString();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            shopritedb.openConn();
            MySqlCommand command;

            if (prodName.Text != "")
            {
                string query = "select * from products where prodName = '" + prodName.Text + "'";
                try
                {
                    command = new MySqlCommand(query, shopritedb.conn);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        priceBox.Text = reader.GetString(6);
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Foreign Item", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(quantBox.Text != "")
            {
                Receipt receipt = new Receipt() { Id = order++, Price = Convert.ToDouble(priceBox.Text), ProdName = prodName.Text , Quantity = Convert.ToInt32(quantBox.Text), Total = totalBox.Text};
                receiptBindingSource.Add(receipt);
                receiptBindingSource.MoveLast();
            }
            quantBox.Text = "";
            priceBox.Text = "";
            totalBox.Text = "";
            prodName.Text = "";
            cashBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt receipt = receiptBindingSource.Current as Receipt;
            receiptBindingSource.RemoveCurrent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int salesnum = sales++;
            orderno.Text = Convert.ToString(salesnum);
            receiptBindingSource.Clear();
        }

        private void orderno_Click(object sender, EventArgs e)
        {

        }
    }
}
