
static class Variant4
{
    public static void Run()
    {
        Console.WriteLine("Введите длину обработки L, мм (вещественное через запятую):");
        double L = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число проходов i (целое):");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите обороты n, об/мин (вещественное через запятую):");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите подачу s, мм/об (вещественное через запятую):");
        double s = Convert.ToDouble(Console.ReadLine());

        double tMin = L * i / (n * s);

        int minutes = (int)tMin;

        int seconds = (int)((tMin - minutes) * 60 + 0.5);

        Console.WriteLine($"Машинное время: {tMin:F3} мин");
        Console.WriteLine($"То же: {minutes} мин {seconds} с");
    }
}