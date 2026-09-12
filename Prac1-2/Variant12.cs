
static class Variant12
{
    public static void Run()
    {
        Console.WriteLine("Введите размер стола X, мм (целое):");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер стола Y, мм (целое):");
        int Y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите габарит детали a, мм (целое):");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите габарит детали b, мм (целое):");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите зазор между деталями g, мм (целое):");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите отступ от края стола m, мм (целое):");
        int m = Convert.ToInt32(Console.ReadLine());

        int poX = (X - 2 * m + g) / (a + g);

        int poY = (Y - 2 * m + g) / (b + g);

        int vsego = poX * poY;

        double zanyato = (double)(vsego * a * b) / (X * Y) * 100;

        Console.WriteLine($"По X помещается: {poX} дет.");
        Console.WriteLine($"По Y помещается: {poY} дет.");
        Console.WriteLine($"Всего за запуск: {vsego} дет.");
        Console.WriteLine($"Занято площади: {zanyato:F2} %");
    }
}