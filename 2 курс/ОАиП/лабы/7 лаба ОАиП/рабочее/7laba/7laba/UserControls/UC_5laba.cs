using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7laba.UserControls
{
    public partial class UC_5laba : UserControl
    {
        public UC_5laba()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[2,2];
            int det, mult1, mult2;
            Random random_number = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random_number.Next(0, 100);
                }
            }
            MatrixOutput(matrix);
            task(matrix, out det, out mult1, out mult2);
            determ.Text = det.ToString();
            mult.Text = mult1.ToString() + " и " + mult2.ToString();
        }
        private void MatrixOutput(int[,] matrix)
        {
            string output_matrix = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output_matrix += matrix[i, j] + " ";
                }
                output_matrix += Environment.NewLine;
            }
            matrix_output.Text = output_matrix;
        }

        //ф-я куда должны передавать по ссылке и отдавать тоже по ссылке
        private void task( int[,] matrix, out int det, out int mult1, out int mult2)
        {
            mult1 = matrix[0 , 0] * matrix[1 , 1];
            mult2 = matrix[0 , 1] * matrix[1 , 0];
            det = mult1 - mult2;
        }
    }
}
