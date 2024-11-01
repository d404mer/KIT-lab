using System;

namespace PR2_PITPM_2
{
    class Triangle
    {
        static void Main()
        {
            Console.WriteLine("Enter the lengths of the triangle sides:");
            double a, b, c;

            Console.Write("A: ");
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive number for side A.");
                Console.Write("A: ");
            }

            Console.Write("B: ");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive number for side B.");
                Console.Write("B: ");
            }

            Console.Write("C: ");
            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive number for side C.");
                Console.Write("C: ");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Error: The sum of two sides must be greater than the third.");
                return;
            }

            string type = "";
            if (a == b && b == c)
            {
                type = "Equilateral triangle";
            }
            else if (a == b || b == c || a == c)
            {
                type = "Isosceles triangle";
            }
            else
            {
                type = "Scalene triangle";
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Type of triangle: {type}");
            Console.WriteLine($"Area of the triangle: {area}");
        }
    }
}
