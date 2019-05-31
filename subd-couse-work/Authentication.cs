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


        private void proceedAfterAuthentication()
        {
            this.Hide();
            new RegisterLoginMenu().ShowDialog();
            this.Close();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                    bool isCorrectUser = Encryptor.ValidatePassword(txtPasswordLogin.Text, Base64Encode(txtUsernameLogin.Text), 1000, 128, foundUser.Rows[0]["Password"].ToString());
                    if (isCorrectUser)
                    {
                        proceedAfterAuthentication();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show(Users.Where(user).Rows.Count.ToString());
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

                    //DataTable userWithUsername = Users.Where(newUserDict);
                    newUserDict.Add("Email", txtEmailReg.Text);
                    string encryptedPassword = Encryptor.computeHash(txtPassReg.Text, Base64Encode(txtUsernameReg.Text), 1000, 128);
                    newUserDict.Add("Password", encryptedPassword);
                    if (Users.Where(newUserDict).Rows.Count == 0) // This is bad because it doesn't handle non unique single values
                    {
                        Users.Insert(newUserDict);
                        proceedAfterAuthentication();
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
