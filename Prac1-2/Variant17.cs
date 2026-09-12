
static class Variant17
{
    public static void Run()
    {
        const double mmPerInch = 25.4;

        Console.WriteLine("Введите целую часть дюймов a (целое):");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите числитель дроби b (целое):");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите знаменатель дроби c (целое):");
        int c = Convert.ToInt32(Console.ReadLine());

        double lmm = (a + (double)b / c) * mmPerInch;

        double lRiad = (int)(lmm * 2) / 2.0;

        double raznica = (lmm - lRiad) * 1000;

        Console.WriteLine($"Размер в мм: {lmm:F3} мм");
        Console.WriteLine($"Из ряда (шаг 0,5): {lRiad:F1} мм");
        Console.WriteLine($"Разница: {raznica:F0} мкм");
    }
}