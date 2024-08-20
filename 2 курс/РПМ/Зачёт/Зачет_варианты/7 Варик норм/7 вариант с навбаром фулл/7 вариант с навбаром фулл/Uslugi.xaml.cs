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

namespace _7_вариант_с_навбаром_фулл
{
    /// <summary>
    /// Interaction logic for Uslugi.xaml
    /// </summary>
    public partial class Uslugi : Window
    {
        public Uslugi()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }

        private void Uslugi_Click(object sender, RoutedEventArgs e)
        {
            Uslugi uslugi = new Uslugi();
            uslugi.Show();
            this.Hide();
        }

        private void Meds_Click(object sender, RoutedEventArgs e)
        {
            Meds meds = new Meds();
            meds.Show();
            this.Hide();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CarouselDemo_Click(object sender, RoutedEventArgs e)
        {
            CarouselDemo carouselDemo = new CarouselDemo();
            carouselDemo.Show();
            this.Hide();
        }
    }
}
