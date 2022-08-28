namespace InterimAssessment
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodReadLevel = new System.Windows.Forms.ComboBox();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backF5 = new System.Windows.Forms.Button();
            this.prodCat = new System.Windows.Forms.ComboBox();
            this.prodQuant = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prodName
            // 
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodName.Location = new System.Drawing.Point(175, 208);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(375, 27);
            this.prodName.TabIndex = 18;
            this.prodName.TextChanged += new System.EventHandler(this.prodName_TextChanged);
            // 
            // prodReadLevel
            // 
            this.prodReadLevel.FormattingEnabled = true;
            this.prodReadLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4"});
            this.prodReadLevel.Location = new System.Drawing.Point(175, 365);
            this.prodReadLevel.Name = "prodReadLevel";
            this.prodReadLevel.Size = new System.Drawing.Size(375, 28);
            this.prodReadLevel.TabIndex = 20;
            this.prodReadLevel.SelectedIndexChanged += new System.EventHandler(this.prodReadLevel_SelectedIndexChanged);
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(175, 185);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(104, 20);
            this.prodNameLabel.TabIndex = 21;
            this.prodNameLabel.Text = "Product Name";
            this.prodNameLabel.Click += new System.EventHandler(this.prodNameLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Product Reader Level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addProd
            // 
            this.addProd.BackColor = System.Drawing.Color.Black;
            this.addProd.FlatAppearance.BorderSize = 0;
            this.addProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProd.ForeColor = System.Drawing.Color.Transparent;
            this.addProd.Location = new System.Drawing.Point(415, 578);
            this.addProd.Name = "addProd";
            this.addProd.Size = new System.Drawing.Size(135, 51);
            this.addProd.TabIndex = 24;
            this.addProd.Text = "Add Product";
            this.addProd.UseVisualStyleBackColor = false;
            this.addProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 45);
            this.label3.TabIndex = 25;
            this.label3.Text = "Add Products";
            // 
            // backF5
            // 
            this.backF5.BackColor = System.Drawing.Color.Black;
            this.backF5.FlatAppearance.BorderSize = 0;
            this.backF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF5.ForeColor = System.Drawing.Color.Transparent;
            this.backF5.Location = new System.Drawing.Point(260, 578);
            this.backF5.Name = "backF5";
            this.backF5.Size = new System.Drawing.Size(135, 51);
            this.backF5.TabIndex = 26;
            this.backF5.Text = "Back";
            this.backF5.UseVisualStyleBackColor = false;
            this.backF5.Click += new System.EventHandler(this.backF5_Click);
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
            this.prodCat.Location = new System.Drawing.Point(175, 281);
            this.prodCat.Name = "prodCat";
            this.prodCat.Size = new System.Drawing.Size(375, 28);
            this.prodCat.TabIndex = 27;
            this.prodCat.SelectedIndexChanged += new System.EventHandler(this.prodCat_SelectedIndexChanged);
            // 
            // prodQuant
            // 
            this.prodQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodQuant.Location = new System.Drawing.Point(175, 434);
            this.prodQuant.Name = "prodQuant";
            this.prodQuant.Size = new System.Drawing.Size(375, 27);
            this.prodQuant.TabIndex = 28;
            // 
            // prodPrice
            // 
            this.prodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodPrice.Location = new System.Drawing.Point(175, 512);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(375, 27);
            this.prodPrice.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Product Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Product Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1085, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodQuant);
            this.Controls.Add(this.prodCat);
            this.Controls.Add(this.backF5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.prodReadLevel);
            this.Controls.Add(this.prodName);
            this.Name = "Form6";
            this.Text = "Add Products";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox prodName;
        private ComboBox prodReadLevel;
        private Label prodNameLabel;
        private Label label1;
        private Label label2;
        private Button addProd;
        private Label label3;
        private Button backF5;
        private ComboBox prodCat;
        private TextBox prodQuant;
        private TextBox prodPrice;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}