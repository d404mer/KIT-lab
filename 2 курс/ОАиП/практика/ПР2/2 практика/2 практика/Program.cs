using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace пр2
{
    public class Museum
    {
        private Exp[] museums;
        private int num;
        public Museum()
        {
            museums = new Exp[0];
            num = 0;
        }

        // добавление экспоната
        public void Add(Exp exp)
        {
            num++;
            Array.Resize(ref museums, num);
            museums[num - 1] = exp;
        }

        // удаление экспоната
        public void Remove()
        {
            Exp[] new_arr = new Exp[num - 1];
            for (int i = 0; i < num - 1; i++)
            {
                new_arr[i] = museums[i];
            }

            museums = new_arr;
            num -= 1;
            Console.WriteLine("Последний экспонат успешно удалён");
        }

        // описание экспоната
        public void Print()
        {
            for (int i = 0; i < num; i++)
            {
                museums[i].Print();
            }
        }

        // отображение количества объектов
        public int GetLen()
        {
            return num;
        }

        //  очистка контейнера
        public void Clear()
        {
            museums = new Exp[0];
            num = 0;
            Console.WriteLine("Музей был ограблен :)");
        }
    }

    public class Exp
    {
        static int num = 0;
        public string n;
        public string name;
        public string era;
        public string description;
        public Exp()
        {
            Console.Write("ID: ");
            n = Console.ReadLine();
            if (int.TryParse(n, out int check))
            {
                Console.Write("Название: ");
                name = Console.ReadLine();
                Console.Write("Эпоха: ");
                era = Console.ReadLine();
                Console.Write("Описание: ");
                description = Console.ReadLine();
                num += 1;
                Console.WriteLine("Экспонат был успешно добавлен");
            }
            else {Console.WriteLine("Введённая строка не является числом, ID может быть только целым числом. \nВыход из функции"); }
            
        }

        public void Print()
        {
            Console.WriteLine($"\tID: {n} \n \tНазвание: {name} \n \tЭпоха: {era} \n \tОписание: {description}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Museum museum = new Museum();
            while (true)
            {
                Console.WriteLine("\n \t ---------2 практика--------- \n1. Добавить экспонат \n2. Удалить последний экспонат \n3. Показать все экспонаты \n4. Показать количество экспонатов \n5. Очистить музей \n6. Выйти \nВыберите действие : ");

                try
                {
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            museum.Add(new Exp());
                            break;
                        case 2:
                            museum.Remove();
                            break;
                        case 3:
                            museum.Print();
                            break;
                        case 4:
                            Console.WriteLine("Чи: " + museum.GetLen());
                            break;
                        case 5:
                            museum.Clear();
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("\tИзвини, я тебя не понял :( \n");
                            break;
                    }
                }
                catch
                { Console.WriteLine("Входная строка не являлась числом, проверьте ввод"); }

            }
        }
    }
}
