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
    /// Interaction logic for EventTypeUserControl.xaml
    /// </summary>
    public partial class EventTypeUserControl : UserControl
    {
        public EventTypeUserControl()
        {
            InitializeComponent();
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().event_type.ToList();
        }
        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (event_type)DataGridBreeds.SelectedItem;
            new EditEvenTypeWindow(item).Show();
           
        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var item = DataGridBreeds.SelectedItems.Cast<event_type>().ToList();
                if (MessageBox.Show($"Подтвердить удаление?", "!",
      MessageBoxButton.YesNo, MessageBoxImage.Question) !=
     MessageBoxResult.Yes) return;

                HorseClubDbEntities.GetContext().event_type.RemoveRange(item);
                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Ура! Удалилось!");
                DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().event_type.OrderBy(x =>
               x.EVENTTYPE_ID).ToList();
            }
            catch
            {
                MessageBox.Show("Удаление типа мероприятия невозможно");
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEventTypeWindow addEventTypeWindow = new AddEventTypeWindow();
            addEventTypeWindow.Show();
        }
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().event_type.ToList();
        }
    }
}
