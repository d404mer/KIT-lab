using System.Diagnostics;

namespace TALB3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Текущая рабочая директория: " + Directory.GetCurrentDirectory());


            // Путь к файлу
            string filePath = "text.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
                return;
            }

            string text = File.ReadAllText(filePath);
            Console.WriteLine("Файл успешно прочитан.");


            Console.Write("Введите слово для поиска: ");
            string pattern = Console.ReadLine();

            Console.WriteLine("Выберите алгоритм поиска:");
            Console.WriteLine("1. Кнут-Моррис-Пратт (КМП)");
            Console.WriteLine("2. Бойер-Мур-Хорспул");
            int choice = int.Parse(Console.ReadLine());

            List<int> result = null;
            Stopwatch stopwatch = new Stopwatch();

            switch (choice)
            {
                case 1:
                    stopwatch.Start();
                    result = KnuthMorrisPratt.Search(text, pattern);
                    stopwatch.Stop();
                    break;

                case 2:
                    stopwatch.Start();
                    result = BoyerMooreHorspool.Search(text, pattern);
                    stopwatch.Stop();
                    break;

                default:
                    Console.WriteLine("Неверный выбор алгоритма.");
                    return;
            }
            Console.WriteLine("Считанный текст: ");
            Console.WriteLine(text);


            Console.WriteLine($"Найдено {result.Count} вхождений:");
            foreach (var index in result)
            {
                Console.WriteLine($"Позиция: {index}");
            }

            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс.");
        }
    }
}
