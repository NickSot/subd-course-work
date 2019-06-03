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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageRegister = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.txtUsernameReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.txtUsernameLogin.Location = new System.Drawing.Point(201, 114);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(565, 36);
            this.txtUsernameLogin.TabIndex = 1;
            this.txtUsernameLogin.WordWrap = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(201, 233);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(565, 36);
            this.txtPasswordLogin.TabIndex = 1;
            // 
            // pageLogin
            // 
            this.pageLogin.Controls.Add(this.label6);
            this.pageLogin.Controls.Add(this.label5);
            this.pageLogin.Controls.Add(this.label4);
            this.pageLogin.Controls.Add(this.txtPasswordLogin);
            this.pageLogin.Controls.Add(this.txtUsernameLogin);
            this.pageLogin.Location = new System.Drawing.Point(102, 21);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.Size = new System.Drawing.Size(791, 338);
            this.pageLogin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // pageRegister
            // 
            this.pageRegister.Controls.Add(this.label3);
            this.pageRegister.Controls.Add(this.label2);
            this.pageRegister.Controls.Add(this.lblRegister);
            this.pageRegister.Controls.Add(this.label1);
            this.pageRegister.Controls.Add(this.txtPassReg);
            this.pageRegister.Controls.Add(this.txtEmailReg);
            this.pageRegister.Controls.Add(this.txtUsernameReg);
            this.pageRegister.Location = new System.Drawing.Point(102, 21);
            this.pageRegister.Name = "pageRegister";
            this.pageRegister.Size = new System.Drawing.Size(791, 338);
            this.pageRegister.TabIndex = 2;
            this.pageRegister.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(302, 20);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(176, 48);
            this.lblRegister.TabIndex = 2;
            this.lblRegister.Text = "Register";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // txtPassReg
            // 
            this.txtPassReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassReg.Location = new System.Drawing.Point(153, 241);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.PasswordChar = '*';
            this.txtPassReg.Size = new System.Drawing.Size(613, 36);
            this.txtPassReg.TabIndex = 1;
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailReg.Location = new System.Drawing.Point(153, 173);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(613, 36);
            this.txtEmailReg.TabIndex = 1;
            this.txtEmailReg.WordWrap = false;
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.AccessibleDescription = "Register";
            this.txtUsernameReg.AccessibleName = "Register";
            this.txtUsernameReg.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtUsernameReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameReg.Location = new System.Drawing.Point(153, 105);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(613, 36);
            this.txtUsernameReg.TabIndex = 1;
            this.txtUsernameReg.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 48);
            this.label6.TabIndex = 3;
            this.label6.Text = "Login";
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pageLogin);
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
        private System.Windows.Forms.TextBox txtUsernameReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}