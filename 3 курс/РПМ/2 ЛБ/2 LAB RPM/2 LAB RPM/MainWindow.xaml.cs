using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _2_LAB_RPM
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EscapeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            // Получаем текущие координаты кнопки
            double buttonX = EscapeButton.Margin.Left;
            double buttonY = EscapeButton.Margin.Top;

            // Генерируем новые координаты, смещая кнопку случайным образом
            double newX = buttonX + random.Next(-50, 50);
            double newY = buttonY + random.Next(-50, 50);

            // Убедимся, что кнопка не уходит за границы окна
            if (newX < 0) newX = 0;
            if (newX + EscapeButton.Width > this.Width) newX = this.Width - EscapeButton.Width;
            if (newY < 0) newY = 0;
            if (newY + EscapeButton.Height > this.Height) newY = this.Height - EscapeButton.Height;

            // Перемещаем кнопку
            EscapeButton.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}
