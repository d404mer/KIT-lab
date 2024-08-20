using DartMediaApp.TablesWindows;
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

namespace DartMediaApp.AddWindows
{
    /// <summary>
    /// Interaction logic for AddDocumentWindow.xaml
    /// </summary>
    public partial class AddDocumentWindow : Window
    {
        private Doc _currDoc = new Doc();
        
        public AddDocumentWindow()
        {
            InitializeComponent();
            DataContext = _currDoc;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            DocumentsWindow documentsWindow = new DocumentsWindow();
            documentsWindow.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = true;
            foreach (Control c in sp1.Children)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (((TextBox)c).Text == String.Empty && ((TextBox)c).Name != "Lastname")
                    {
                        flag = false;
                    }
                }
                if (c.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)c).Text == String.Empty)
                    {
                        flag = false;
                    }
                }
            }




            if (flag)
            {


                DartMediaDbEntities1.GetContext().Docs.Add(_currDoc);
                DartMediaDbEntities1.GetContext().SaveChanges();



                MessageBox.Show("Запись добавлена");
                DocumentsWindow documentsWindow = new DocumentsWindow();
                documentsWindow.Show();
                this.Hide();
            }
            else MessageBox.Show("Вы не заполнили данные");
        }

        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true; // Отменить ввод символа, если он не является цифрой
                    return;
                }
            }
        }
    }
}
