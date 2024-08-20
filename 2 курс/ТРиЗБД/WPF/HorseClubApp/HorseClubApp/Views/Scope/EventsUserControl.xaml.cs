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
    /// Interaction logic for EventsUserControl.xaml
    /// </summary>
    public partial class EventsUserControl : UserControl
    {
        public EventsUserControl()
        {
            InitializeComponent();
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().EVENTS.ToList();

        }
        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (EVENT)DataGridBreeds.SelectedItem;
            new EditEventsWindow(item).Show();
        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Event = DataGridBreeds.SelectedItems.Cast<EVENT>().ToList();
                if (MessageBox.Show($"Подтвердить удаление?", "!",
      MessageBoxButton.YesNo, MessageBoxImage.Question) !=
     MessageBoxResult.Yes) return;

                HorseClubDbEntities.GetContext().EVENTS.RemoveRange(Event);
                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Ура! Удалилось!");
                DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().EVENTS.OrderBy(x =>
               x.EVENTS_ID).ToList();

            }
            catch
            {
                 MessageBox.Show("Удаление мероприятия невозможно");

            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEventsWindow addEventsWindow = new AddEventsWindow();
            addEventsWindow.Show();
        }
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            DataGridBreeds.ItemsSource = HorseClubDbEntities.GetContext().EVENTS.ToList();
        }

    }
}
