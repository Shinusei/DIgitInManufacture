
static class Variant15
{
    public static void Run()
    {
        Console.WriteLine("Введите нижнее отклонение ei, мкм (целое):");
        int ei = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхнее отклонение es, мкм (целое):");
        int es = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число групп k (целое):");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите измеренное отклонение x, мкм (целое):");
        int x = Convert.ToInt32(Console.ReadLine());

        int delta = (es - ei) / k;

        int nomer = (x - ei) / delta + 1;

        int nizh = ei + (nomer - 1) * delta;
        int verh = ei + nomer * delta;

        Console.WriteLine($"Ширина группы: {delta} мкм");
        Console.WriteLine($"Номер группы: {nomer}");
        Console.WriteLine($"Границы группы: от {nizh} до {verh} мкм");
    }
}