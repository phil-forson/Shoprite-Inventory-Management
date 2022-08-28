namespace InterimAssessment
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.viewAtt = new System.Windows.Forms.Button();
            this.delAtt = new System.Windows.Forms.Button();
            this.upAtt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backF5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAtt
            // 
            this.viewAtt.BackColor = System.Drawing.Color.Black;
            this.viewAtt.FlatAppearance.BorderSize = 0;
            this.viewAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAtt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewAtt.ForeColor = System.Drawing.Color.Transparent;
            this.viewAtt.Location = new System.Drawing.Point(128, 472);
            this.viewAtt.Name = "viewAtt";
            this.viewAtt.Size = new System.Drawing.Size(825, 85);
            this.viewAtt.TabIndex = 32;
            this.viewAtt.Text = "View Attendants";
            this.viewAtt.UseVisualStyleBackColor = false;
            this.viewAtt.Click += new System.EventHandler(this.viewAtt_Click);
            // 
            // delAtt
            // 
            this.delAtt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delAtt.Location = new System.Drawing.Point(128, 360);
            this.delAtt.Name = "delAtt";
            this.delAtt.Size = new System.Drawing.Size(825, 85);
            this.delAtt.TabIndex = 31;
            this.delAtt.Text = "Delete Attendant";
            this.delAtt.UseVisualStyleBackColor = true;
            this.delAtt.Click += new System.EventHandler(this.delAtt_Click);
            // 
            // upAtt
            // 
            this.upAtt.BackColor = System.Drawing.Color.Black;
            this.upAtt.FlatAppearance.BorderSize = 0;
            this.upAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upAtt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upAtt.ForeColor = System.Drawing.Color.Transparent;
            this.upAtt.Location = new System.Drawing.Point(128, 252);
            this.upAtt.Name = "upAtt";
            this.upAtt.Size = new System.Drawing.Size(825, 85);
            this.upAtt.TabIndex = 30;
            this.upAtt.Text = "Update Attendant Info";
            this.upAtt.UseVisualStyleBackColor = false;
            this.upAtt.Click += new System.EventHandler(this.upAtt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 45);
            this.label3.TabIndex = 28;
            this.label3.Text = "Attendant Management";
            // 
            // backF5
            // 
            this.backF5.BackColor = System.Drawing.Color.Black;
            this.backF5.FlatAppearance.BorderSize = 0;
            this.backF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF5.ForeColor = System.Drawing.Color.Transparent;
            this.backF5.Location = new System.Drawing.Point(818, 90);
            this.backF5.Name = "backF5";
            this.backF5.Size = new System.Drawing.Size(135, 51);
            this.backF5.TabIndex = 33;
            this.backF5.Text = "Back";
            this.backF5.UseVisualStyleBackColor = false;
            this.backF5.Click += new System.EventHandler(this.backF5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(128, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(825, 85);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Attendant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1114, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backF5);
            this.Controls.Add(this.viewAtt);
            this.Controls.Add(this.delAtt);
            this.Controls.Add(this.upAtt);
            this.Controls.Add(this.label3);
            this.Name = "Form10";
            this.Text = "Manage Attendants";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button viewAtt;
        private Button delAtt;
        private Button upAtt;
        private Label label3;
        private Button backF5;
        private Button button1;
        private PictureBox pictureBox1;
    }
}