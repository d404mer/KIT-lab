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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HorseClubApp.Views.Edit;
using HorseClubApp.Views.Add;

namespace HorseClubApp.Views.Scope
{
    /// <summary>
    /// Interaction logic for BreedUserControl.xaml
    /// </summary>
    public partial class BreedUserControl : UserControl
    {
        public BreedUserControl()
        {
            InitializeComponent();
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().BREEDs.ToList();
        }
        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            
            var item = (BREED)DataGridBreeds.SelectedItem;
            new EditBreedWindow(item).Show();
            
        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Breed = DataGridBreeds.SelectedItems.Cast<BREED>().ToList();
                if (MessageBox.Show($"Подтвердить удаление?", "!",
      MessageBoxButton.YesNo, MessageBoxImage.Question) !=
     MessageBoxResult.Yes) return;

                HorseClubDbEntities.GetContext().BREEDs.RemoveRange(Breed);
                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Ура! Удалилось!");
                DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().BREEDs.OrderBy(x =>
               x.BREED_ID).ToList();

            }
            catch
            {
                MessageBox.Show("Удаление породы невозможно");
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddBreedWindow addBreedWindow = new AddBreedWindow();
            addBreedWindow.Show();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().BREEDs.ToList();
        }
    }
}
