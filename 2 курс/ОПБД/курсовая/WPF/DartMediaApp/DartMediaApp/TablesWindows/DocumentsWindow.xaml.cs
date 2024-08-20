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
    /// Interaction logic for DocumentsWindow.xaml
    /// </summary>
    public partial class DocumentsWindow : Window
    {
        public DocumentsWindow()
        {
            InitializeComponent();
            DataGridDocs.ItemsSource = DartMediaDbEntities1.GetContext().Docs.ToList();
        }

        private void EmpBstn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void TechBtn_Click(object sender, RoutedEventArgs e)
        {
            TechWindow tech = new TechWindow();
            tech.Show();
            this.Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDocumentWindow addDocumentWindow = new AddDocumentWindow();
            addDocumentWindow.Show();
            this.Close();
        }


        private void ButtonDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            var DocToRemoe = DataGridDocs.SelectedItems.Cast<Doc>().ToList();
            if (MessageBox.Show($"Подтвердить удаление?", "!",
  MessageBoxButton.YesNo, MessageBoxImage.Question) !=
 MessageBoxResult.Yes) return;

            DartMediaDbEntities1.GetContext().Docs.RemoveRange(DocToRemoe);
            DartMediaDbEntities1.GetContext().SaveChanges();
            MessageBox.Show("Ура! Удалилось!");

            DataGridDocs.ItemsSource = DartMediaDbEntities1.GetContext().Docs.OrderBy(x =>
           x.dockpack_id).ToList();
        }

        private void ButtonEditGrid_Click(object sender, RoutedEventArgs e)
        {
            var item = (Doc)DataGridDocs.SelectedItem;
            new EditDocumentWindow(item).Show();
            this.Close();
        }
    }
}
