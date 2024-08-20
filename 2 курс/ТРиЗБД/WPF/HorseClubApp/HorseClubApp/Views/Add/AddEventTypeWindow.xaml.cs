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
    /// Interaction logic for AddEventTypeWindow.xaml
    /// </summary>
    public partial class AddEventTypeWindow : Window
    {
        private event_type _curreventtype = new event_type();
        public AddEventTypeWindow()
        {
            InitializeComponent();
            DataContext = _curreventtype;
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
                HorseClubDbEntities.GetContext().event_type.Add(_curreventtype);
                HorseClubDbEntities.GetContext().SaveChanges();

                MessageBox.Show("Запись добавлена");

                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте заполнение всех полей");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
