
static class Variant14
{
    public static void Run()
    {
        Console.WriteLine("Введите номинальный размер D, мм (вещественное через запятую):");
        double D = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите верхнее отклонение es, мкм (целое, может быть отрицательным):");
        int es = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижнее отклонение ei, мкм (целое, может быть отрицательным):");
        int ei = Convert.ToInt32(Console.ReadLine());

        double dMax = D + es / 1000.0;

        double dMin = D + ei / 1000.0;

        int dopusk = es - ei;

        Console.WriteLine($"Dmax: {dMax:F3} мм");
        Console.WriteLine($"Dmin: {dMin:F3} мм");
        Console.WriteLine($"Допуск: {dopusk} мкм");
    }
}