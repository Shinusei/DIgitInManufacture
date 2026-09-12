
static class Variant10
{
    public static void Run()
    {
        Console.WriteLine("Введите массу катушки, г (целое):");
        int katushka = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите массу детали с поддержками, сотые доли грамма (целое):");
        int detail = Convert.ToInt32(Console.ReadLine());

        int katushkaSto = katushka * 100;

        int detali = katushkaSto / detail;

        int ostatokSto = katushkaSto % detail;

        double ostatok = ostatokSto / 100.0;

        double dolya = ostatokSto / (double)katushkaSto * 100;

        Console.WriteLine($"Деталей из катушки: {detali}");
        Console.WriteLine($"Остаток: {ostatok:F2} г");
        Console.WriteLine($"Доля остатка: {dolya:F2} %");
    }
}