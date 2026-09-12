
static class Variant18
{
    public static void Run()
    {
        Console.WriteLine("Введите номинальный размер, мм (вещественное через запятую):");
        double lNom = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите измеренный размер, мм (вещественное через запятую):");
        double lIzm = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите допуск IT, мкм (целое):");
        int it = Convert.ToInt32(Console.ReadLine());

        double delta = (lIzm - lNom) * 1000;

        double pogresh = (lIzm - lNom) / lNom * 100;

        double dolya = delta / it * 100;

        Console.WriteLine($"Отклонение: {delta:F1} мкм");
        Console.WriteLine($"Относительная погрешность: {pogresh:F4} %");
        Console.WriteLine($"Доля допуска: {dolya:F1} %");
    }
}