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
    public partial class UC_2laba : UserControl
    {
        public UC_2laba()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( (string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)) )
            {
                output.Text = "Некорректные параметры. Введите числа :(";
            }
            else { Check_triangle();  }
                
        }

        public void Check_triangle()
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = float.Parse(textBox3.Text);
            if ((a <= (b + c)) && (c <= (a + b)) && (b <= (a + c)))
            {
                if ((a == b) && (b == c))
                {
                    output.Text = "Ваш треугольник равносторонний";
                }
                else if ((a == b) || (a == c) || (b == c))
                {
                    output.Text = "Ваш треугольник равнобедренный";
                }
                else
                {
                    output.Text = "Ваш треугольник разносторонний";
                }
            }
            else
            {
                output.Text = "Ваш треугольник не существует";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            output.Text = "";

        }
    }
}
