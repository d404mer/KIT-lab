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
using DartMediaApp.AddWindows;
using DartMediaApp.EditWindows;
using DartMediaApp.TablesWindows;

namespace DartMediaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Emp _currentEmp = new Emp();
        
        public MainWindow()
        {
            InitializeComponent();
            DataGridEmps.ItemsSource = DartMediaDbEntities1.GetContext().Emps.ToList();

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
           AddEmpPage addEmpPage = new AddEmpPage();
            addEmpPage.Show();
            this.Hide();
        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
           var EmpToRemove = DataGridEmps.SelectedItems.Cast<Emp>().ToList();
            if (MessageBox.Show($"Подтвердить удаление?", "!",
  MessageBoxButton.YesNo, MessageBoxImage.Question) !=
 MessageBoxResult.Yes) return;

            DartMediaDbEntities1.GetContext().Emps.RemoveRange(EmpToRemove);
            DartMediaDbEntities1.GetContext().SaveChanges();
            MessageBox.Show("Ура! Удалилось!");
            DataGridEmps.ItemsSource = DartMediaDbEntities1.GetContext().Emps.OrderBy(x =>
           x.emp_id).ToList();
        }
        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (Emp)DataGridEmps.SelectedItem;
            new EmpEditWindow(item).Show();
            this.Close();
        }

        private void TechBtn_Click(object sender, RoutedEventArgs e)
        {
            TechWindow techWindow = new TechWindow();
            techWindow.Show();
            this.Close();
        }

        private void DocsBtn_Click(object sender, RoutedEventArgs e)
        {
            DocumentsWindow docsWindow = new DocumentsWindow();
            docsWindow.Show();
            this.Close();
        }
    }
}
