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
        public RegisterLoginMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager m = new DbManager();

            this.dgvDiscographies.DataSource = Discographies.All();
        }

        private void BtnCreateDisc_Click(object sender, EventArgs e)
        {
            Dictionary<string, Object> input = new Dictionary<string, Object>();

            input.Add("Name", this.txtDiscographyName.Text);

            Discographies.Insert(input);
        }
    }
}