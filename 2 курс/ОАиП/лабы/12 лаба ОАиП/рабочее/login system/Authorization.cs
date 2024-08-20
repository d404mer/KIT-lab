using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_system
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        public static string GetHashString(string input)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(input);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }


            return hash;
        }




        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string hashed_password = RegistrationForm.GetHashString(PasswordTextBox.Text);
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (loginTextBox.Text == user.Login && hashed_password == user.Password || loginTextBox.Text == user.Email && hashed_password == user.Password)
                    {
                        MessageBox.Show("Вход успешен!");
                        LoggedInForm logged = new LoggedInForm(user);
                        logged.Show();
                        this.Visible = false;
                        return;
                    }
                }
                MessageBox.Show("Логин или пароль указан неверно! :(");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();

            registration.Show();

            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PasswordRestore restore = new PasswordRestore();

            restore.Show();

            this.Hide();
        }
    }
}
