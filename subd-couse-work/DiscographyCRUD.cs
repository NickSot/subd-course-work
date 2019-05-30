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

namespace subd_couse_work
{
    public partial class RegisterLoginMenu : Form
    {
        public RegisterLoginMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager m = new DbManager();

            this.dgvDiscographies.DataSource = Discographies.All();

            this.dgvDiscographies.Columns["UserId"].Visible = false;

            if (this.dgvDiscographies.Columns["Songs"] == null)
            {
                this.dgvDiscographies.Columns.Add("Songs", "Songs");

                foreach (DataGridViewRow row in this.dgvDiscographies.Rows)
                {
                    row.Cells["Songs"].Value = "Click here!";
                }
            }
        }

        private void BtnCreateDisc_Click(object sender, EventArgs e)
        {
            Dictionary<string, Object> input = new Dictionary<string, Object>();

            input.Add("Name", this.txtDiscographyName.Text);

            Discographies.Insert(input);

            this.dgvDiscographies.DataSource = Discographies.All();

            this.dgvDiscographies.Columns["UserId"].Visible = false;

            if (this.dgvDiscographies.Columns["Songs"] == null)
            {
                this.dgvDiscographies.Columns.Add("Songs", "Songs");

                foreach (DataGridViewRow row in this.dgvDiscographies.Rows) {
                    row.Cells["Songs"].Value= "Click here!";
                }
            }
        }

        private void DgvDiscographies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDiscographies.Columns[e.ColumnIndex].Name == "Songs" && e.RowIndex >= 0 && e.RowIndex < this.dgvDiscographies.Rows.Count - 1) {
                this.Hide();
                new SongsCRUD(Convert.ToInt32(this.dgvDiscographies.Rows[e.RowIndex].Cells["Id"].Value), this).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, Object> input = new Dictionary<string, Object>();

            int id = Int32.Parse(this.discographyId.Text);

            input.Add("Id", id);

            Discographies.Delete(input);

            this.dgvDiscographies.DataSource = Discographies.All();

            this.dgvDiscographies.Columns["UserId"].Visible = false;

        }
    }
}