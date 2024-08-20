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
    /// Interaction logic for AddListWindow.xaml
    /// </summary>
    public partial class AddListWindow : Window
    {
        LIST _currList = new LIST();
        List<EVENT> eventsList;
        List<USER> usersList;
        public AddListWindow()
        {
            InitializeComponent();



            using (var context = new HorseClubDbEntities())
            {
                usersList = context.USERs.ToList();
                eventsList = context.EVENTS.ToList();
            }


            EventComboBox.DisplayMemberPath = "EVENTS_name";
            EventComboBox.SelectedValuePath = "EVENTS_ID";
            EventComboBox.ItemsSource = eventsList;

                         //var comboBox1Items = usersList.ToDictionary(type => type.USER_ID, type => type.USER_name).ToList();
            UserComboBox.DisplayMemberPath = "USER_name";
            UserComboBox.SelectedValuePath = "USER_ID";
            UserComboBox.ItemsSource = usersList;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = false;
            

            if (EventComboBox.SelectedIndex != null && UserComboBox.SelectedIndex != null && EventComboBox.SelectedItem != null && UserComboBox.SelectedItem != null)
            {
                flag = true;
                EVENT selectedEvent = (EVENT)EventComboBox.SelectedItem;

                USER selectedUser = (USER)UserComboBox.SelectedItem;

               _currList.FK_EVENT_ID = selectedEvent.EVENTS_ID;
                _currList.FK_USER_ID = selectedUser.USER_ID;
            }
           
            if (flag)
            {
                

                HorseClubDbEntities.GetContext().LISTs.Add(_currList);
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
