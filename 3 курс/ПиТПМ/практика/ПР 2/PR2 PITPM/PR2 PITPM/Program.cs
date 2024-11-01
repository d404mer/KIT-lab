using System;

namespace PR2_PITPM
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

            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);

            string angleType = "";
            if (a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2)
            {
                angleType = "Acute triangle";
            }
            else if (a2 + b2 < c2 || a2 + c2 < b2 || b2 + c2 < a2)
            {
                angleType = "Obtuse triangle";
            }
            else
            {
                angleType = "Right triangle";
            }

            Console.WriteLine($"Type of triangle angle: {angleType}");
        }
    }
}
