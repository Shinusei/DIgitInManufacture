
static class Variant6
{
    public static void Run()
    {
        Console.WriteLine("Введите период стойкости пластины T, мин (целое):");
        int T = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите машинное время на деталь t, сотые доли минуты (целое):");
        int t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер партии N, шт (целое):");
        int N = Convert.ToInt32(Console.ReadLine());

        int stoSto = T * 100;

        int naPlastinu = stoSto / t;

        int plastin = (N + naPlastinu - 1) / naPlastinu;

        int zapas = plastin * naPlastinu - N;

        Console.WriteLine($"Деталей на одну пластину: {naPlastinu}");
        Console.WriteLine($"Пластин на партию: {plastin}");
        Console.WriteLine($"Запас у последней пластины: {zapas} дет.");
    }
}