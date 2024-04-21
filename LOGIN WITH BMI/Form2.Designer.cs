namespace LOGIN_WITH_BMI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxBMI = new System.Windows.Forms.PictureBox();
            this.generatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Loadbtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHeight1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWeight1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(453, 213);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(16, 13);
            this.lblBMI.TabIndex = 19;
            this.lblBMI.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "BMI";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(453, 184);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(16, 13);
            this.lblRemarks.TabIndex = 17;
            this.lblRemarks.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Remarks";
            // 
            // pbxBMI
            // 
            this.pbxBMI.Image = ((System.Drawing.Image)(resources.GetObject("pbxBMI.Image")));
            this.pbxBMI.Location = new System.Drawing.Point(382, 29);
            this.pbxBMI.Margin = new System.Windows.Forms.Padding(2);
            this.pbxBMI.Name = "pbxBMI";
            this.pbxBMI.Size = new System.Drawing.Size(143, 128);
            this.pbxBMI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBMI.TabIndex = 10;
            this.pbxBMI.TabStop = false;
            // 
            // generatebtn
            // 
            this.generatebtn.AutoRoundedCorners = true;
            this.generatebtn.BackColor = System.Drawing.Color.Transparent;
            this.generatebtn.BorderRadius = 15;
            this.generatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))));
            this.generatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generatebtn.ForeColor = System.Drawing.Color.White;
            this.generatebtn.Location = new System.Drawing.Point(39, 208);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(234, 33);
            this.generatebtn.TabIndex = 22;
            this.generatebtn.Text = "CALCULATE";
            this.generatebtn.UseTransparentBackground = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.AutoRoundedCorners = true;
            this.Loadbtn.BackColor = System.Drawing.Color.Transparent;
            this.Loadbtn.BorderRadius = 15;
            this.Loadbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loadbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loadbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loadbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loadbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))));
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loadbtn.ForeColor = System.Drawing.Color.White;
            this.Loadbtn.Location = new System.Drawing.Point(534, 405);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(117, 33);
            this.Loadbtn.TabIndex = 26;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseTransparentBackground = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(375, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // txtHeight1
            // 
            this.txtHeight1.AutoRoundedCorners = true;
            this.txtHeight1.BackColor = System.Drawing.Color.Transparent;
            this.txtHeight1.BorderRadius = 17;
            this.txtHeight1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeight1.DefaultText = "";
            this.txtHeight1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHeight1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHeight1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.txtHeight1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHeight1.ForeColor = System.Drawing.Color.White;
            this.txtHeight1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight1.Location = new System.Drawing.Point(39, 84);
            this.txtHeight1.Name = "txtHeight1";
            this.txtHeight1.PasswordChar = '\0';
            this.txtHeight1.PlaceholderText = "Height";
            this.txtHeight1.SelectedText = "";
            this.txtHeight1.Size = new System.Drawing.Size(234, 36);
            this.txtHeight1.TabIndex = 28;
            // 
            // txtWeight1
            // 
            this.txtWeight1.AutoRoundedCorners = true;
            this.txtWeight1.BackColor = System.Drawing.Color.Transparent;
            this.txtWeight1.BorderRadius = 17;
            this.txtWeight1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight1.DefaultText = "";
            this.txtWeight1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.txtWeight1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight1.ForeColor = System.Drawing.Color.White;
            this.txtWeight1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight1.Location = new System.Drawing.Point(39, 142);
            this.txtWeight1.Name = "txtWeight1";
            this.txtWeight1.PasswordChar = '\0';
            this.txtWeight1.PlaceholderText = "Weight";
            this.txtWeight1.SelectedText = "";
            this.txtWeight1.Size = new System.Drawing.Size(234, 36);
            this.txtWeight1.TabIndex = 29;
            this.txtWeight1.TextChanged += new System.EventHandler(this.txtWeight1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWeight1);
            this.Controls.Add(this.txtHeight1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxBMI);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxBMI;
        private Guna.UI2.WinForms.Guna2Button generatebtn;
        private Guna.UI2.WinForms.Guna2Button Loadbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtHeight1;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight1;
    }
}