using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string currentInput = string.Empty;
        private string operatorSelected = string.Empty;
        private double result = 0;

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
                if (currentInput != string.Empty)
                {
                    if (operatorSelected != string.Empty)
                    {
                        CalculateResult();
                    }
                    result = double.Parse(currentInput);
                    operatorSelected = button.Content.ToString();
                    currentInput = string.Empty;
                }
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentInput != string.Empty && operatorSelected != string.Empty)
            {
                CalculateResult();
                operatorSelected = string.Empty;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            currentInput = string.Empty;
            operatorSelected = string.Empty;
            result = 0;
            ResultTextBox.Text = string.Empty;
        }

        private void CalculateResult()
        {
            double newValue = double.Parse(currentInput);

            switch (operatorSelected)
            {
                case "+":
                    result += newValue;
                    break;
                case "-":
                    result -= newValue;
                    break;
                case "*":
                    result *= newValue;
                    break;
                case "/":
                    if (newValue != 0)
                    {
                        result /= newValue;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: Деление на ноль");
                        ClearButton_Click(null, null); 
                    }
                    break;
                case "%":
                    result %= newValue;
                    break;
            }

            currentInput = result.ToString();
            ResultTextBox.Text = currentInput;
        }
    }
}

