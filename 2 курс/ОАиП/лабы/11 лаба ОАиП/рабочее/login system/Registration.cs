using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login_system
{
    public partial class RegistrationForm : Form
    {
       

        public RegistrationForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        string[] positions = {
            "Директор по развитию бизнеса 📈",
            "Менеджер по маркетингу 🎯",
            "Специалист по кадровому делопроизводству 💼",
            "Аналитик по данным 📊",
            "Инженер по разработке программного обеспечения 💻"
        };


        string[] departments = {
                "Отдел развития бизнеса 🚀",
                "Отдел маркетинга и рекламы 📢",
                "Отдел кадрового управления 💼",
                "Отдел аналитики и статистики 📊",
                "Отдел информационных технологий 💻"
            };
        private void InitializeComboBox()
        {
            DepartamentTextBox.Items.AddRange(positions);
            TitleTextBox1.Items.AddRange(departments);
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

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext()) 
            {
                if (string.IsNullOrEmpty(loginTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text) || string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(SurnamTextBox.Text) || string.IsNullOrEmpty(Phone_numberTextBox.Text) || string.IsNullOrEmpty(DepartamentTextBox.Text) || string.IsNullOrEmpty (TitleTextBox1.Text) || string.IsNullOrEmpty(SalaryTextBox.Text) || string.IsNullOrEmpty(DateTextBox.Text) || string.IsNullOrEmpty(DateOfBirthTextBox.Text))
                {
                    MessageBox.Show("Проверьте заполнение всех полей");
                    return;
                }


                string hashed_password = RegistrationForm.GetHashString(PasswordTextBox.Text);

                string sal_text = SalaryTextBox.Text;
                int salary = int.Parse(sal_text);
                bool check = false;

                foreach (User users in db.Users)
                {
                    if (EmailTextBox.Text == users.Email)
                    {
                        check = true;
                    }
                }
                 if (check == true)
                {
                    MessageBox.Show("Данная почта уже используется");
                        return;

                }

                User user = new User(loginTextBox.Text, hashed_password, NameTextBox.Text, SurnamTextBox.Text, EmailTextBox.Text, Phone_numberTextBox.Text, DepartamentTextBox.Text, TitleTextBox1.Text, salary, DateTextBox.Text, DateOfBirthTextBox.Text);
                

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Профиль был успешно создан!");

                LoggedInForm logged = new LoggedInForm(user);

                logged.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization autorize = new Authorization();

            autorize.Show();

            this.Hide();
        }

        
        private void Phone_numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Ignore the key press if it is not a digit
            }
        }

        private void TitleTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
