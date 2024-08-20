using DartMediaApp.TablesWindows;
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

namespace DartMediaApp.AddWindows
{
    /// <summary>
    /// Interaction logic for AddTechWindow.xaml
    /// </summary>
    public partial class AddTechWindow : Window
    {
        private Tech _currentTech = new Tech();
        List<string> items = new List<string> { "Активно", "Списано"};
        public AddTechWindow()
        {
            InitializeComponent();
            Status.ItemsSource = items;
            DataContext = _currentTech;
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

                if (Status.SelectedItem != null)
                {
                    string selectedValue = Status.SelectedItem.ToString();

                    // Изменяем переменную status в зависимости от выбранного значения
                    if (selectedValue == "Активно")
                    {
                        _currentTech.tech_status = 1;
                    }
                    else
                    {
                        _currentTech.tech_status = 0;
                    }
                    DartMediaDbEntities1.GetContext().Teches.Add(_currentTech);
                    DartMediaDbEntities1.GetContext().SaveChanges();



                    MessageBox.Show("Запись добавлена");
                    TechWindow techWindow = new TechWindow();
                    techWindow.Show();
                    this.Hide();
                }
            }
                else MessageBox.Show("Вы не заполнили данные");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            TechWindow techWindow = new TechWindow();
            techWindow.Show();
            this.Hide();
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
