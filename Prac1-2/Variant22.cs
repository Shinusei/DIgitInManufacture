
static class Variant22
{
    public static void Run()
    {
        Console.WriteLine("Введите годовую программу, шт (целое):");
        int program = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер партии, шт (целое):");
        int partiya = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите время одной переналадки, мин (целое):");
        int perenaladka = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите годовой фонд времени станка, ч (целое):");
        int fond = Convert.ToInt32(Console.ReadLine());

        int zapuski = (program + partiya - 1) / partiya;

        int timeMin = zapuski * perenaladka;

        int hours = timeMin / 60;
        int minutes = timeMin % 60;

        double dolya = (double)timeMin / (fond * 60) * 100;

        Console.WriteLine($"Запусков за год: {zapuski}");
        Console.WriteLine($"Переналадки: {hours} ч {minutes} мин");
        Console.WriteLine($"Доля фонда: {dolya:F2} %");
    }
}