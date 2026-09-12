using System;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Калькулятор (вариант 8)");
            Console.WriteLine("1. Сложение двух чисел");
            Console.WriteLine("2. Перевод числа из десятичной в двоичную систему");
            Console.WriteLine("3. Вычисление длины окружности по радиусу");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите операцию: ");

            int choice = ReadInt();

            switch (choice)
            {
                case 1: SumDemo(); break;
                case 2: DecimalToBinaryDemo(); break;
                case 3: CircumferenceDemo(); break;
                case 0: exit = true; break;
                default: Console.WriteLine("Ошибка: такого пункта меню нет."); break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Работа программы завершена.");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static double Sum(double a, double b)
    {
        return a + b;
    }

    static void SumDemo()
    {
        Console.WriteLine("--- Сложение двух чисел ---");
        Console.WriteLine("Выберите тип чисел: 1 - целые, 2 - вещественные: ");
        int type = ReadInt();

        switch (type)
        {
            case 1:
                int a = ReadInt("Первое слагаемое (целое): ");
                int b = ReadInt("Второе слагаемое (целое): ");
                Console.WriteLine($"{a} + {b} = {Sum(a, b)}");
                break;
            case 2:
                double x = ReadDouble("Первое слагаемое (вещественное): ");
                double y = ReadDouble("Второе слагаемое (вещественное): ");
                Console.WriteLine($"{x} + {y} = {Sum(x, y):F2}");
                break;
            default:
                Console.WriteLine("Ошибка: выберите 1 или 2.");
                break;
        }
    }

    static string DecimalToBinary(int n)
    {
        if (n == 0)
        {
            return "0";
        }

        string digits = "";
        int value = n;

        while (value > 0)
        {
            digits += value % 2;
            value /= 2;
        }

        char[] chars = digits.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static void DecimalToBinaryDemo()
    {
        Console.WriteLine("--- Перевод из десятичной в двоичную ---");
        int n = ReadInt("Введите неотрицательное целое число: ");

        if (n < 0)
        {
            Console.WriteLine("Ошибка: отрицательные числа не поддерживаются.");
        }
        else
        {
            Console.WriteLine($"{n} (10) = {DecimalToBinary(n)} (2)");
        }
    }

    static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    static int ReadInt()
    {
        while (true)
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число вне допустимого диапазона.");
            }
        }
    }

    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        return ReadInt();
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите число (дробную часть через запятую).");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число вне допустимого диапазона.");
            }
        }
    }

    static void CircumferenceDemo()
    {
        Console.WriteLine("--- Длина окружности ---");
        double radius = ReadDouble("Введите радиус окружности, мм: ");

        if (radius < 0)
        {
            Console.WriteLine("Ошибка: радиус не может быть отрицательным.");
        }
        else
        {
            Console.WriteLine($"Длина окружности: {Circumference(radius):F2} мм");
        }
    }
}