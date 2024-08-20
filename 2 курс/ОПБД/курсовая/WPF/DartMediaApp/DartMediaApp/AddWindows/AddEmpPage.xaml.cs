using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DartMediaApp.AddWindows
{
    /// <summary>
    /// Interaction logic for AddEmpPage.xaml
    /// </summary>
    public partial class AddEmpPage : Window
    {
        private Emp _CurrentEmp = new Emp();

        public AddEmpPage()
        {
            InitializeComponent();
            DataContext = _CurrentEmp;

           

            
        }
            
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            var flag = true;
            foreach (Control c in sp1.Children)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (((TextBox)c).Text == String.Empty && ((TextBox)c).Name != "Lastname")
                    {
                        flag = false;
                    }
                }
                if (c.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)c).Text == String.Empty)
                    {
                        flag = false;
                    }
                }
            }





            if (flag)
            {
                DateTime selectedDate = DateOfBirth.SelectedDate.GetValueOrDefault();
                _CurrentEmp.emp_date_of_birth = selectedDate;
                _CurrentEmp.emp_status = 1;
                // Далее передайте selectedDate в ваш SQL запрос для вставки в базу данных

                DartMediaDbEntities1.GetContext().Emps.Add(_CurrentEmp);
                DartMediaDbEntities1.GetContext().SaveChanges();

               

                MessageBox.Show("Запись добавлена");
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();
            }
            else MessageBox.Show("Вы не заполнили данные");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c) && c != '+')
                {
                    e.Handled = true; // Отменить ввод символа, если он не является цифрой или "+"
                    return;
                }
            }
        }
    }
}
