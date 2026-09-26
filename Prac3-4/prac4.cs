namespace Prac3_4;

static class prac4
{
    public static void Run()
    {
        int capacity = ReadInt("Вместимость платформы, шт: ");

        if (capacity <= 0)
        {
            Console.WriteLine("Ошибка: вместимость должна быть положительной.");
            return;
        }

        int details = 0;
        int launches = 0;
        int freeSlots = 0;
        int orders = 0;

        while (orders < 20)
        {
            int size = ReadInt("Размер заказа, шт (0 — конец ввода): ");

            if (size == 0)
            {
                break;
            }

            if (size < 0)
            {
                Console.WriteLine("Ошибка: размер заказа должен быть положительным.");
                continue;
            }

            int parts = (size + capacity - 1) / capacity;

            details += size;
            launches += parts;
            freeSlots += parts * capacity - size;
            orders++;
        }

        Console.WriteLine($"Деталей {details}; запусков {launches}; свободных мест {freeSlots}");
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число вне допустимого диапазона.");
            }
        }
    }
}
