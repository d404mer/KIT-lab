using static System.Runtime.InteropServices.JavaScript.JSType;

namespace laba3_sharp
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
                    Console.WriteLine("я не знаю почему не работает :))))))))");
                    break;

                case 2:
                    Console.WriteLine("На данный момент работает только перевод целых натуральных чисел");
                    task2.t2();
                    break;
            }

        }
    }



    // по формуле вычислить прикол
    public class task1
    {
        public static void t1()
        {
            double i = 1, sum = 0, a = 0, b = 0, raz = 0, check = 0;
            while (i <= 40)
            {
                if ((i % 2) != 0)
                {
                    a = i;
                    b = Math.Pow(i, 2);
                }
                else
                {
                    a = i - 1;
                    b = Math.Pow(i, 3);
                }
                raz = (Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2));
                a = b = 0;
                check++;
                sum += raz;
                Console.WriteLine(check + " " + sum + "\n ");
                i++;
            }
            Console.WriteLine(sum);
        }
    }




    public class task2
    {
        public static void t2()
        {
            Console.WriteLine("Введите число: ");
            int decimalNum = Int32.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = decimalNum % 2;
                decimalNum = decimalNum / 2;
            }

            if (decimalNum >= 0)
            {
                
                for (i = i - 1; i >= 0; i--)
                {
                    Console.Write(numberArray[i]);
                }
            }
            else
            {
                for (i = i - 1; i >= 0; i--)
                {
                    Console.Write(numberArray[i]);
                }
            }

           /*if (decimalNum >= 0)
           {
               for (i = i - 1; i >= 0; i--)
               {
                   Console.Write(numberArray[i]);
               }
           }
           else
           {
               for (i = 0; i < numberArray.Length; i++)
               {
                   if (numberArray[i] == 0)
                   {
                       numberArray[i] = 1;
                   }
                   else
                   {
                       numberArray[i] = 0;
                   }
               }

               for (i = i - 1; i >= 0; i--)
               {
                   Console.Write("1" + numberArray[i]);
               }
           } */

            }
        }
}