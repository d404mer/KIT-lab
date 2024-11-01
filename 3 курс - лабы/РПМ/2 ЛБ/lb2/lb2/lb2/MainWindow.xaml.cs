using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lb2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            //размеры кнопки и канвас
            double buttonWidth = runAwayButton.Width;
            double buttonHeight = runAwayButton.Height;
            double currentPosX = Canvas.GetLeft(runAwayButton);
            double currentPosY = Canvas.GetTop(runAwayButton);
            double canvasWidth = MainCanvas.ActualWidth;
            double canvasHeight = MainCanvas.ActualHeight;

            // случайные перемещения
            double offsetX = random.Next(-50, 51);
            double offsetY = random.Next(-50, 51);

            // проверка размеров кнопки в канвасе
            double newPosX = currentPosX + offsetX;
            double newPosY = currentPosY + offsetY;

            if (newPosX < 0)
            {
                newPosX = 0;
            }
            else if (newPosX + buttonWidth > canvasWidth)
            {
                newPosX = canvasWidth - buttonWidth;
            }

            if (newPosY < 0)
            {
                newPosY = 0;
            }
            else if (newPosY + buttonHeight > canvasHeight)
            {
                newPosY = canvasHeight - buttonHeight;
            }

            // новая позицию кнопки
            Canvas.SetLeft(runAwayButton, newPosX);
            Canvas.SetTop(runAwayButton, newPosY);
        }
    }
}