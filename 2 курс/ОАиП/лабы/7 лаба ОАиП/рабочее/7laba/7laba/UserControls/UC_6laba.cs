using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7laba.UserControls
{
    public partial class UC_6laba : UserControl
    {
        public UC_6laba()
        {
            InitializeComponent();
            MessageBox.Show("необходимо вводить все дроби полностью :)");
        }

        private void addition_Click(object sender, EventArgs e)
        {
            
            check_textbox();
            int a = Int32.Parse(denominator1.Text);
            int b = Int32.Parse(numerator1.Text);
            int a2 = Int32.Parse(denominator2.Text);
            int b2 = Int32.Parse(numerator2.Text);
            Rational fraction1 = new Rational(a, b);
            Rational fraction2 = new Rational(a2, b2);
            Rational sum = fraction1.Add(fraction2);
            num_res.Text = sum.ToString();
        }

        private void difference_Click(object sender, EventArgs e)
        {
            check_textbox();
            int a = Int32.Parse(denominator1.Text);
            int b = Int32.Parse(numerator1.Text);
            int a2 = Int32.Parse(denominator2.Text);
            int b2 = Int32.Parse(numerator2.Text);
            Rational fraction1 = new Rational(a, b);
            Rational fraction2 = new Rational(a2, b2);
            Rational difference = fraction1.Subtract(fraction2);
            num_res.Text = difference.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            check_textbox();
            int a = Int32.Parse(denominator1.Text);
            int b = Int32.Parse(numerator1.Text);
            int a2 = Int32.Parse(denominator2.Text);
            int b2 = Int32.Parse(numerator2.Text);
            Rational fraction1 = new Rational(a, b);
            Rational fraction2 = new Rational(a2, b2);
            Rational product = fraction1.Multiply(fraction2);
            num_res.Text = product.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // это деление такое :(
        {
            check_textbox();
            int a = Int32.Parse(denominator1.Text);
            int b = Int32.Parse(numerator1.Text);
            int a2 = Int32.Parse(denominator2.Text);
            int b2 = Int32.Parse(numerator2.Text);
            Rational fraction1 = new Rational(a, b);
            Rational fraction2 = new Rational(a2, b2);
            Rational quotient = fraction1.Divide(fraction2);
            num_res.Text = quotient.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // а это сравнение получается
        {
            check_textbox();
            int a = Int32.Parse(denominator1.Text);
            int b = Int32.Parse(numerator1.Text);
            int a2 = Int32.Parse(denominator2.Text);
            int b2 = Int32.Parse(numerator2.Text);
            Rational fraction1 = new Rational(a, b);
            Rational fraction2 = new Rational(a2, b2);
            bool equal = fraction1.Compare(fraction2);
            num_res.Text = equal.ToString();
        }

        private bool check_textbox()
        {
            bool check = false;
                if ((string.IsNullOrEmpty(denominator1.Text)) || (string.IsNullOrEmpty(numerator1.Text)) || (string.IsNullOrEmpty(denominator2.Text)) || (string.IsNullOrEmpty(numerator2.Text)))
                {
                    MessageBox.Show("Некорректные параметры. Пустые значения по умолчанию = 0 ");
                check = true;
                }

            return check;
        }

        private void numerator1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void denominator1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void numerator2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void denominator2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }






    class Rational
        {
            private int numerator; // числитель
            private int denominator; // знаменатель
                                     // для инициализации рациональной дроби
            public Rational(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            // для нахождения наибольшего общего делителя числителя и знаменателя
            private int FindGCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
            // Сокращение
            private void Simplify()
            {
                int gcd = FindGCD(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
            }
            // Сложение
            public Rational Add(Rational other)
            {
                int newNumerator = numerator * other.denominator + other.numerator *
               denominator;
                int newDenominator = denominator * other.denominator;
                Rational result = new Rational(newNumerator, newDenominator);
                result.Simplify();
                return result;
            }
            // Вычитание
            public Rational Subtract(Rational other)
            {
                int newNumerator = numerator * other.denominator - other.numerator *
               denominator;
                int newDenominator = denominator * other.denominator;
                Rational result = new Rational(newNumerator, newDenominator);
                result.Simplify();
                return result;
            }
            // Умножение
            public Rational Multiply(Rational other)
            {
                int newNumerator = numerator * other.numerator;
                int newDenominator = denominator * other.denominator;
                Rational result = new Rational(newNumerator, newDenominator);
                result.Simplify();
                return result;
            }
            // Деление
            public Rational Divide(Rational other)
            {
                int newNumerator = numerator * other.denominator;
                int newDenominator = denominator * other.numerator;
                Rational result = new Rational(newNumerator, newDenominator);
                result.Simplify();
                return result;
            }
            // Сравнение
            public bool Compare(Rational other)
            {
                Simplify();
                other.Simplify();
                return numerator == other.numerator && denominator == other.denominator;
            }
            // Норм вывод 
            public override string ToString()
             {
             return numerator + "/" + denominator;
             }
            }



}
