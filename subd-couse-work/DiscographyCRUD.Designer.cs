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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.discographyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscographies)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateDisc);
            this.groupBox1.Controls.Add(this.txtDiscographyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Discography";
            // 
            // btnCreateDisc
            // 
            this.btnCreateDisc.Location = new System.Drawing.Point(260, 92);
            this.btnCreateDisc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtDiscographyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvDiscographies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscographies.Location = new System.Drawing.Point(789, 30);
            this.dgvDiscographies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDiscographies.Name = "dgvDiscographies";
            this.dgvDiscographies.Size = new System.Drawing.Size(823, 703);
            this.dgvDiscographies.TabIndex = 1;
            this.dgvDiscographies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDiscographies_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.discographyId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(31, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(515, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Discography";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Discography";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // discographyId
            // 
            this.discographyId.Location = new System.Drawing.Point(85, 38);
            this.discographyId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discographyId.Name = "discographyId";
            this.discographyId.Size = new System.Drawing.Size(341, 22);
            this.discographyId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id: ";
            // 
            // RegisterLoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 775);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDiscographies);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterLoginMenu";
            this.Text = "Discography Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscographies)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiscographyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDisc;
        private System.Windows.Forms.DataGridView dgvDiscographies;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox discographyId;
        private System.Windows.Forms.Label label2;
    }
}

