using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace login_system
{
    public partial class PasswordRestore : Form
    {
        public PasswordRestore()
        {
            InitializeComponent();
        }

        string new_password = GeneratePassword(); 
        static private string GeneratePassword()
        {
            string new_pass = "";
            Random random = new Random();
            string chars = "1234567890qwertyuiop[]asdfghjkl;'zxcvbnm,./";
            for (int i = 0; i < 8; i++)
            {
                int next_int = random.Next(0, chars.Length - 1);
                new_pass += chars[next_int];
            }

            return new_pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите почту");
                return;
            }


            MailAddress from = new MailAddress("oaip.laba.11@mail.ru", "11 laba OAiP");
            MailAddress to = new MailAddress(loginTextBox.Text);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Восстановление пароля";
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (loginTextBox.Text == user.Email)
                    {
                        message.Body = "<h1> Пароль: " + new_password + "</h1>";
                        user.Password = GetHashString(new_password);
                    }
                }

                db.SaveChanges();

                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("oaip.laba.11@mail.ru", "vWhbx7AdYddUmaeam14R");
                smtp.EnableSsl = true;

                smtp.Send(message);

                MessageBox.Show("email has been sent. please check your email");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Authorization autorize = new Authorization();

            autorize.Show();

            this.Hide();
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
    }
}
