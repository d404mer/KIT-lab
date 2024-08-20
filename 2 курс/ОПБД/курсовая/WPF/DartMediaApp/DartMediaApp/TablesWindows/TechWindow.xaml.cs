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
using DartMediaApp.AddWindows;
using DartMediaApp.EditWindows;
using DartMediaApp.TablesWindows;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DartMediaApp.TablesWindows
{
    /// <summary>
    /// Interaction logic for TechWindow.xaml
    /// </summary>
    public partial class TechWindow : Window
    {
        public TechWindow()
        {
            InitializeComponent();
            DataGridTech.ItemsSource = DartMediaDbEntities1.GetContext().Teches.ToList();

        }
        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            var techToRemove = DataGridTech.SelectedItems.Cast<Tech>().ToList();
            if (MessageBox.Show($"Подтвердить удаление?", "!",
  MessageBoxButton.YesNo, MessageBoxImage.Question) !=
 MessageBoxResult.Yes) return;

            DartMediaDbEntities1.GetContext().Teches.RemoveRange(techToRemove);
            DartMediaDbEntities1.GetContext().SaveChanges();
            MessageBox.Show("Ура! Удалилось!");
            DataGridTech.ItemsSource = DartMediaDbEntities1.GetContext().Teches.OrderBy(x =>
           x.tech_id).ToList();
        }

        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (Tech)DataGridTech.SelectedItem;
            new EditTechWindow(item).Show();
            this.Close();
        }
        private void TechBtn_Click(object sender, RoutedEventArgs e)
        {
            DocumentsWindow docs = new DocumentsWindow();
            docs.Show();
            this.Hide();
        }

        private void EmpBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddTechWindow addTech = new AddTechWindow();
            addTech.Show();
            this.Hide();
        }
    }
}
