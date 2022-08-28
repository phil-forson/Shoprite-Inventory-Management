namespace InterimAssessment
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.backF10 = new System.Windows.Forms.Button();
            this.delAtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attusername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backF10
            // 
            this.backF10.BackColor = System.Drawing.Color.Black;
            this.backF10.FlatAppearance.BorderSize = 0;
            this.backF10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backF10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backF10.ForeColor = System.Drawing.Color.Transparent;
            this.backF10.Location = new System.Drawing.Point(260, 287);
            this.backF10.Name = "backF10";
            this.backF10.Size = new System.Drawing.Size(135, 51);
            this.backF10.TabIndex = 34;
            this.backF10.Text = "Back";
            this.backF10.UseVisualStyleBackColor = false;
            this.backF10.Click += new System.EventHandler(this.backF10_Click);
            // 
            // delAtt
            // 
            this.delAtt.BackColor = System.Drawing.Color.Black;
            this.delAtt.FlatAppearance.BorderSize = 0;
            this.delAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delAtt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delAtt.ForeColor = System.Drawing.Color.Transparent;
            this.delAtt.Location = new System.Drawing.Point(413, 287);
            this.delAtt.Name = "delAtt";
            this.delAtt.Size = new System.Drawing.Size(182, 51);
            this.delAtt.TabIndex = 33;
            this.delAtt.Text = "Delete Attendant";
            this.delAtt.UseVisualStyleBackColor = false;
            this.delAtt.Click += new System.EventHandler(this.delAtt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Attendant Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 45);
            this.label3.TabIndex = 31;
            this.label3.Text = "Delete Attendant";
            // 
            // attusername
            // 
            this.attusername.Location = new System.Drawing.Point(124, 232);
            this.attusername.Name = "attusername";
            this.attusername.Size = new System.Drawing.Size(472, 27);
            this.attusername.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backF10);
            this.Controls.Add(this.delAtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attusername);
            this.Name = "Form12";
            this.Text = "Delete Attendant";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backF10;
        private Button delAtt;
        private Label label1;
        private Label label3;
        private TextBox attusername;
        private PictureBox pictureBox1;
    }
}