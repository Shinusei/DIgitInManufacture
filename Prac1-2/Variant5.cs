
static class Variant5
{
    public static void Run()
    {
        Console.WriteLine("Введите продолжительность смены, ч (целое):");
        int shiftHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длительность первого перерыва, мин (целое):");
        int break1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длительность второго перерыва, мин (целое):");
        int break2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сменную программу, шт (целое):");
        int program = Convert.ToInt32(Console.ReadLine());

        int fond = shiftHours * 3600 - (break1 + break2) * 60;

        int takt = fond / program;

        int taktMin = takt / 60;
        int taktSec = takt % 60;

        int ostatok = fond % program;

        Console.WriteLine($"Полезный фонд времени: {fond} с");
        Console.WriteLine($"Такт: {takt} с = {taktMin} мин {taktSec} с");
        Console.WriteLine($"Нераспределенный остаток: {ostatok} с");
    }
}