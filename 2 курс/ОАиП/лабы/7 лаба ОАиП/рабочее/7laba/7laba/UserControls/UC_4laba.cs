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
    public partial class UC_4laba : UserControl
    {
        public UC_4laba()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // creating a 12x12 matrix with random values from 0 to 100
            int[,] matrix = new int[12, 12];
            Random random_number = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random_number.Next(0, 100);
                }
            }
            MatrixOutput1(matrix);
            MatrixChange(matrix);
            MatrixOutput2(matrix);
        }

        public void MatrixOutput1(int[,] matrix)
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
            matrix1.Text = output_matrix;
        }
        public void MatrixOutput2(int[,] matrix)
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
            output.Text = output_matrix;
        }

        public void MatrixChange(int[,] matrix)
        {
            int[,] temp = new int[12, 12];
            for (int i = 0; i < 12; i++) // row
            {
                for (int j = 0; j < 12; j++) // column
                {
                    if (i == j) { matrix[i, j] = 0; }
                    else if (i < j) { matrix[i, j] = 1; }
                }
            }

        }
    }
}