using System;
using System.Collections.Generic;
using System.IO;
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

namespace несовсемлаба
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
        private void rtf_click(object sender, RoutedEventArgs e)
        {
            

            if (docViewer.Document != null)
            {
                string path = "myfile.rtf";
                //string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //string path = documentsPath + "myfile.rtf";
                using (FileStream fs = File.Create(path))
                {
                    TextRange range = new TextRange(docViewer.Document.ContentStart, docViewer.Document.ContentEnd);
                    range.Save(fs, DataFormats.Rtf);
                }
                MessageBox.Show("Файл сохранен в вашу папку bin >> debug проекта ");
            }



        }
    }
}
