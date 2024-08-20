using HorseClubApp;
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
    /// Interaction logic for AddEventsWindow.xaml
    /// </summary>
    public partial class AddEventsWindow : Window
    {
        private EVENT _currEvent = new EVENT();
        List<event_type> eventTypesList;
        public AddEventsWindow()
        {
            InitializeComponent();


            using (var context = new HorseClubDbEntities())
            {
                eventTypesList = context.event_type.ToList();
            }

            var comboBoxItems = eventTypesList.ToDictionary(type => type.EVENTTYPE_ID, type => type.EVENTTYPE_name).ToList();
            comboBox.DisplayMemberPath = "EVENTTYPE_name";
            comboBox.SelectedValuePath = "EVENTTYPE_ID";
            comboBox.ItemsSource = eventTypesList;

            DataContext = _currEvent;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
                if (comboBox.SelectedItem != null)
                {
                    // Получаем выбранный объект EventType
                    event_type selectedEventType = (event_type)comboBox.SelectedItem;

                    // Сохраняем EVENTTYPE_ID в переменную eventId
                    int eventId = selectedEventType.EVENTTYPE_ID;

                    _currEvent.FK_EVENTTYPE_ID = eventId;

                    

                    DateTime start = StTime.SelectedDate.GetValueOrDefault();
                    _currEvent.EVENTS_STtime = start;

                    DateTime end = ENDTime.SelectedDate.GetValueOrDefault();
                    _currEvent.EVENTS_ENDtime = end;



                    HorseClubDbEntities.GetContext().EVENTS.Add(_currEvent);
                    HorseClubDbEntities.GetContext().SaveChanges();
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
