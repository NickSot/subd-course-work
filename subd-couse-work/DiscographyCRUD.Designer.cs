﻿namespace subd_couse_work
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
            this.btnCreateDisc = new System.Windows.Forms.Button();
            this.txtDiscographyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiscographies = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscographies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateDisc);
            this.groupBox1.Controls.Add(this.txtDiscographyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Discography";
            // 
            // btnCreateDisc
            // 
            this.btnCreateDisc.Location = new System.Drawing.Point(195, 75);
            this.btnCreateDisc.Name = "btnCreateDisc";
            this.btnCreateDisc.Size = new System.Drawing.Size(126, 40);
            this.btnCreateDisc.TabIndex = 2;
            this.btnCreateDisc.Text = "Create Discography";
            this.btnCreateDisc.UseVisualStyleBackColor = true;
            this.btnCreateDisc.Click += new System.EventHandler(this.BtnCreateDisc_Click);
            // 
            // txtDiscographyName
            // 
            this.txtDiscographyName.Location = new System.Drawing.Point(64, 31);
            this.txtDiscographyName.Name = "txtDiscographyName";
            this.txtDiscographyName.Size = new System.Drawing.Size(257, 20);
            this.txtDiscographyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // dgvDiscographies
            // 
            this.dgvDiscographies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscographies.Location = new System.Drawing.Point(592, 24);
            this.dgvDiscographies.Name = "dgvDiscographies";
            this.dgvDiscographies.Size = new System.Drawing.Size(617, 571);
            this.dgvDiscographies.TabIndex = 1;
            // 
            // RegisterLoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 630);
            this.Controls.Add(this.dgvDiscographies);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterLoginMenu";
            this.Text = "Discography Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscographies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiscographyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDisc;
        private System.Windows.Forms.DataGridView dgvDiscographies;
    }
}
