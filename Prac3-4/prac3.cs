namespace Prac3_4;

static class prac3
{
    public static void Main()
    {
        int x = ReadInt("Размер платформы по X, мм: ");
        int y = ReadInt("Размер платформы по Y, мм: ");
        int a = ReadInt("Сторона детали, мм: ");

        if (x <= 0 || y <= 0 || a <= 0)
        {
            Console.WriteLine("Ошибка: все значения должны быть положительными.");
            return;
        }

        if (x - 10 < a || y - 10 < a)
        {
            Console.WriteLine("Не помещается");
            return;
        }

        int nx = (x - 5) / (a + 5);
        int ny = (y - 5) / (a + 5);
        int k = nx * ny;
        double percent = 100.0 * k * a * a / (x * y);

        Console.WriteLine($"По X — {nx}, по Y — {ny}, всего {k}");
        Console.WriteLine($"Занято {percent:F2} %");
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
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
}
