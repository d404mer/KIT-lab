using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_system
{
    public partial class LoggedInForm : Form
    {
        private User user;


        public LoggedInForm(User user) // конструктор, получающий объект пользователя
        {
            InitializeComponent();
            this.user = user; // сохранение объекта пользователя в приватном поле класса
            FillUserData();
        }

        private void FillUserData()
        {
            Name.Text = user.Name;
            Surname.Text = user.Surname;
            DateOfBirth.Text = Convert.ToString(user.DateOfBirth);
            Phone_number.Text = user.Phone_number;
            Departament.Text = user.Departament;
            Title.Text = user.Title;
            Salary.Text = Convert.ToString(user.Salary);
            Date.Text = Convert.ToString(user.Date);
            Email.Text = user.Email;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Authorization autorize = new Authorization();

            autorize.Show();

            this.Hide();
        }
    }
}
