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

namespace HorseClubApp.Views.Add
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        USER _currUser = new USER();
        public AddUserWindow()
        {
            InitializeComponent();
            DataContext = _currUser;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = true;
            foreach (var child in sp1.Children)
            {
                if (child is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        flag = false;
                        break; // Exit the loop early if one text box is empty
                    }
                }
            }

            if (flag)
            {
                _currUser.USER_status = true;
                HorseClubDbEntities.GetContext().USERs.Add(_currUser);
                HorseClubDbEntities.GetContext().SaveChanges();

                MessageBox.Show("Запись добавлена");

                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте заполнение всех полей");
            }
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

        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true; // Отменить ввод символа, если он не является цифрой
                    return;
                }
            }
        }
    }
}
