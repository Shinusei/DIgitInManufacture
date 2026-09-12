
static class Variant20
{
    public static void Run()
    {
        Console.WriteLine("Введите размер партии, шт (целое):");
        int partiya = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вместимость ящика, шт (целое):");
        int vmestimost = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число ящиков на паллете (целое):");
        int naPallete = Convert.ToInt32(Console.ReadLine());

        int iashiki = (partiya + vmestimost - 1) / vmestimost;

        int vPoslednem = partiya % vmestimost;

        int pallet = iashiki / naPallete;
        int sverh = iashiki % naPallete;

        Console.WriteLine($"Ящиков потребуется: {iashiki}");
        Console.WriteLine($"В последнем ящике: {vPoslednem} дет.");
        Console.WriteLine($"Полных паллет: {pallet}");
        Console.WriteLine($"Сверх полных паллет: {sverh} ящ.");
    }
}