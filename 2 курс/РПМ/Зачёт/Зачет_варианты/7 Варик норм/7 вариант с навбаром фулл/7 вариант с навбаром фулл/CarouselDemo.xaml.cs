using System.IO;
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
    /// Interaction logic for CarouselDemo.xaml
    /// </summary>
    public partial class CarouselDemo : Window
    {
        private bool themeDark = false;

        public CarouselDemo()
        {
            InitializeComponent();
            SetLightTheme();
        }


        private string[] images = new string[]
        {
            "C:\\Users\\user\\YandexDisk\\2 курс\\РПМ\\Зачет_варианты\\Зачет_вариант 7\\фото поликлиники 1.png",
             "C:\\Users\\user\\YandexDisk\\2 курс\\РПМ\\Зачет_варианты\\Зачет_вариант 7\\фото поликлиники 2.png",
              "C:\\Users\\user\\YandexDisk\\2 курс\\РПМ\\Зачет_варианты\\Зачет_вариант 7\\фото поликлиники 3.png",
               "C:\\Users\\user\\YandexDisk\\2 курс\\РПМ\\Зачет_варианты\\Зачет_вариант 7\\фото поликлиники 4.png"
        };
        private int index = 0;

        private void SetLightTheme()
        {
            themeDark = false;
            Background = Brushes.White;
            BGlogo.Opacity = 100;
            LightThemeBTN.Visibility = Visibility.Collapsed;
            DarkThemeBTN.Visibility = Visibility.Visible;
            TextBlockDesc.Foreground = Brushes.Black;
        }

        private void LightThemeBTN_Click(object sender, RoutedEventArgs e)
        {
            SetLightTheme();
        }


        private void SetDarkTheme()
        {
            themeDark = true;
            Background = Brushes.Black;
            BGlogo.Opacity = 0;
            LightThemeBTN.Visibility = Visibility.Visible;
            DarkThemeBTN.Visibility = Visibility.Collapsed;
            TextBlockDesc.Foreground = Brushes.White;
        }
        private void DarkThemeBTN_Click(object sender, RoutedEventArgs e)
        {
            SetDarkTheme();
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void PreviousBTN_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = images.Length - 1;
            }
            updateIMG();
        }

        private void NextBTN_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index >= images.Length) { index = 0; }
            updateIMG();
        }
        private void updateIMG()
        {
            string imgPath = images[index];
            if (File.Exists(imgPath))
            {
                Image.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(imgPath));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
