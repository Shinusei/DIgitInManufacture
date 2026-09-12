
static class Variant9
{
    public static void Run()
    {
        Console.WriteLine("Введите массу детали с поддержками m, г (вещественное через запятую):");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите плотность материала ro, г/см3 (вещественное через запятую):");
        double ro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите диаметр прутка d, мм (вещественное через запятую):");
        double d = Convert.ToDouble(Console.ReadLine());

        double V = m / ro;

        double S = Math.PI * (d / 2.0) * (d / 2.0);

        double lmm = V * 1000 / S;

        double lm = lmm / 1000;

        int meters = (int)(lmm / 1000);
        int centimeters = (int)(lmm % 1000) / 10;

        Console.WriteLine($"Объем материала: {V:F2} см3");
        Console.WriteLine($"Длина прутка: {lm:F2} м");
        Console.WriteLine($"То же: {meters} м {centimeters} см");
    }
}