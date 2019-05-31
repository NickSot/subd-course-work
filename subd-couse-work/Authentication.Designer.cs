namespace subd_couse_work
{
    partial class AuthenticateForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.pageLogin = new System.Windows.Forms.Panel();
            this.pageRegister = new System.Windows.Forms.Panel();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.pageLogin.SuspendLayout();
            this.pageRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(133, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(251, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(604, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(251, 42);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.Location = new System.Drawing.Point(31, 20);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(722, 36);
            this.txtUsernameLogin.TabIndex = 1;
            this.txtUsernameLogin.Text = "Username";
            this.txtUsernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsernameLogin.WordWrap = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(31, 139);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(722, 36);
            this.txtPasswordLogin.TabIndex = 1;
            this.txtPasswordLogin.Text = "Enter your password";
            this.txtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageLogin
            // 
            this.pageLogin.Controls.Add(this.txtPasswordLogin);
            this.pageLogin.Controls.Add(this.txtUsernameLogin);
            this.pageLogin.Location = new System.Drawing.Point(99, 51);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.Size = new System.Drawing.Size(785, 220);
            this.pageLogin.TabIndex = 2;
            // 
            // pageRegister
            // 
            this.pageRegister.Controls.Add(this.txtPassReg);
            this.pageRegister.Controls.Add(this.txtEmailReg);
            this.pageRegister.Controls.Add(this.textBox2);
            this.pageRegister.Location = new System.Drawing.Point(99, 33);
            this.pageRegister.Name = "pageRegister";
            this.pageRegister.Size = new System.Drawing.Size(791, 278);
            this.pageRegister.TabIndex = 2;
            this.pageRegister.Visible = false;
            // 
            // txtPassReg
            // 
            this.txtPassReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassReg.Location = new System.Drawing.Point(34, 188);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.PasswordChar = '*';
            this.txtPassReg.Size = new System.Drawing.Size(722, 36);
            this.txtPassReg.TabIndex = 1;
            this.txtPassReg.Text = "Enter your password";
            this.txtPassReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "Register";
            this.textBox2.AccessibleName = "Register";
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(31, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(722, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Username";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.WordWrap = false;
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailReg.Location = new System.Drawing.Point(31, 110);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(722, 36);
            this.txtEmailReg.TabIndex = 1;
            this.txtEmailReg.Text = "Email";
            this.txtEmailReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailReg.WordWrap = false;
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.pageLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pageRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthenticateForm";
            this.Text = "Authenticate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pageLogin.ResumeLayout(false);
            this.pageLogin.PerformLayout();
            this.pageRegister.ResumeLayout(false);
            this.pageRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Panel pageLogin;
        private System.Windows.Forms.Panel pageRegister;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.TextBox txtEmailReg;
        private System.Windows.Forms.TextBox textBox2;
    }
}