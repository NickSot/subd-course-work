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

            Dictionary<string, string> filter = new Dictionary<string, string>();

            filter.Add("Name", "Sunnova");

            DbManager.Users.Update(1, filter);
            //this.lblSuka.Text = DbManager.Users.Find(1)["Name"].ToString();
        }
    }
}
