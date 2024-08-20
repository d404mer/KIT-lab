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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DartMediaApp.TablesWindows;

namespace DartMediaApp.EditWindows
{
    /// <summary>
    /// Interaction logic for EditTechWindow.xaml
    /// </summary>
    public partial class EditTechWindow : Window
    {
        Tech _currTech = new Tech();
        List<string> items = new List<string> { "Активно", "Списано" };
        public EditTechWindow(Tech selectedTech)
        {
            InitializeComponent();
            Status.ItemsSource = items;
            if (_currTech == null) return;
            _currTech = selectedTech;
            DataContext = _currTech;
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





                if (Status.SelectedItem != null)
                {
                    string selectedValue = Status.SelectedItem.ToString();

                    // Изменяем переменную status в зависимости от выбранного значения
                    if (selectedValue == "Активно")
                    {
                        _currTech.tech_status = 1;
                    }
                    else
                    {
                        _currTech.tech_status = 0;
                    }
                    
                    DartMediaDbEntities1.GetContext().SaveChanges();



                    MessageBox.Show("Запись изменена");
                    TechWindow techWindow = new TechWindow();
                    techWindow.Show();
                    this.Close();
                }
                }
                else MessageBox.Show("Вы не заполнили данные");
        }

        private void Назад_Click(object sender, RoutedEventArgs e)
        {
            TechWindow techWindow = new TechWindow();
            techWindow.Show();
            this.Close();
        }
    }

}
