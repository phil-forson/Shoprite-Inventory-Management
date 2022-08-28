namespace InterimAssessment
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manageProd = new System.Windows.Forms.Button();
            this.manageAtt = new System.Windows.Forms.Button();
            this.backF5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(252, 127);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 20);
            this.username.TabIndex = 5;
            this.username.Text = "What would you like to do today?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(252, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hello Admin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // manageProd
            // 
            this.manageProd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageProd.Location = new System.Drawing.Point(252, 187);
            this.manageProd.Name = "manageProd";
            this.manageProd.Size = new System.Drawing.Size(543, 82);
            this.manageProd.TabIndex = 11;
            this.manageProd.Text = "Product Management";
            this.manageProd.UseVisualStyleBackColor = true;
            this.manageProd.Click += new System.EventHandler(this.manageProd_Click);
            // 
            // manageAtt
            // 
            this.manageAtt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageAtt.Location = new System.Drawing.Point(252, 316);
            this.manageAtt.Name = "manageAtt";
            this.manageAtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.manageAtt.Size = new System.Drawing.Size(543, 82);
            this.manageAtt.TabIndex = 13;
            this.manageAtt.Text = "Attendant Management";
            this.manageAtt.UseVisualStyleBackColor = true;
            this.manageAtt.Click += new System.EventHandler(this.manageAtt_Click);
            // 
            // backF5
            // 
            this.backF5.BackColor = System.Drawing.Color.Black;
            this.backF5.FlatAppearance.BorderSize = 0;
            this.backF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF5.ForeColor = System.Drawing.Color.Transparent;
            this.backF5.Location = new System.Drawing.Point(660, 111);
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
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1144, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backF5);
            this.Controls.Add(this.manageAtt);
            this.Controls.Add(this.manageProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Name = "Form4";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label username;
        private Label label3;
        private Button manageProd;
        private Button manageAtt;
        private Button backF5;
        private PictureBox pictureBox1;
    }
}