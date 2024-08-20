namespace laba2
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

    //1. Вычислить по формуле в методичке

    public class task1
    {
        public static void t1()
        {
            int i = 1, sum = 0, a = 0, b = 0, raz = 0;
            while (i <= 40)
            {
                if ((i % 2) != 0)
                {
                    a = i;
                    b = (int)Math.Pow(i, 2);
                }
                else
                {
                    a = i - 1;
                    b = (int)Math.Pow(i, 3);
                }
                raz = ((int)Math.Pow(a, 2) - 2 * a * b + (int)Math.Pow(b, 2));
                i++;
                a = 0;
                b = 0;
                sum += raz;
            }
            Console.WriteLine(sum);
        }
    }

    //2. Перевести целое число из десятичной системы счисления в двоичную, используя алгоритм деления на 2

    public class task2
    {
        public static void t2()
        {

        }
    }
}