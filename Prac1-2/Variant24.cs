
static class Variant24
{
    public static void Run()
    {
        Console.WriteLine("Введите массу заготовки, г (целое):");
        int massa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цену материала, руб за кг (вещественное через запятую):");
        double cenaMat = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите штучное время, сотые доли минуты (целое):");
        int shtuchnoe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите стоимость станко-часа, руб (вещественное через запятую):");
        double stankoChas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите часовую ставку рабочего, руб (вещественное через запятую):");
        double stavka = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите накладные расходы, % от зарплаты (вещественное через запятую):");
        double nakladnye = Convert.ToDouble(Console.ReadLine());

        double cMat = massa / 1000.0 * cenaMat;

        double tCh = shtuchnoe / 100.0 / 60;

        double cStan = tCh * stankoChas;

        double czp = tCh * stavka;

        double cNakl = czp * nakladnye / 100;

        double cItog = cMat + cStan + czp + cNakl;

        double dolaMat = cMat / cItog * 100;

        Console.WriteLine($"Материал: {cMat:F2} руб");
        Console.WriteLine($"Станок: {cStan:F2} руб");
        Console.WriteLine($"Зарплата: {czp:F2} руб");
        Console.WriteLine($"Накладные: {cNakl:F2} руб");
        Console.WriteLine($"Итого: {cItog:F2} руб");
        Console.WriteLine($"Доля материала: {dolaMat:F2} %");
    }
}