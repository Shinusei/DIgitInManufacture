
static class Variant19
{
    public static void Run()
    {
        Console.WriteLine("Введите массу заготовки, г (целое):");
        int mZag = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите массу готовой детали, г (целое):");
        int mDet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер партии, шт (целое):");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цену материала, руб за кг (вещественное через запятую):");
        double cena = Convert.ToDouble(Console.ReadLine());

        double kim = (double)mDet / mZag * 100;

        double mOthod = (mZag - mDet) * N / 1000.0;

        double stoim = mOthod * cena;

        Console.WriteLine($"КИМ: {kim:F2} %");
        Console.WriteLine($"Отходы на партию: {mOthod:F1} кг");
        Console.WriteLine($"Стоимость отходов: {stoim:F2} руб");
    }
}