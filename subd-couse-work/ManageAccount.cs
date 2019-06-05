using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subd_couse_work
{
    public partial class changeUserCredentials : Form
    {
        private DataRow user;
        private int userId;
        public changeUserCredentials(int userId)
        {
            this.user = Users.Find(userId);
            this.userId = userId;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = user["Name"].ToString();
            txtEmail.Text = user["Email"].ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> updateUserWith = new Dictionary<string, object>();

            updateUserWith.Add("Name", txtUsername.Text);
            updateUserWith.Add("Email", txtEmail.Text);
            if(Users.WhereOr(updateUserWith).Rows.Count <= 1)
            {
                if(txtPass.TextLength != 0)
                {
                    updateUserWith.Add("Password", Encryptor.computeHash(txtPass.Text));
                }
                Users.Update(userId, updateUserWith);
                this.Close();
            }
            else
            {
                MessageBox.Show("There is already such an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
