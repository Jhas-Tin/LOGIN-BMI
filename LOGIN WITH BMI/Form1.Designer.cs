namespace LOGIN_WITH_BMI
{
    partial class Form1
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
            this.generatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.dgvtable = new System.Windows.Forms.DataGridView();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Registerbtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtable)).BeginInit();
            this.SuspendLayout();
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
            this.generatebtn.Location = new System.Drawing.Point(502, 207);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(154, 33);
            this.generatebtn.TabIndex = 12;
            this.generatebtn.Text = "Generate User";
            this.generatebtn.UseTransparentBackground = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // dgvtable
            // 
            this.dgvtable.AllowUserToAddRows = false;
            this.dgvtable.AllowUserToDeleteRows = false;
            this.dgvtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtable.BackgroundColor = System.Drawing.Color.White;
            this.dgvtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtable.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvtable.Location = new System.Drawing.Point(421, 66);
            this.dgvtable.Name = "dgvtable";
            this.dgvtable.ReadOnly = true;
            this.dgvtable.Size = new System.Drawing.Size(332, 120);
            this.dgvtable.TabIndex = 13;
            // 
            // txtpass
            // 
            this.txtpass.AutoRoundedCorners = true;
            this.txtpass.BackColor = System.Drawing.Color.Transparent;
            this.txtpass.BorderRadius = 17;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.Location = new System.Drawing.Point(69, 137);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '●';
            this.txtpass.PlaceholderText = "Password";
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(206, 36);
            this.txtpass.TabIndex = 5;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.AutoRoundedCorners = true;
            this.txtuser.BackColor = System.Drawing.Color.Transparent;
            this.txtuser.BorderRadius = 17;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(64)))));
            this.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuser.Location = new System.Drawing.Point(69, 84);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PlaceholderText = "Username";
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(206, 36);
            this.txtuser.TabIndex = 4;
            // 
            // SignInBtn
            // 
            this.SignInBtn.AutoRoundedCorners = true;
            this.SignInBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignInBtn.BorderRadius = 17;
            this.SignInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignInBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(9)))), ((int)(((byte)(113)))));
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(69, 204);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(100, 36);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.AutoRoundedCorners = true;
            this.Registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.Registerbtn.BorderRadius = 17;
            this.Registerbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Registerbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Registerbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Registerbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Registerbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(147)))));
            this.Registerbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Registerbtn.ForeColor = System.Drawing.Color.White;
            this.Registerbtn.Location = new System.Drawing.Point(175, 204);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(100, 36);
            this.Registerbtn.TabIndex = 2;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 448);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.dgvtable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button generatebtn;
        private System.Windows.Forms.DataGridView dgvtable;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
        private Guna.UI2.WinForms.Guna2Button SignInBtn;
        private Guna.UI2.WinForms.Guna2Button Registerbtn;
    }
}

