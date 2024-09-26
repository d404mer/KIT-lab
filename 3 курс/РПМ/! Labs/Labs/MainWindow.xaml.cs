using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using System;
using System.Diagnostics;
using System.Windows;

namespace Labs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string exepath = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LB_1_Click(object sender, RoutedEventArgs e)
        {
            exepath = @"C:\Users\user\Documents\GitHub\KIT-lab\3 курс\РПМ\1 ЛБ\1 LB RPM\1 LB RPM\bin\Debug\1 LB RPM.exe";
            try
            { Process.Start(exepath); }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка запуска", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void LB_2_Click(object sender, RoutedEventArgs e)
        {
            exepath = @"";
            try
            { Process.Start(exepath); }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка запуска", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
