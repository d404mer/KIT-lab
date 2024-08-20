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

namespace HorseClubApp.Views.Edit
{
    /// <summary>
    /// Interaction logic for EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        private USER _currUser = new USER();
        List<string> items = new List<string> { "Активен", "Неактивен" };
        public EditUserWindow(USER selectedUser)
        {
            InitializeComponent();
            if (selectedUser == null) return;
            _currUser = selectedUser;
            DataContext = _currUser;
            Status.ItemsSource = items;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = true;
            if (Status.SelectedItem == null)
            {
                flag = false;
            }
            foreach (var child in sp1.Children)
            {
                if (child is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text) )
                    {
                        flag = false;
                        break; // Exit the loop early if one text box is empty
                    }
                }
            }

            if (flag)
            {
                    string selectedValue = Status.SelectedItem.ToString();
                    // Изменяем переменную status в зависимости от выбранного значения
                    if (selectedValue == "Активен")
                    {
                        _currUser.USER_status = true;
                    }
                    else
                    {
                        _currUser.USER_status = false;
                    }

                
                
                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись изменена");
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте заполнение всех полей");
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
