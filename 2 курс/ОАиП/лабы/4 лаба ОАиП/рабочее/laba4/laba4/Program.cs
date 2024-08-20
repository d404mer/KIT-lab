using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание: ");
            int task = Int32.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    task1.t1();
                    break;

                case 2:
                    task2.t2();
                    break;
            }

        }
    }



    // дана действ.матрица порядка 12. на главной - 0, выше главной - 1
    public class task1
    {
        public static void t1()
        {
            int[,] matrix = new int[12, 12];
            Random random_number = new Random();
             for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random_number.Next(0,100);
                }
            }

            Console.WriteLine("Исходная матрица (12x12):");
            //for (int p = &matrix[0][0]; p <= ) чек потом Using Pointers to Print 2D Arrays
            MatrixOutput(matrix);

            Console.WriteLine(" \n Матрица переколбашена:");
            MatrixChange(matrix);
            MatrixOutput(matrix);
        }


        public static void MatrixOutput(int[,] matrix)
        {
            for (int i = 0; i < 12; i++) // row
            {
                for (int j = 0; j < 12; j++) // column
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void MatrixChange(int[,] matrix)
        {
            int[,] temp = new int[12, 12];

            for (int i = 0; i < 12; i++) // row
            {
                for (int j = 0; j < 12; j++) // column
                {
                   if (i == j) { matrix[i, j] = 0;}
                   else if ( i < j ) { matrix[i, j] = 1;}
                }
            }

        }

    }


    // Морской бой. по методичке читать
    public class task2
    {
        public static void t2()
        {

        }
    }
}