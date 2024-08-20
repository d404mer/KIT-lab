using Microsoft.VisualBasic;
using System;

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
                    Console.WriteLine("Введите левую границу: ");
                    int first = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите правую границу: ");
                    int second = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число: ");
                    int num = Int32.Parse(Console.ReadLine());
                    task1.rangecheck(first,second, num);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("+------------------------+");
                    Console.WriteLine("|       Калькулятор      |");
                    Console.WriteLine("|       Рациональных     |");
                    Console.WriteLine("|          Дробей        |");
                    Console.WriteLine("+------------------------+");
                    Console.WriteLine("Введите числитель (a): ");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите знаменатель !=0 (b): ");
                    int b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите числитель (a2): ");
                    int a2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите знаменатель !=0 (b2): ");
                    int b2 = Int32.Parse(Console.ReadLine());
                    Rational fraction1 = new Rational(a, b);
                    Rational fraction2 = new Rational(a2, b2);

                    invalid_data:
                    Console.WriteLine("\n Выберите нужное действие: \n 1. Разность \t      2. Сложение \n 3. Произведение      4. Деление \n 5.Сравнение          6. Выйти");
                    int action = Int32.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1: // difference
                            {
                                Rational difference = fraction1.Subtract(fraction2);
                                Console.WriteLine("Разность " + difference);
                                goto invalid_data;
                            }
                        case 2: // addition
                            {
                                Rational sum = fraction1.Add(fraction2);
                                Console.WriteLine("Сумма " + sum);
                                goto invalid_data;
                            }
                        case 3: // multiplication
                            {
                                Rational product = fraction1.Multiply(fraction2);
                                Console.WriteLine("Произведение " + product);
                                goto invalid_data;
                            }
                        case 4: // division
                            {
                                Rational quotient = fraction1.Divide(fraction2);
                                Console.WriteLine("Частное " + quotient);
                                goto invalid_data;
                            }
                        case 5: // compare
                            {
                                bool equal = fraction1.Compare(fraction2);
                                Console.WriteLine("Равно ли " + equal);
                                goto invalid_data;
                            }
                        case 6:
                            {
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(" \n Данной функции не существует. Попробуйте выбрать другую");
                                goto invalid_data;
                            }
                    }
                    break;
            }

        }
    }



    // Есть диапазон: first - поле, левая граница диапазона. second - правая граница. Пара чисел - полуоткрытый интервел [first, second). Реализовать метод имя - проверка в диапазоне ли число
    public class task1
    {
        public static void rangecheck(int left, int right, int num)
        {
            if ((num >= left) && (num < right)) Console.WriteLine("Число лежит в диапазоне");
            else Console.WriteLine("Число НЕ лежит в диапазоне");
        }
    }

    //мама помоги
    class Rational
    {
        private int numerator;// числитель
        private int denominator; // знаменатель

        // Конструктор для инициализации рациональной дроби
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator; // !!!! Ключевое слово this ссылается на текущий экземпляр класса, а также используется в качестве модификатора первого параметра метода расширения. прочекать ещё раз
            this.denominator = denominator;
        }

        // Метод для нахождения наибольшего общего делителя числителя и знаменателя
        private int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Сокращение
        private void Simplify()
        {
            int gcd = FindGCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        // Сложение
        public Rational Add(Rational other)
        {
            int newNumerator = numerator * other.denominator + other.numerator * denominator;
            int newDenominator = denominator * other.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            result.Simplify();
            return result;
        }

        // Вычитание
        public Rational Subtract(Rational other)
        {
            int newNumerator = numerator * other.denominator - other.numerator * denominator;
            int newDenominator = denominator * other.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            result.Simplify();
            return result;
        }

        // Умножение
        public Rational Multiply(Rational other)
        {
            int newNumerator = numerator * other.numerator;
            int newDenominator = denominator * other.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            result.Simplify();
            return result;
        }

        // Деление
        public Rational Divide(Rational other)
        {
            int newNumerator = numerator * other.denominator;
            int newDenominator = denominator * other.numerator;
            Rational result = new Rational(newNumerator, newDenominator);
            result.Simplify();
            return result;
        }

        // Сравнение
        public bool Compare(Rational other)
        {
            Simplify();
            other.Simplify();
            return numerator == other.numerator && denominator == other.denominator;
        }

        // Норм вывод 
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }

}