﻿using System;
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

namespace lb2
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow jerry = new MainWindow();
            jerry.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sun sun = new sun();
            sun.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pain pain = new pain();
            pain.Show();
        }
    }
}
