namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int task;
            Console.WriteLine("Задание: ");
            switch (task)
            {
                case 1:
                task1.t1();
                break;

                case 2
                task2.t2();
                break;
            }

        }
    }

    /*Напишите программу, которая принимает длины трех сторон треугольника и определяет его тип: 
 * "равносторонний", "равнобедренный" или "разносторонний".*/


    public class task1
    {
        public static void t1()
        {
            float a, b, c;
            Console.WriteLine("Введите сторону a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c: ");
            c = float.Parse(Console.ReadLine());

            if ((a <= (b + c)) && (c <= (a + b)) && (b <= (a + c)))
            {
                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Треугольник равносторонний");
                }
                else if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("Треуголник равнобедренный");
                }
                else { Console.WriteLine("Треугольник произвольный"); }
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
    }



    /*    Часть 2. Разработать простой тест: на экране по очереди появляются вопросы(вопросы выбираются студентом), 
            с вариантами ответов.В конце работы программа выдает количество заработанных баллов по результатам ответа.
            Минимальное количество вопросов – пять.*/
    public class task2
    {
        public static void t2()
        {
            int a, count = 0;
            Console.WriteLine("1. Яблоко - фрукт? \n 1.Да \n 2.Нет \nВаш ответ: ");
            rem1:
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Верно! \n");
                    count++;
                    break;
                case 2:
                    Console.WriteLine("Неверно! \n");
                    break;
                default:
                    Console.WriteLine("Некорректное значение. Введите ответ заново: ");
                    goto rem1;
                    break;
            }
            Console.WriteLine("2. У человека 5 пальцев? \n 1.Да \n 2.Нет \nВаш ответ: ");
            rem2:
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Верно! \n");
                    count++;
                    break;
                case 2:
                    Console.WriteLine("Неверно! \n");
                    break;
                default:
                    Console.WriteLine("Некорректное значение. Введите ответ заново: ");
                    goto rem2;
                    break;
            }
            Console.WriteLine("3. У КАИ 7 зданий? \n 1.Да \n 2.Нет \nВаш ответ: ");
            rem3:
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 2:
                    Console.WriteLine("Верно! \n");
                    count++;
                    break;
                case 1:
                    Console.WriteLine("Неверно! \n");
                    break;
                default:
                    Console.WriteLine("Некорректное значение. Введите ответ заново: ");
                    goto rem3;
                    break;
            }
            Console.WriteLine("4. КАИ - пуп Земли? \n 1.Да \n 2.Нет \nВаш ответ: ");
        rem4:
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Верно! \n");
                    count++;
                    break;
                case 2:
                    Console.WriteLine("Неверно! \n");
                    break;
                default:
                    Console.WriteLine("Некорректное значение. Введите ответ заново: ");
                    goto rem4;
                    break;
            }
            Console.WriteLine("5. КИТ - пуп Земли? \n 1.Да \n 2.Нет \nВаш ответ: ");
        rem5:
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Верно! \n");
                    count++;
                    break;
                case 2:
                    Console.WriteLine("Неверно! \n");
                    break;
                default:
                    Console.WriteLine("Некорректное значение. Введите ответ заново: ");
                    goto rem5;
                    break;
            }
            Console.WriteLine("Ваш счёт: " + count);
        }
    }
}