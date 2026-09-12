
static class Variant3
{
    public static void Run()
    {
        Console.WriteLine("Введите припуск на сторону h, сотые доли мм (целое):");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите максимальную глубину резания t, сотые доли мм (целое):");
        int t = Convert.ToInt32(Console.ReadLine());

        int prohody = (h + t - 1) / t;

        double lastDepth = (double)(h - (prohody - 1) * t) / 100.0;

        Console.WriteLine($"Число проходов: {prohody}");
        Console.WriteLine($"Глубина последнего прохода: {lastDepth:F2} мм");
    }
}