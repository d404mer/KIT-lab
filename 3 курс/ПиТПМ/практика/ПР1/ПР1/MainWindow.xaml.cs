using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string currentInput = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                currentInput += button.Content.ToString();
                ResultTextBox.Text = currentInput;
            }
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    currentInput += " " + button.Content.ToString() + " ";
                    ResultTextBox.Text = currentInput;
                }
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                CalculateResult();
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            currentInput = string.Empty;
            ResultTextBox.Text = string.Empty;
        }

        private void CalculateResult()
        {
            try
            {
                var dataTable = new System.Data.DataTable();
                var result = dataTable.Compute(currentInput, string.Empty);
                double calculatedResult = Convert.ToDouble(result);

                if (calculatedResult == 52)
                {
                    ResultTextBox.Text = "и этот город наш";
                }

                else
                {
                    if (calculatedResult == 4) calculatedResult++;
                    currentInput = calculatedResult.ToString();
                    ResultTextBox.Text = currentInput;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в выражении!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClearButton_Click(null, null);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
        }
    }
}
