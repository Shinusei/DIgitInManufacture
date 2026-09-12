
static class Variant23
{
    public static void Run()
    {
        Console.WriteLine("Введите годовую программу, шт (целое):");
        int program = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите штучное время, сотые доли минуты (целое):");
        int shtuchnoe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите годовой фонд времени одного станка, ч (целое):");
        int fond = Convert.ToInt32(Console.ReadLine());

        double tPotr = (double)program * shtuchnoe / 100 / 60;

        int fondSto = fond * 60 * 100;

        int stanki = (program * shtuchnoe + fondSto - 1) / fondSto;

        double zagruzka = tPotr / (stanki * fond) * 100;

        Console.WriteLine($"Потребное время: {tPotr:F2} ч");
        Console.WriteLine($"Число станков: {stanki}");
        Console.WriteLine($"Загрузка: {zagruzka:F2} %");
    }
}