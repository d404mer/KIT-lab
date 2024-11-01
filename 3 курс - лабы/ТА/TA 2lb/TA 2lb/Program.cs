using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TA_2lb
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n--------------------------------------------------------------------------------");
                Console.WriteLine("   Выберите алгоритм:");
                Console.WriteLine("1. Получение последней цифры числа (O(1))");
                Console.WriteLine("2. Поиск позиции для вставки в отсортированном массиве (O(log n))");
                Console.WriteLine("3. Найти минимальное значение в массиве (O(n))");
                Console.WriteLine("4. Сортировка слиянием (O(n log n))");
                Console.WriteLine("5. Найти все пары чисел в квадратном массиве, сумма которых равна заданному значению (O(n^2))");
                Console.WriteLine("6. Поиск всех способов разбить число n на суммы натуральных чисел (O(2^n))");
                Console.WriteLine("7. Генерация всех возможных комбинаций r элементов из n (O(n!))");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Пожалуйста, введите номер алгоритма.");
                    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    continue;
                }

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        LastDigit();
                        break;
                    case 2:
                        FindInsertPositionDemo();
                        break;
                    case 3:
                        FindMinimumValue();
                        break;
                    case 4:
                        MergeSortDemo();
                        break;
                    case 5:
                        FindPairsWithSumDemo();
                        break;
                    case 6:
                        ExponentialAlgorithm();
                        break;
                    case 7:
                        FactorialAlgorithm();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        // O(1) - Получение последней цифры числа
        static void LastDigit()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int lastDigit = Math.Abs(number) % 10;
            Console.WriteLine($"Последняя цифра числа: {lastDigit}");
        }

        // O(log n) - Поиск позиции для вставки в отсортированном массиве
        static void FindInsertPositionDemo()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            Console.WriteLine("Изначальный отсортированный массив: " + string.Join(", ", sortedArray));
            Console.Write("Введите число для вставки: ");
            int target = int.Parse(Console.ReadLine());
            int comparisons = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int position = FindInsertPosition(sortedArray, target, ref comparisons);
            stopwatch.Stop();

            Console.WriteLine($"Число можно вставить на позицию: {position}");
            Console.WriteLine($"Количество сравнений: {comparisons}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }


        static int FindInsertPosition(int[] sortedArray, int target, ref int comparisons)
        {
            int left = 0;
            int right = sortedArray.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                comparisons++;
                if (sortedArray[mid] == target)
                    return mid;
                else if (sortedArray[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return left;
        }

        // O(n) - Найти минимальное значение в массиве
        static void FindMinimumValue()
        {
            int[] array = { 5, 2, 8, 4, 1, 7 };
            int comparisons = 0;
            Console.WriteLine("Изначальный массив: " + string.Join(", ", array));
            Stopwatch stopwatch = Stopwatch.StartNew();
            int minValue = FindMinimum(array, ref comparisons);
            stopwatch.Stop();

            Console.WriteLine($"Минимальное значение в массиве: {minValue}");
            Console.WriteLine($"Количество сравнений: {comparisons}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

        static int FindMinimum(int[] array, ref int comparisons)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                comparisons++;
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        // O(n log n) - Сортировка слиянием с подсчетом количества перестановок, сравнений и времени выполнения
        static void MergeSortDemo()
        {
            int[] array = { 38, 27, 43, 3, 9, 82, 10 };
            Console.WriteLine("Изначальный массив: " + string.Join(", ", array));
            int comparisons = 0;
            int swaps = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            MergeSort(array, 0, array.Length - 1, ref comparisons, ref swaps);
            stopwatch.Stop();

            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array));
            Console.WriteLine($"Количество сравнений: {comparisons}");
            Console.WriteLine($"Количество перестановок: {swaps}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

        static void MergeSort(int[] array, int left, int right, ref int comparisons, ref int swaps)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle, ref comparisons, ref swaps);
                MergeSort(array, middle + 1, right, ref comparisons, ref swaps);
                Merge(array, left, middle, right, ref comparisons, ref swaps);
            }
        }

        static void Merge(int[] array, int left, int middle, int right, ref int comparisons, ref int swaps)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(array, left, leftArray, 0, leftSize);
            Array.Copy(array, middle + 1, rightArray, 0, rightSize);

            int i = 0, j = 0, k = left;
            while (i < leftSize && j < rightSize)
            {
                comparisons++;
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
                swaps++;
            }

            while (i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
                swaps++;
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
                swaps++;
            }
        }

        // O((n * m)^2) - Найти все пары чисел в квадратной матрице, сумма которых равна заданному значению
        static void FindPairsWithSumDemo()
        {
            int[,] matrix =
                {
            { 1, 5, 3 },
            { 6, 2, 8 },
            { 4, 7, 9 }
        };

            Console.Write("Введите целевую сумму: ");
            int targetSum = int.Parse(Console.ReadLine());
            int comparisons = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            FindPairsWithSum(matrix, targetSum, ref comparisons);
            stopwatch.Stop();

            Console.WriteLine($"Количество сравнений: {comparisons}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

        static void FindPairsWithSum(int[,] matrix, int targetSum, ref int comparisons)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Перебираем каждую пару элементов матрицы
            for (int i1 = 0; i1 < rows; i1++)
            {
                for (int j1 = 0; j1 < cols; j1++)
                {
                    int currentValue1 = matrix[i1, j1];

                    for (int i2 = 0; i2 < rows; i2++)
                    {
                        for (int j2 = 0; j2 < cols; j2++)
                        {
                            if (i1 == i2 && j1 == j2)
                                continue;

                            int currentValue2 = matrix[i2, j2];
                            comparisons++;

                            // Проверяем, равна ли сумма пары целевому значению
                            if (currentValue1 + currentValue2 == targetSum)
                            {
                                Console.WriteLine($"Пара: ({currentValue1}, {currentValue2})");
                            }
                        }
                    }
                }
            }
        }


        // O(2^n) - Поиск всех способов разбить число n на суммы натуральных чисел
        static void ExponentialAlgorithm()
        {
            Console.Write("Введите число для разбиения: ");
            int number = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = Stopwatch.StartNew();
            var partitions = Partition(number);
            stopwatch.Stop();

            foreach (var part in partitions)
            {
                Console.WriteLine(string.Join(" + ", part));
            }

            Console.WriteLine($"Количество разбиений: {partitions.Count}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

        static List<List<int>> Partition(int n)
        {
            var result = new List<List<int>>();
            Partition(n, n, new List<int>(), result);
            return result;
        }

        static void Partition(int n, int max, List<int> prefix, List<List<int>> result)
        {
            if (n == 0)
            {
                result.Add(new List<int>(prefix));
                return;
            }

            for (int i = Math.Min(max, n); i >= 1; i--)
            {
                prefix.Add(i);
                Partition(n - i, i, prefix, result);
                prefix.RemoveAt(prefix.Count - 1);
            }
        }

        // O(n!) - Генерация всех возможных комбинаций r элементов из n
        static void FactorialAlgorithm()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите r: ");
            int r = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = Stopwatch.StartNew();
            var combinations = GetCombinations(n, r);
            stopwatch.Stop();

            foreach (var combination in combinations)
            {
                Console.WriteLine(string.Join(", ", combination));
            }

            Console.WriteLine($"Количество комбинаций: {combinations.Count}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

        static List<List<int>> GetCombinations(int n, int r)
        {
            var result = new List<List<int>>();
            GetCombinations(Enumerable.Range(1, n).ToArray(), r, new List<int>(), result, 0);
            return result;
        }

        static void GetCombinations(int[] array, int r, List<int> current, List<List<int>> result, int index)
        {
            if (current.Count == r)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = index; i < array.Length; i++)
            {
                current.Add(array[i]);
                GetCombinations(array, r, current, result, i + 1);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
