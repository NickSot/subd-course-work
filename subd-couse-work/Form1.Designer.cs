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
            this.lblSuka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSuka
            // 
            this.lblSuka.AutoSize = true;
            this.lblSuka.Location = new System.Drawing.Point(410, 149);
            this.lblSuka.Name = "lblSuka";
            this.lblSuka.Size = new System.Drawing.Size(35, 13);
            this.lblSuka.TabIndex = 0;
            this.lblSuka.Text = "label1";
            // 
            // RegisterLoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSuka);
            this.Name = "RegisterLoginMenu";
            this.Text = "Discography Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuka;
    }
}

