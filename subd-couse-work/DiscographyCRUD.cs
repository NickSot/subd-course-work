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

            this.dgvDiscographies.Columns.Add("Songs", "Songs");
        }

        private void BtnCreateDisc_Click(object sender, EventArgs e)
        {
            Dictionary<string, Object> input = new Dictionary<string, Object>();

            input.Add("Name", this.txtDiscographyName.Text);

            Discographies.Insert(input);

            this.dgvDiscographies.DataSource = Discographies.All();

            this.dgvDiscographies.Columns["UserId"].Visible = false;

            this.dgvDiscographies.Columns.Add("Songs", "Songs");
        }

        private void DgvDiscographies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}