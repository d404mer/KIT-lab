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
using HorseClubApp.Views.Scope;

namespace HorseClubApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EventsBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControlShow.Children.Clear();
            UserControlShow.Children.Add(new EventsUserControl());
        }

        private void EventTypesBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControlShow.Children.Clear();
            UserControlShow.Children.Add(new EventTypeUserControl());
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControlShow.Children.Clear();
            UserControlShow.Children.Add(new UserUserControl());
        }

        private void HorsesBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControlShow.Children.Clear();
            UserControlShow.Children.Add(new HorseUserControl());
        }

        private void BreedsBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControlShow.Children.Clear();
            UserControlShow.Children.Add(new BreedUserControl());
        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControlShow.Children.Clear();
            UserControlShow.Children.Add(new ListUserControl());
        }
    }
}
