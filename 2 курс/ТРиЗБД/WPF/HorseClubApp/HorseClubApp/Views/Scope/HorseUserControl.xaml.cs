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
    /// Interaction logic for HorseUserControl.xaml
    /// </summary>
    public partial class HorseUserControl : UserControl
    {
        public HorseUserControl()
        {
            InitializeComponent();
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().HORSEs.ToList();
        }
        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (HORSE)DataGridBreeds.SelectedItem;
            new EditHorseWindow(item).Show();
        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
           try
            {

                var item = DataGridBreeds.SelectedItems.Cast<HORSE>().ToList();
                if (MessageBox.Show($"Подтвердить удаление?", "!",
      MessageBoxButton.YesNo, MessageBoxImage.Question) !=
     MessageBoxResult.Yes) return;

                HorseClubDbEntities.GetContext().HORSEs.RemoveRange(item);
                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Ура! Удалилось!");
                DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().HORSEs.OrderBy(x =>
               x.HORSE_ID).ToList();
            } 
            catch { MessageBox.Show("Удаление лошади невозможно"); }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddHorseWindow addHorseWindow = new AddHorseWindow();
            addHorseWindow.Show();
        }
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().HORSEs.ToList();
        }
    }
}
