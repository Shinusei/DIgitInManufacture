
static class Variant21
{
    public static void Run()
    {
        Console.WriteLine("Введите продолжительность смены, мин (целое):");
        int smena = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите подготовительно-заключительное время, мин (целое):");
        int tpz = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите штучное время, сотые доли минуты (целое):");
        int shtuchnoe = Convert.ToInt32(Console.ReadLine());

        int rabochSto = (smena - tpz) * 100;

        int detali = rabochSto / shtuchnoe;

        int ostatokSto = rabochSto % shtuchnoe;

        double ostatokMin = ostatokSto / 100.0;

        int ostatMin = ostatokSto / 100;
        int ostatSec = (int)((ostatokSto % 100) * 0.6 + 0.5);

        Console.WriteLine($"Деталей за смену: {detali}");
        Console.WriteLine($"Остаток: {ostatokMin:F2} мин");
        Console.WriteLine($"То же: {ostatMin} мин {ostatSec} с");
    }
}