﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace subd_couse_work
{
    public partial class SongsCRUD : Form
    {
        private int parent_id;
        private Form caller;

        private void JoinAndShow() {
            var joinedTable = from s in Songs.All().AsEnumerable()
                          join sd in SongsInDiscographies.All().AsEnumerable() on (int)s["Id"] equals (int)sd["SongId"]
                          join d in Discographies.All().AsEnumerable() on (int)sd["DiscographyId"] equals (int)d["Id"]
                          where (int)d["Id"] == this.parent_id
                          select new
                          {
                              Id = (int)s["Id"],
                              SongName = (string)s["Name"],
                              Lyrics = (string)s["Lyrics"]
                          };

            DataTable dt = new DataTable();

            int counter = 0;

            dt.Columns.Add("Song Name");
            dt.Columns.Add("Lyrics");
            dt.Columns.Add("Id");

            foreach (var obj in joinedTable) {
                dt.Rows.Add(dt.NewRow());

                dt.Rows[counter]["Id"] = obj.Id;
                dt.Rows[counter]["Song Name"] = obj.SongName;
                dt.Rows[counter]["Lyrics"] = obj.Lyrics;

                counter++;
            }

            this.dgvSong.DataSource = dt;

            if (this.dgvSong.Columns["Delete"] == null)
            {
  
            }
            this.dgvSong.Columns.Add("Delete", "Delete");
            int count = this.dgvSong.Rows.Count;
            count--;
            int i = 0;
            foreach (DataGridViewRow row in this.dgvSong.Rows)
            {
                if (i == count)
                {
                    break;
                }
                else
                {
                    row.Cells["Delete"].Value = "Delete";
                    i++;

                }
            }
        }

        public SongsCRUD(int parent_id, Form caller)
        {
            InitializeComponent();

            this.parent_id = parent_id;

            this.caller = caller;
        }

        private void SongsCRUD_Load(object sender, EventArgs e)
        {
            DbManager m = new DbManager();

            JoinAndShow();

            this.btnUpdateSong.Visible = false;
            this.btnCancelUpdate.Visible = false;
        }

        private void BtnCreateSong_Click(object sender, EventArgs e)
        {
            if (this.txtSongName.Text.Length < 1)
            {
                MessageBox.Show("Cannot create a song without a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtSongName.Text.Length > 500) {
                MessageBox.Show("The song name is too long!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict.Add("Name", this.txtSongName.Text);

            dict.Add("Lyrics", this.rtbLyrics.Text);

            DateTime now = DateTime.Now;

            string sqlFormattedDate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            dict.Add("ReleaseDate", sqlFormattedDate);

            Songs.Insert(dict);

            dict = new Dictionary<string, object>();

            dict.Add("SongId", Int32.Parse(Songs.All().AsEnumerable().Last<DataRow>()["Id"].ToString()));

            dict.Add("DiscographyId", parent_id);

            SongsInDiscographies.Insert(dict);

            JoinAndShow();

            this.BtnCancelUpdate_Click(this, null);
        }

        private void SongsCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.caller.Show();
        }

        private void DgvSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgvSong.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < this.dgvSong.Columns.Count && this.dgvSong.Columns[e.ColumnIndex].Name == "Delete") {
                var dict = new Dictionary<string, object>();
                dict.Add("Id", this.dgvSong.Rows[e.RowIndex].Cells["Id"].Value);
                Songs.Delete(dict);
                JoinAndShow();
                this.BtnCancelUpdate_Click(this, null);
            }
        }

        private int update_id = 0;

        private void DgvSong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgvSong.Rows.Count - 1 && e.ColumnIndex >= 0 && e.ColumnIndex < this.dgvSong.Columns.Count - 1 && this.dgvSong.Columns[e.ColumnIndex].Name != "Delete") {
                this.update_id = Convert.ToInt32(this.dgvSong.Rows[e.RowIndex].Cells["Id"].Value);
                this.txtSongName.Text = this.dgvSong.Rows[e.RowIndex].Cells["Song Name"].Value.ToString();
                this.rtbLyrics.Text = this.dgvSong.Rows[e.RowIndex].Cells["Lyrics"].Value.ToString();

                this.btnUpdateSong.Visible = true;
                this.btnCancelUpdate.Visible = true;
            }
        }

        private void BtnUpdateSong_Click(object sender, EventArgs e)
        {
            if (this.txtSongName.Text.Length < 1)
            {
                MessageBox.Show("Cannot create a song without a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dict = new Dictionary<string, object>();

            dict.Add("Name", this.txtSongName.Text);
            dict.Add("Lyrics", this.rtbLyrics.Text);

            Songs.Update(update_id, dict);

            this.BtnCancelUpdate_Click(this, null);

            JoinAndShow();
        }

        private void BtnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.txtSongName.Text = "";
            this.rtbLyrics.Text = "";

            this.btnUpdateSong.Visible = false;
            this.btnCancelUpdate.Visible = false;
        }
    }
}
