using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MyRecordsWindow.xaml
    /// </summary>
    public partial class MyRecordsWindow : Window
    {
        public ObservableCollection<Work> Works { get; set; }
        public MyRecordsWindow()
        {
            InitializeComponent();

            Works = new ObservableCollection<Work>
        {
            new Work { ImagePath = "image1.jpg", Description = "Work 1 Description" },
            new Work { ImagePath = "image2.jpg", Description = "Work 2 Description" },
            new Work { ImagePath = "image3.jpg", Description = "Work 3 Description" }
        };
        }


    }
}
public class Work
{
    public string ImagePath { get; set; }
    public string Description { get; set; }
}
