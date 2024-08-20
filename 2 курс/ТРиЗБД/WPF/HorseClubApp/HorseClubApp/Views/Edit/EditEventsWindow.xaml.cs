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
    /// Interaction logic for EditEventsWindow.xaml
    /// </summary>
    public partial class EditEventsWindow : Window
    {
        private EVENT _currEvent = new EVENT();
        List<event_type> eventTypesList;
        public EditEventsWindow(EVENT selectedEvent)
        {
            InitializeComponent();

            using (var context = new HorseClubDbEntities())
            {
                eventTypesList = context.event_type.ToList();
            }
            if (selectedEvent == null) return;
            _currEvent = selectedEvent;
            DataContext = _currEvent;

            var comboBoxItems = eventTypesList.ToDictionary(type => type.EVENTTYPE_ID, type => type.EVENTTYPE_name).ToList();
            comboBox.DisplayMemberPath = "EVENTTYPE_name";
            comboBox.SelectedValuePath = "EVENTTYPE_ID";
            comboBox.ItemsSource = eventTypesList;

            DataContext = _currEvent;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            var flag = false;

           

                DateTime start = StTime.SelectedDate.GetValueOrDefault();
                _currEvent.EVENTS_STtime = start;

                DateTime end = ENDTime.SelectedDate.GetValueOrDefault();
                _currEvent.EVENTS_ENDtime = end;


                event_type selectedEventType = (event_type)comboBox.SelectedItem;
                
                if (selectedEventType != null && start != null && end != null)
                {
                    flag = true;
                    // Сохраняем EVENTTYPE_ID в переменную eventId
                    int eventId = selectedEventType.EVENTTYPE_ID;
                    _currEvent.FK_EVENTTYPE_ID = eventId;
                }



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
                    HorseClubDbEntities.GetContext().SaveChanges();
                    MessageBox.Show("Запись изменена");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте заполнение всех полей");
                }
              
        }
    }
}
