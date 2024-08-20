using HorseClubApp.Views.Add;
using HorseClubApp.Views.Edit;
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

namespace HorseClubApp.Views.Scope
{
    /// <summary>
    /// Interaction logic for ListUserControl.xaml
    /// </summary>
    public partial class ListUserControl : UserControl
    {
        public ListUserControl()
        {
            InitializeComponent();
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().LISTs.ToList();
        }
        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (LIST)DataGridBreeds.SelectedItem;
            new EditListWindow(item).Show();
        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var item = DataGridBreeds.SelectedItems.Cast<LIST>().ToList();
                if (MessageBox.Show($"Подтвердить удаление?", "!",
      MessageBoxButton.YesNo, MessageBoxImage.Question) !=
     MessageBoxResult.Yes) return;

                HorseClubDbEntities.GetContext().LISTs.RemoveRange(item);
                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Ура! Удалилось!");
                DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().LISTs.OrderBy(x =>
               x.LIST_ID).ToList();
            }
            catch
            {
                MessageBox.Show("Удаление связи невозможно");
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddListWindow addListWindow = new AddListWindow();
            addListWindow.Show();
            
        }
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().LISTs.ToList();
        }
    }
}
