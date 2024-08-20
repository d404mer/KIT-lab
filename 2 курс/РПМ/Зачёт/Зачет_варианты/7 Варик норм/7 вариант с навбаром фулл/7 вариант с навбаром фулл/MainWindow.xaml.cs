using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7_вариант_с_навбаром_фулл
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsThemeDark = false;

        private void SetDarkTheme()
        {
            IsThemeDark = true;
            Background = Brushes.Black;
            BGlogo.Opacity = 0;
            LightTheme.Visibility = Visibility.Visible;
            DarkTheme.Visibility = Visibility.Collapsed;
            TextBlock.Foreground = Brushes.White;
        }

        private void SetLightTheme()
        {
            IsThemeDark = false;
            Background = Brushes.White;
            BGlogo.Opacity = 100;
            LightTheme.Visibility = Visibility.Collapsed;
            DarkTheme.Visibility = Visibility.Visible;
            TextBlock.Foreground = Brushes.Black;
        }


        public MainWindow()
        {
            InitializeComponent();
            SetLightTheme();
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

        private void LightTheme_Click(object sender, RoutedEventArgs e)
        {
            SetLightTheme();
        }

        private void DarkTheme_Click(object sender, RoutedEventArgs e)
        {
            SetDarkTheme();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

    }
}