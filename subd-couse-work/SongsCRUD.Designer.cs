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
            this.btnCreateSong = new System.Windows.Forms.Button();
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.gbCreateSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCreateSong
            // 
            this.gbCreateSong.Controls.Add(this.btnCreateSong);
            this.gbCreateSong.Controls.Add(this.rtbLyrics);
            this.gbCreateSong.Controls.Add(this.txtSongName);
            this.gbCreateSong.Controls.Add(this.lblLyrics);
            this.gbCreateSong.Controls.Add(this.lblSongName);
            this.gbCreateSong.Location = new System.Drawing.Point(23, 23);
            this.gbCreateSong.Name = "gbCreateSong";
            this.gbCreateSong.Size = new System.Drawing.Size(447, 283);
            this.gbCreateSong.TabIndex = 0;
            this.gbCreateSong.TabStop = false;
            this.gbCreateSong.Text = "Add a song to the discography";
            // 
            // btnCreateSong
            // 
            this.btnCreateSong.Location = new System.Drawing.Point(329, 219);
            this.btnCreateSong.Name = "btnCreateSong";
            this.btnCreateSong.Size = new System.Drawing.Size(96, 35);
            this.btnCreateSong.TabIndex = 4;
            this.btnCreateSong.Text = "Add Song";
            this.btnCreateSong.UseVisualStyleBackColor = true;
            this.btnCreateSong.Click += new System.EventHandler(this.BtnCreateSong_Click);
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Location = new System.Drawing.Point(77, 61);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(204, 193);
            this.rtbLyrics.TabIndex = 3;
            this.rtbLyrics.Text = "";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(77, 27);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(204, 20);
            this.txtSongName.TabIndex = 2;
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.Location = new System.Drawing.Point(18, 61);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(34, 13);
            this.lblLyrics.TabIndex = 1;
            this.lblLyrics.Text = "Lyrics";
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(17, 27);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(35, 13);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "Name";
            // 
            // dgvSong
            // 
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Location = new System.Drawing.Point(507, 23);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.Size = new System.Drawing.Size(419, 462);
            this.dgvSong.TabIndex = 1;
            // 
            // SongsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 552);
            this.Controls.Add(this.dgvSong);
            this.Controls.Add(this.gbCreateSong);
            this.Name = "SongsCRUD";
            this.Text = "SongsCRUD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SongsCRUD_FormClosed);
            this.Load += new System.EventHandler(this.SongsCRUD_Load);
            this.gbCreateSong.ResumeLayout(false);
            this.gbCreateSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateSong;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.Button btnCreateSong;
        private System.Windows.Forms.DataGridView dgvSong;
    }
}