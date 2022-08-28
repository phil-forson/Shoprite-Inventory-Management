namespace InterimAssessment
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.backF5 = new System.Windows.Forms.Button();
            this.updateProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.prodReadLevel = new System.Windows.Forms.ComboBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.prodQuant = new System.Windows.Forms.TextBox();
            this.prodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodCat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backF5
            // 
            this.backF5.BackColor = System.Drawing.Color.Black;
            this.backF5.FlatAppearance.BorderSize = 0;
            this.backF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF5.ForeColor = System.Drawing.Color.Transparent;
            this.backF5.Location = new System.Drawing.Point(267, 571);
            this.backF5.Name = "backF5";
            this.backF5.Size = new System.Drawing.Size(135, 51);
            this.backF5.TabIndex = 34;
            this.backF5.Text = "Back";
            this.backF5.UseVisualStyleBackColor = false;
            this.backF5.Click += new System.EventHandler(this.backF5_Click);
            // 
            // updateProd
            // 
            this.updateProd.BackColor = System.Drawing.Color.Black;
            this.updateProd.FlatAppearance.BorderSize = 0;
            this.updateProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateProd.ForeColor = System.Drawing.Color.Transparent;
            this.updateProd.Location = new System.Drawing.Point(422, 571);
            this.updateProd.Name = "updateProd";
            this.updateProd.Size = new System.Drawing.Size(135, 51);
            this.updateProd.TabIndex = 33;
            this.updateProd.Text = "Update";
            this.updateProd.UseVisualStyleBackColor = false;
            this.updateProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Product Reader Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Product Category";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(181, 227);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(104, 20);
            this.prodNameLabel.TabIndex = 30;
            this.prodNameLabel.Text = "Product Name";
            // 
            // prodReadLevel
            // 
            this.prodReadLevel.FormattingEnabled = true;
            this.prodReadLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4"});
            this.prodReadLevel.Location = new System.Drawing.Point(181, 384);
            this.prodReadLevel.Name = "prodReadLevel";
            this.prodReadLevel.Size = new System.Drawing.Size(375, 28);
            this.prodReadLevel.TabIndex = 29;
            // 
            // prodName
            // 
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodName.Location = new System.Drawing.Point(181, 250);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(375, 27);
            this.prodName.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Product Quantity";
            // 
            // prodPrice
            // 
            this.prodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodPrice.Location = new System.Drawing.Point(181, 452);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(375, 27);
            this.prodPrice.TabIndex = 38;
            // 
            // prodQuant
            // 
            this.prodQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodQuant.Location = new System.Drawing.Point(181, 522);
            this.prodQuant.Name = "prodQuant";
            this.prodQuant.Size = new System.Drawing.Size(375, 27);
            this.prodQuant.TabIndex = 37;
            // 
            // prodID
            // 
            this.prodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodID.Location = new System.Drawing.Point(181, 187);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(375, 27);
            this.prodID.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Product ID";
            // 
            // prodCat
            // 
            this.prodCat.FormattingEnabled = true;
            this.prodCat.Items.AddRange(new object[] {
            "Baking goods",
            "Beverages",
            "Canned goods",
            "Dairy",
            "Fish",
            "Frozen",
            "Grains",
            "Meat",
            "Pet",
            "Produce",
            "Snacks",
            "Spices",
            "Bandages",
            "Face masks",
            "Floss",
            "Hairstyling products (spray, mousse)",
            "Hand sanitizer",
            "Moisturizers",
            "Mouthwash",
            "Ointments",
            "Pain relievers",
            "Razors",
            "Shampoo and conditioner",
            "Shaving cream",
            "Shower gel",
            "Soap",
            "Sunblock",
            "Toothbrushes",
            "Toothpaste",
            "Batteries",
            "Cleaning supplies",
            "Laundry detergent",
            "Lightbulbs",
            "Office and school supplies",
            "Paper towels",
            "Tissues",
            "Toilet paper"});
            this.prodCat.Location = new System.Drawing.Point(181, 313);
            this.prodCat.Name = "prodCat";
            this.prodCat.Size = new System.Drawing.Size(375, 28);
            this.prodCat.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(122, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 41);
            this.label6.TabIndex = 44;
            this.label6.Text = "Update Products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prodCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodQuant);
            this.Controls.Add(this.backF5);
            this.Controls.Add(this.updateProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.prodReadLevel);
            this.Controls.Add(this.prodName);
            this.Name = "Form8";
            this.Text = "Update Products";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backF5;
        private Button updateProd;
        private Label label2;
        private Label label1;
        private Label prodNameLabel;
        private ComboBox prodReadLevel;
        private TextBox prodName;
        private Label label3;
        private TextBox prodID;
        private Label label5;
        private Label label4;
        private TextBox prodPrice;
        private TextBox prodQuant;
        private ComboBox prodCat;
        private Label label6;
        private PictureBox pictureBox1;
    }
}