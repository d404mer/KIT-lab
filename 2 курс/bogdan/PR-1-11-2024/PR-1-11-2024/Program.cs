using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PR_1_11_2024
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[,] matrix = new int[10, 10];
            fill_matrix(matrix, -10, 1);
            Console.WriteLine("\n ----> Созданная матрица: \n");
            print_matrix(matrix);
            find_negative_column(matrix);
        }

        static void fill_matrix(int[,] matrix, int minValue, int maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++) 
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
        }

        static void print_matrix(int[,] matrix)
        {
      
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void find_negative_column(int[,] matrix)
        {
            Console.WriteLine("\n----> Столбцы, где все элементы отрицательны: \n");
            bool hasNegativeColumns = false; 
            for (int i = 0; i < 10; i++) 
            {
                bool allNegative = true;
                for (int j = 0; j < 10; j++) 
                {
                    if (matrix[j, i] >= 0) 
                    {
                        allNegative = false;
                        break;
                    }
                }
                if (allNegative) 
                {
                    Console.WriteLine($"Столбец: {i+1}");
                    hasNegativeColumns = true; 
                }
            }
            if (!hasNegativeColumns) 
            {
                Console.WriteLine(" \t Отрицательных столбцов нет");
            }
        }
    }
}
