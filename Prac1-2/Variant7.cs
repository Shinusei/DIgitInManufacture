
static class Variant7
{
    public static void Run()
    {
        Console.WriteLine("Введите подачу s, мм/об (вещественное через запятую):");
        double s = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите радиус при вершине резца r, мм (вещественное через запятую):");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите требуемую шероховатость Rz, мкм (вещественное через запятую):");
        double rzReq = Convert.ToDouble(Console.ReadLine());

        double rz = s * s / (8 * r) * 1000;

        double prevyshenie = rz / rzReq;

        Console.WriteLine($"Расчетная шероховатость Rz: {rz:F2} мкм");
        Console.WriteLine($"Превышает требуемую: {prevyshenie:F2} раза");
    }
}