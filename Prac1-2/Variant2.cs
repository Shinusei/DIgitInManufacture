
static class Variant2
{
    public static void Run()
    {
        const double pi = Math.PI;

        Console.WriteLine("Введите диаметр обработки D, мм (вещественное через запятую):");
        double D = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите заданную скорость резания v, м/мин (вещественное через запятую):");
        double v = Convert.ToDouble(Console.ReadLine());

        double nRasch = 1000 * v / (pi * D);

        int nFakt = (int)(nRasch / 10) * 10;

        double vFakt = pi * D * nFakt / 1000;

        double poterya = (v - vFakt) / v * 100;

        Console.WriteLine($"Расчетные обороты: {nRasch:F1} об/мин");
        Console.WriteLine($"Фактические обороты: {nFakt} об/мин");
        Console.WriteLine($"Фактическая скорость: {vFakt:F2} м/мин");
        Console.WriteLine($"Потеря скорости: {poterya:F2} %");
    }
}