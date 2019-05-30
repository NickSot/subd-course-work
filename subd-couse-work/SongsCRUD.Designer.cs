namespace subd_couse_work
{
    partial class SongsCRUD
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
            this.gbCreateSong = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbCreateSong
            // 
            this.gbCreateSong.Location = new System.Drawing.Point(23, 23);
            this.gbCreateSong.Name = "gbCreateSong";
            this.gbCreateSong.Size = new System.Drawing.Size(317, 134);
            this.gbCreateSong.TabIndex = 0;
            this.gbCreateSong.TabStop = false;
            this.gbCreateSong.Text = "Add a song to the discography";
            // 
            // SongsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 552);
            this.Controls.Add(this.gbCreateSong);
            this.Name = "SongsCRUD";
            this.Text = "SongsCRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateSong;
    }
}