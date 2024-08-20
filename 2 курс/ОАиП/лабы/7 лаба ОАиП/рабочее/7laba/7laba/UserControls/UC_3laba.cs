using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _7laba.UserControls
{
    public partial class UC_3laba : UserControl
    {
        public UC_3laba()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( (string.IsNullOrEmpty(textBox1.Text)) )
            {
                output.Text = "Некорректные параметры";
            }
            else 
            {
                output.Text = " ";
                converter(); 
            }
        }

        private void converter()
        {
            int decimalNum = int.Parse(textBox1.Text);
            int[] numberArray = new int[10];
            int i;
            for (i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = decimalNum % 2;
                decimalNum = decimalNum / 2;
            }

           for (i = i - 1; i >= 0; i--)
           {
               output.Text += numberArray[i];
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

        private void output_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
