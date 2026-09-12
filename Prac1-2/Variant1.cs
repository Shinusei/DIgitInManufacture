
static class Variant1
{
    public static void Run()
    {
        Console.WriteLine("Введите длину прутка L, мм (целое):");
        int L = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину заготовки l, мм (целое):");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ширину реза b, мм (целое):");
        int b = Convert.ToInt32(Console.ReadLine());

        int N = (L + b) / (l + b);

        int ostatok = L - N * l - (N - 1) * b;

        double kim = (double)N * l / L * 100;

        Console.WriteLine($"Заготовок выйдет: {N} шт");
        Console.WriteLine($"Остаток: {ostatok} мм");
        Console.WriteLine($"КИМ: {kim:F2} %");
    }
}