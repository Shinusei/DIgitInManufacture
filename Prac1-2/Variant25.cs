
static class Variant25
{
    public static void Run()
    {
        Console.WriteLine("Введите размер партии, шт (целое):");
        int partiya = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите массу одной детали, г (целое):");
        int massaDetali = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите грузоподъемность тележки, кг (целое):");
        int gruz = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите массу тары, кг (целое):");
        int tara = Convert.ToInt32(Console.ReadLine());

        int polezG = (gruz - tara) * 1000;

        int naTelezhku = polezG / massaDetali;

        int reisy = (partiya + naTelezhku - 1) / naTelezhku;

        int vPoslednem = partiya % naTelezhku;

        double nedogruz = (naTelezhku - vPoslednem) * massaDetali / 1000.0;

        Console.WriteLine($"На тележку помещается: {naTelezhku} дет.");
        Console.WriteLine($"Рейсов потребуется: {reisy}");
        Console.WriteLine($"В последнем рейсе: {vPoslednem} дет.");
        Console.WriteLine($"Недогруз последнего рейса: {nedogruz:F2} кг");
    }
}