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
using DartMediaApp.TablesWindows;

namespace DartMediaApp.EditWindows
{
    /// <summary>
    /// Interaction logic for EditDocumentWindow.xaml
    /// </summary>
    public partial class EditDocumentWindow : Window
    {
        private Doc _currDoc = new Doc();
        public EditDocumentWindow(Doc selecteddoc)
        {
            InitializeComponent();
            if (selecteddoc == null) return;
            _currDoc = selecteddoc;
            DataContext = _currDoc;
        }

        private void ChangeBtn_Click_1(object sender, RoutedEventArgs e)
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

               



            DartMediaDbEntities1.GetContext().SaveChanges();
            MessageBox.Show("Запись изменена");
            DocumentsWindow documentsWindow = new DocumentsWindow();
            documentsWindow.Show();
            Close();
        }
        else MessageBox.Show("Вы не заполнили данные");
        }

        private void Назад_Click(object sender, RoutedEventArgs e)
        {
            DocumentsWindow documentsWindow = new DocumentsWindow();
            documentsWindow.Show();
            this.Close();
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
