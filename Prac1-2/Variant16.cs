
static class Variant16
{
    public static void Run()
    {
        const double mmPerInch = 25.4;

        Console.WriteLine("Введите последний пройденный штрих основной шкалы k, мм (целое):");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер совпавшего штриха нониуса j (целое):");
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цену деления нониуса c, сотые доли мм (целое):");
        int c = Convert.ToInt32(Console.ReadLine());

        double lmm = k + j * c / 100.0;

        double lInch = lmm / mmPerInch;

        Console.WriteLine($"Измеренный размер: {lmm:F2} мм");
        Console.WriteLine($"В дюймах: {lInch:F4} дюйма");
    }
}