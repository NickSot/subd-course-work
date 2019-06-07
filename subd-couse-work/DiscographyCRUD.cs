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

        private bool CheckFields() {
            if (this.txtDiscographyName.Text.Length > 30)
            {
                MessageBox.Show("Discography name is too long!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void ShowDiscographies() {
            var dict = new Dictionary<string, object>();

            dict.Add("UserId", this.userId);

            this.dgvDiscographies.DataSource = Discographies.Where(dict);

            this.dgvDiscographies.Columns["UserId"].Visible = false;

            if (this.dgvDiscographies.Columns["Songs"] == null)
            {
                this.dgvDiscographies.Columns.Add("Songs", "Songs");
            }
            int count = this.dgvDiscographies.Rows.Count;
            count--;
            int i = 0;
            foreach (DataGridViewRow row in this.dgvDiscographies.Rows)
            {
                if (i == count)
                {
                    break;
                }
                else
                {
                    row.Cells["Songs"].Value = "Click here!";
                    i++;
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager m = new DbManager();

            ShowDiscographies();
            
            DataRow user = Users.Find(this.userId);
            //MessageBox.Show(user["Name"].ToString());
            lblAuthenticated.Text = user["Name"].ToString();
        }

        private void BtnCreateDisc_Click(object sender, EventArgs e)
        {
            if (!CheckFields()) {
                return;
            }

            Dictionary<string, Object> input = new Dictionary<string, Object>();

            if (this.txtDiscographyName.Text.Length < 3)
            {
                MessageBox.Show("The name must contain at least 3 symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                input.Add("Name", this.txtDiscographyName.Text);
                input.Add("UserId", this.userId);

                Discographies.Insert(input);
            }
            ShowDiscographies();
        }

        private void DgvDiscographies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < this.dgvDiscographies.Columns.Count && e.RowIndex >= 0 && e.RowIndex < this.dgvDiscographies.Rows.Count && this.dgvDiscographies.Columns[e.ColumnIndex].Name == "Songs") {
                this.Hide();
                new SongsCRUD(Convert.ToInt32(this.dgvDiscographies.Rows[e.RowIndex].Cells["Id"].Value), this).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                return;
            }

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
                    if(Discographies.Where(input).Rows.Count == 0){
                        MessageBox.Show("No discography with such id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                       

                        Discographies.Delete(input);

                    }
                }
            }
            ShowDiscographies();
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
            if (!CheckFields())
            {
                return;
            }

            Dictionary<string, Object> input = new Dictionary<string, Object>();
            Dictionary<string, Object> discographyId = new Dictionary<string, Object>();

            if (this.newNameTxt.Text.Length < 3)
            {
                MessageBox.Show("The name must contain at least 3 symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                input.Add("Name", this.newNameTxt.Text);

                int id = 0;
                if (Int32.TryParse(this.textBox2.Text, out id) == false)
                {
                    MessageBox.Show("Please enter a valid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    discographyId.Add("Id", id);
                    if (Discographies.Where(discographyId).Rows.Count == 0)
                    {
                        MessageBox.Show("No discography with such id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Discographies.Update(id, input);
                    }
                }
            }
            ShowDiscographies();
        }
    }
}