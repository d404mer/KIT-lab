using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DartMediaApp.EditWindows
{
    /// <summary>
    /// Interaction logic for EmpEditWindow.xaml
    /// </summary>
    public partial class EmpEditWindow : Window
    {
        private Emp _currEmp = new Emp();
        public EmpEditWindow(Emp selectedEmp)
        {
            InitializeComponent();
            if (selectedEmp == null) return;
            _currEmp = selectedEmp;
            DataContext = _currEmp;

        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
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
                _currEmp.emp_date_of_birth = selectedDate;
                
               

                DartMediaDbEntities1.GetContext().SaveChanges();
                MessageBox.Show("Запись изменена");
                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }
            else MessageBox.Show("Вы не заполнили данные");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
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
