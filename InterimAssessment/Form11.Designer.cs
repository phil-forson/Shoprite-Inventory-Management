namespace InterimAssessment
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.label3 = new System.Windows.Forms.Label();
            this.backF5 = new System.Windows.Forms.Button();
            this.addAttBtn = new System.Windows.Forms.Button();
            this.attNameLabel = new System.Windows.Forms.Label();
            this.attfname = new System.Windows.Forms.TextBox();
            this.attPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.attlname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(96, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 45);
            this.label3.TabIndex = 29;
            this.label3.Text = "Update Attendant";
            // 
            // backF5
            // 
            this.backF5.BackColor = System.Drawing.Color.Black;
            this.backF5.FlatAppearance.BorderSize = 0;
            this.backF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF5.ForeColor = System.Drawing.Color.Transparent;
            this.backF5.Location = new System.Drawing.Point(265, 428);
            this.backF5.Name = "backF5";
            this.backF5.Size = new System.Drawing.Size(135, 51);
            this.backF5.TabIndex = 36;
            this.backF5.Text = "Back";
            this.backF5.UseVisualStyleBackColor = false;
            this.backF5.Click += new System.EventHandler(this.backF5_Click);
            // 
            // addAttBtn
            // 
            this.addAttBtn.BackColor = System.Drawing.Color.Black;
            this.addAttBtn.FlatAppearance.BorderSize = 0;
            this.addAttBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAttBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAttBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addAttBtn.Location = new System.Drawing.Point(419, 428);
            this.addAttBtn.Name = "addAttBtn";
            this.addAttBtn.Size = new System.Drawing.Size(166, 51);
            this.addAttBtn.TabIndex = 35;
            this.addAttBtn.Text = "Update Attendant";
            this.addAttBtn.UseVisualStyleBackColor = false;
            this.addAttBtn.Click += new System.EventHandler(this.addProd_Click);
            // 
            // attNameLabel
            // 
            this.attNameLabel.AutoSize = true;
            this.attNameLabel.Location = new System.Drawing.Point(210, 215);
            this.attNameLabel.Name = "attNameLabel";
            this.attNameLabel.Size = new System.Drawing.Size(150, 20);
            this.attNameLabel.TabIndex = 32;
            this.attNameLabel.Text = "Attendant First Name";
            this.attNameLabel.Click += new System.EventHandler(this.attNameLabel_Click);
            // 
            // attfname
            // 
            this.attfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attfname.Location = new System.Drawing.Point(210, 238);
            this.attfname.Name = "attfname";
            this.attfname.Size = new System.Drawing.Size(375, 27);
            this.attfname.TabIndex = 30;
            // 
            // attPass
            // 
            this.attPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attPass.Location = new System.Drawing.Point(210, 382);
            this.attPass.Name = "attPass";
            this.attPass.Size = new System.Drawing.Size(375, 27);
            this.attPass.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Attendant Password";
            // 
            // attusername
            // 
            this.attusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attusername.Location = new System.Drawing.Point(210, 163);
            this.attusername.Name = "attusername";
            this.attusername.Size = new System.Drawing.Size(375, 27);
            this.attusername.TabIndex = 40;
            this.attusername.TextChanged += new System.EventHandler(this.attID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Attendant Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Attendant Last Name";
            // 
            // attlname
            // 
            this.attlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attlname.Location = new System.Drawing.Point(210, 308);
            this.attlname.Name = "attlname";
            this.attlname.Size = new System.Drawing.Size(375, 27);
            this.attlname.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(844, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attlname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.attusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attPass);
            this.Controls.Add(this.backF5);
            this.Controls.Add(this.addAttBtn);
            this.Controls.Add(this.attNameLabel);
            this.Controls.Add(this.attfname);
            this.Controls.Add(this.label3);
            this.Name = "Form11";
            this.Text = "Update Attendant";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button backF5;
        private Button addAttBtn;
        private Label attNameLabel;
        private TextBox attfname;
        private TextBox attPass;
        private Label label2;
        private TextBox attusername;
        private Label label4;
        private Label label5;
        private TextBox attlname;
        private PictureBox pictureBox1;
    }
}