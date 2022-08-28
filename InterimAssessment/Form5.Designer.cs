namespace InterimAssessment
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label3 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delProducts = new System.Windows.Forms.Button();
            this.viewProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backF5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product Management";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Location = new System.Drawing.Point(101, 155);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(825, 85);
            this.addbtn.TabIndex = 20;
            this.addbtn.Text = "Add New Product";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(101, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(825, 85);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update Existing Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // delProducts
            // 
            this.delProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delProducts.Location = new System.Drawing.Point(101, 374);
            this.delProducts.Name = "delProducts";
            this.delProducts.Size = new System.Drawing.Size(825, 85);
            this.delProducts.TabIndex = 26;
            this.delProducts.Text = "Delete Product";
            this.delProducts.UseVisualStyleBackColor = true;
            this.delProducts.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewProd
            // 
            this.viewProd.BackColor = System.Drawing.Color.Black;
            this.viewProd.FlatAppearance.BorderSize = 0;
            this.viewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewProd.ForeColor = System.Drawing.Color.Transparent;
            this.viewProd.Location = new System.Drawing.Point(101, 476);
            this.viewProd.Name = "viewProd";
            this.viewProd.Size = new System.Drawing.Size(825, 85);
            this.viewProd.TabIndex = 27;
            this.viewProd.Text = "View Products";
            this.viewProd.UseVisualStyleBackColor = false;
            this.viewProd.Click += new System.EventHandler(this.viewProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::InterimAssessment.Properties.Resources.backbtn;
            this.label1.Location = new System.Drawing.Point(886, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 28;
            // 
            // backF5
            // 
            this.backF5.BackColor = System.Drawing.Color.Black;
            this.backF5.FlatAppearance.BorderSize = 0;
            this.backF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF5.ForeColor = System.Drawing.Color.Transparent;
            this.backF5.Location = new System.Drawing.Point(791, 95);
            this.backF5.Name = "backF5";
            this.backF5.Size = new System.Drawing.Size(135, 51);
            this.backF5.TabIndex = 30;
            this.backF5.Text = "Back";
            this.backF5.UseVisualStyleBackColor = false;
            this.backF5.Click += new System.EventHandler(this.backF5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1081, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backF5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewProd);
            this.Controls.Add(this.delProducts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label3);
            this.Name = "Form5";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button4;
        private Label label3;
        private Button addbtn;
        private Button button1;
        private Button delProducts;
        private Button viewProd;
        private Label label1;
        private Button backF5;
        private PictureBox pictureBox1;
    }
}