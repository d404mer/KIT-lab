using System.Data;

namespace inheretOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // создаём новый объект класса, отдельный-конкретный рабочий
            while (true)
            { 
        start:
            Console.WriteLine(" 1 - вывести имя \n 2 - узнать айди \n 3 - работать \n 4 - изменить статус (aa) \n 5 - узнать ЗП");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num) 
            {
                case 1:
                    employee.name_output("NAME");
                    break;

                case 2:
                    employee.show_id();
                        break;

                case 3:
                    employee.work();
                        break;

                case 4:
                    break;

                case 5:
                    employee.salary_output();
                        break;

                default:
                    Console.WriteLine("invalid number");
                    goto start;
            }
            }

        }
    }

    class Worker // базовый класс
    {
        public string name = " ";
        protected int salary = 100;
        protected bool status = true;
        protected int experience = 0;

        public  void work()
        {
            Console.WriteLine("they're working :)");
        }

        protected virtual void experience_gain()
        {
            Console.WriteLine("guess the number: ");
            int num =  Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                experience++;
            }
        }

        public bool status_change()
        {
            status = false;
            Console.WriteLine($"{name} got laid off :(");
            return status;
        }

        public void salary_output()
        {
            Console.WriteLine(salary);
        }

    }

    class Employee : Worker // дочерний класс для конкретных рабочих
    {
        int id;
        string position = " ";

        protected override void experience_gain() // перезапись 1 метода
        {
            if (experience == 1 ) 
            {
                Console.WriteLine("error");
            }
        }

        public  void work() // перезапись 2 метода
        {
            if (status = true)
            {
                Console.WriteLine("correct. they're still working");
            }
            else
            {
                Console.WriteLine("incorrect");
            }
        }

        public void name_output(string name) // ввод имени
        {
            Console.WriteLine(name);
        }

        int id_generator()
        {
            Random rnd = new Random();
            id = rnd.Next(0, 20);
            return id;
        }
        public void show_id()
        {
            id_generator();
            Console.WriteLine(id);
        }

    }
}
