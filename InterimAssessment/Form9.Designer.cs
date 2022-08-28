namespace InterimAssessment
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.tableView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backtoF5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(116, 175);
            this.tableView.Name = "tableView";
            this.tableView.RowHeadersWidth = 51;
            this.tableView.RowTemplate.Height = 29;
            this.tableView.Size = new System.Drawing.Size(553, 226);
            this.tableView.TabIndex = 0;
            this.tableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableView_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(258, 142);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(411, 27);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            // 
            // backtoF5
            // 
            this.backtoF5.BackColor = System.Drawing.Color.Black;
            this.backtoF5.FlatAppearance.BorderSize = 0;
            this.backtoF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoF5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backtoF5.ForeColor = System.Drawing.Color.Transparent;
            this.backtoF5.Location = new System.Drawing.Point(534, 417);
            this.backtoF5.Name = "backtoF5";
            this.backtoF5.Size = new System.Drawing.Size(135, 51);
            this.backtoF5.TabIndex = 30;
            this.backtoF5.Text = "Back";
            this.backtoF5.UseVisualStyleBackColor = false;
            this.backtoF5.Click += new System.EventHandler(this.backtoF5_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Product Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backtoF5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.tableView);
            this.Name = "Form9";
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tableView;
        private TextBox searchBox;
        private Label label3;
        private Button backF5;
        private Button backtoF5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}