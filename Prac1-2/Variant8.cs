
static class Variant8
{
    public static void Run()
    {
        Console.WriteLine("Введите высоту детали H, сотые доли мм (целое):");
        int H = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите высоту слоя h, сотые доли мм (целое):");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите среднее время печати одного слоя t, с (целое):");
        int t = Convert.ToInt32(Console.ReadLine());

        int sloi = (H + h - 1) / h;

        double lastHeight = (double)(H - (sloi - 1) * h) / 100.0;

        int totalSec = sloi * t;

        int hours = totalSec / 3600;
        int minutes = totalSec % 3600 / 60;
        int seconds = totalSec % 60;

        Console.WriteLine($"Число слоев: {sloi}");
        Console.WriteLine($"Высота последнего слоя: {lastHeight:F2} мм");
        Console.WriteLine($"Время печати: {hours} ч {minutes} мин {seconds} с");
    }
}