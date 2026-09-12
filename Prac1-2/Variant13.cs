
static class Variant13
{
    public static void Run()
    {
        Console.WriteLine("Введите расход филамента, г (вещественное через запятую):");
        double rashod = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите цену катушки массой 1 кг, руб (вещественное через запятую):");
        double cenaKatushki = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите время печати, мин (вещественное через запятую):");
        double vremya = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите стоимость машиночаса, руб (вещественное через запятую):");
        double mashinochas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите мощность принтера, Вт (вещественное через запятую):");
        double moshnost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите тариф на электроэнергию, руб за кВт*ч (вещественное через запятую):");
        double tarif = Convert.ToDouble(Console.ReadLine());

        double material = rashod / 1000 * cenaKatushki;

        double mashina = vremya / 60 * mashinochas;

        double elektr = moshnost / 1000 * (vremya / 60) * tarif;

        double sebestoim = material + mashina + elektr;

        double dolaMat = material / sebestoim * 100;

        Console.WriteLine($"Материал: {material:F2} руб");
        Console.WriteLine($"Машина: {mashina:F2} руб");
        Console.WriteLine($"Электроэнергия: {elektr:F2} руб");
        Console.WriteLine($"Итого: {sebestoim:F2} руб");
        Console.WriteLine($"Доля материала: {dolaMat:F1} %");
    }
}