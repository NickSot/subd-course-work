namespace subd_couse_work
{
    partial class RegisterLoginMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDiscograpy = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnCreateDisc = new System.Windows.Forms.Button();
            this.txtDiscographyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiscographies = new System.Windows.Forms.DataGridView();
            this.lblAuthenticated = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscographies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateDiscograpy);
            this.groupBox1.Controls.Add(this.btnCancelUpdate);
            this.groupBox1.Controls.Add(this.btnCreateDisc);
            this.groupBox1.Controls.Add(this.txtDiscographyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Discography";
            // 
            // btnUpdateDiscograpy
            // 
            this.btnUpdateDiscograpy.Location = new System.Drawing.Point(258, 92);
            this.btnUpdateDiscograpy.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDiscograpy.Name = "btnUpdateDiscograpy";
            this.btnUpdateDiscograpy.Size = new System.Drawing.Size(168, 49);
            this.btnUpdateDiscograpy.TabIndex = 2;
            this.btnUpdateDiscograpy.Text = "Update Discography";
            this.btnUpdateDiscograpy.UseVisualStyleBackColor = true;
            this.btnUpdateDiscograpy.Click += new System.EventHandler(this.btnUpdateDiscograpy_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(26, 92);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(152, 49);
            this.btnCancelUpdate.TabIndex = 3;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnCreateDisc
            // 
            this.btnCreateDisc.Location = new System.Drawing.Point(258, 92);
            this.btnCreateDisc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateDisc.Name = "btnCreateDisc";
            this.btnCreateDisc.Size = new System.Drawing.Size(168, 49);
            this.btnCreateDisc.TabIndex = 2;
            this.btnCreateDisc.Text = "Create Discography";
            this.btnCreateDisc.UseVisualStyleBackColor = true;
            this.btnCreateDisc.Click += new System.EventHandler(this.BtnCreateDisc_Click);
            // 
            // txtDiscographyName
            // 
            this.txtDiscographyName.Location = new System.Drawing.Point(85, 38);
            this.txtDiscographyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscographyName.Name = "txtDiscographyName";
            this.txtDiscographyName.Size = new System.Drawing.Size(341, 22);
            this.txtDiscographyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // dgvDiscographies
            // 
            this.dgvDiscographies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiscographies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDiscographies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscographies.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDiscographies.Location = new System.Drawing.Point(699, 30);
            this.dgvDiscographies.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiscographies.Name = "dgvDiscographies";
            this.dgvDiscographies.Size = new System.Drawing.Size(823, 703);
            this.dgvDiscographies.TabIndex = 1;
            this.dgvDiscographies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDiscographies_CellClick);
            this.dgvDiscographies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscographies_CellDoubleClick);
            // 
            // lblAuthenticated
            // 
            this.lblAuthenticated.AutoSize = true;
            this.lblAuthenticated.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthenticated.LinkColor = System.Drawing.Color.Black;
            this.lblAuthenticated.Location = new System.Drawing.Point(177, 697);
            this.lblAuthenticated.Name = "lblAuthenticated";
            this.lblAuthenticated.Size = new System.Drawing.Size(108, 39);
            this.lblAuthenticated.TabIndex = 3;
            this.lblAuthenticated.TabStop = true;
            this.lblAuthenticated.Text = "Name";
            this.lblAuthenticated.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblAuthenticated.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthenticated_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(33, 718);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 15);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Currently logged in as:";
            // 
            // RegisterLoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAuthenticated);
            this.Controls.Add(this.dgvDiscographies);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegisterLoginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discography Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscographies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiscographyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDisc;
        private System.Windows.Forms.DataGridView dgvDiscographies;
        private System.Windows.Forms.LinkLabel lblAuthenticated;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdateDiscograpy;
        private System.Windows.Forms.Button btnCancelUpdate;
    }
}

