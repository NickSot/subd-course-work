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
        private int userId;
        public RegisterLoginMenu(int userId)
        {
            this.userId = userId;
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
            DataRow user = Users.Find(this.userId);
            MessageBox.Show(user["Name"].ToString());
            lblAuthenticated.Text = user["Name"].ToString();
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
            DialogResult result = MessageBox.Show("Do you really want to delete this", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

                Dictionary<string, Object> input = new Dictionary<string, Object>();

                int id = 0;
                if(Int32.TryParse(this.discographyId.Text, out id)==false)
                {
                    MessageBox.Show("Please enter a valid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    input.Add("Id", id);

                    Discographies.Delete(input);

                    this.dgvDiscographies.DataSource = Discographies.All();

                    this.dgvDiscographies.Columns["UserId"].Visible = false;
                }


                
            }

        }

        private void lblAuthenticated_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new changeUserCredentials(userId).ShowDialog();
            string name = Users.Find(userId)["Name"].ToString();
            lblAuthenticated.Text = name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, Object> input = new Dictionary<string, Object>();

            input.Add("Name", this.newNameTxt.Text);

            int id = 0;
            if (Int32.TryParse(this.textBox2.Text, out id) == false)
            {
                MessageBox.Show("Please enter a valid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Discographies.Update(id, input);

                this.dgvDiscographies.DataSource = Discographies.All();

                this.dgvDiscographies.Columns["UserId"].Visible = false;
            }
        }
    }
}