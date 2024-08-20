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
    /// Interaction logic for AddBreedWindow.xaml
    /// </summary>
    public partial class AddBreedWindow : Window
    {
        private BREED _currBreed = new BREED();
        public AddBreedWindow()
        {
            InitializeComponent();
            DataContext = _currBreed;
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
                HorseClubDbEntities.GetContext().BREEDs.Add(_currBreed);
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
