using System;
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
        int parent_id;

        private void JoinAndShow() {
            var joinedTable = from s in Songs.All().AsEnumerable()
                          join sd in SongsInDiscographies.All().AsEnumerable() on (int)s["Id"] equals (int)sd["SongId"]
                          join d in Discographies.All().AsEnumerable() on (int)sd["DiscographyId"] equals (int)d["Id"]
                          where (int)d["Id"] == this.parent_id
                          select new
                          {
                              SongName = (string)s["Name"],
                              Lyrics = (string)s["Text"]
                          };

            DataTable dt = new DataTable();

            int counter = 0;

            dt.Columns.Add("Song Name");
            dt.Columns.Add("Lyrics");

            foreach (var obj in joinedTable) {
                dt.Rows.Add(dt.NewRow());

                dt.Rows[counter]["Song Name"] = obj.SongName;
                dt.Rows[counter]["Lyrics"] = obj.Lyrics;

                counter++;
            }

            this.dgvSong.DataSource = dt;
        }

        public SongsCRUD(int parent_id)
        {
            InitializeComponent();

            this.parent_id = parent_id;
        }

        private void SongsCRUD_Load(object sender, EventArgs e)
        {
            DbManager m = new DbManager();

            JoinAndShow();
        }

        private void BtnCreateSong_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict.Add("Name", this.txtSongName.Text);

            dict.Add("Text", this.rtbLyrics.Text);

            DateTime now = DateTime.Now;

            string sqlFormattedDate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            dict.Add("ReleaseDate", sqlFormattedDate);

            Songs.Insert(dict);

            dict = new Dictionary<string, object>();

            dict.Add("SongId", Int32.Parse(Songs.All().AsEnumerable().Last<DataRow>()["Id"].ToString()));

            dict.Add("DiscographyId", parent_id);

            SongsInDiscographies.Insert(dict);

            JoinAndShow();
        }
    }
}
