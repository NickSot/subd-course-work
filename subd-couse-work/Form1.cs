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

        MySqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {

            //Тука си пишем нашите credential-и
            //Ще ги сложим в отделен файл, който ще е в .gitignore

            string mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=099824058;database=library;";

            con = new MySqlConnection(mySqlConnectionString);

            MySqlDataAdapter da = new MySqlDataAdapter("Select * From authors", con);

            con.Open();

            DataTable dt = new DataTable();

            da.Fill(dt);

            con.Close();

            foreach (DataRow row in dt.Rows) {
                this.lblSuka.Text += row["Name"].ToString() + "\n";
            }
        }
    }
}
