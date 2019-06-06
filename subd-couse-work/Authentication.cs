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
    public partial class AuthenticateForm : Form
    {
        public AuthenticateForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            pageRegister.Hide();
        }


        private void proceedAfterAuthentication(int userId)
        {
            this.Hide();
            new RegisterLoginMenu(userId).ShowDialog();
            this.Close();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtEmailReg.Text.Length > 30) {
                MessageBox.Show("Email symbol length too long!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (this.txtUsernameLogin.Text.Length > 30)
            {
                MessageBox.Show("Username is too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (this.txtPasswordLogin.Text.Length > 255)
            {
                MessageBox.Show("Password is too long!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (this.txtUsernameReg.Text.Length > 30)
            {
                MessageBox.Show("Username is too long!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (this.txtPassReg.Text.Length > 30)
            {
                MessageBox.Show("Password is too long!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (pageLogin.Visible)
            {

                Dictionary<string, Object> user = new Dictionary<string, Object>();
                user.Add("Name", txtUsernameLogin.Text);
                DataTable foundUser = Users.Where(user);
                if(foundUser.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool isCorrectUser = Encryptor.ValidatePassword(txtPasswordLogin.Text, foundUser.Rows[0]["Password"].ToString());
                    if (isCorrectUser)
                    {
                        int userId = Convert.ToInt32(foundUser.Rows[0]["Id"].ToString());
                        proceedAfterAuthentication(userId);
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                pageLogin.Show();
                pageRegister.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (pageRegister.Visible)
            {
                if(txtUsernameReg.TextLength < 4 || txtPassReg.TextLength < 4 || txtEmailReg.TextLength < 4)
                {
                    MessageBox.Show("Too few characters written", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Dictionary<string, Object> newUserDict = new Dictionary<string, Object>();
                    newUserDict.Add("Name", txtUsernameReg.Text);

                    newUserDict.Add("Email", txtEmailReg.Text);
                    string encryptedPassword = Encryptor.computeHash(txtPassReg.Text);
                    if (Users.WhereOr(newUserDict).Rows.Count == 0) 
                    {
                        newUserDict.Add("Password", encryptedPassword);
                        Users.Insert(newUserDict);
                        DataRow user = Users.Where(newUserDict).Rows[0];
                        proceedAfterAuthentication(Convert.ToInt32(user["Id"].ToString()));
                    }
                    else
                    {
                        MessageBox.Show("There is already such an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
            else
            {
                pageLogin.Hide();
                pageRegister.Show();
            }
        }
    }
}
