
static class Variant11
{
    public static void Run()
    {
        Console.WriteLine("Введите номинальный размер детали L, мм (вещественное через запятую):");
        double L = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите усадку материала k, % (вещественное через запятую):");
        double k = Convert.ToDouble(Console.ReadLine());

        double lModel = L / (1 - k / 100);

        double kompens = (lModel - L) * 1000;

        Console.WriteLine($"Размер для модели: {lModel:F3} мм");
        Console.WriteLine($"Компенсация: {kompens:F1} мкм");
    }
}