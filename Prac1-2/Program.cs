Console.WriteLine("Введите номер варианта (1-25):");
int variant = Convert.ToInt32(Console.ReadLine());

switch (variant)
{
    case 1: Variant1.Run(); break;
    case 2: Variant2.Run(); break;
    case 3: Variant3.Run(); break;
    case 4: Variant4.Run(); break;
    case 5: Variant5.Run(); break;
    case 6: Variant6.Run(); break;
    case 7: Variant7.Run(); break;
    case 8: Variant8.Run(); break;
    case 9: Variant9.Run(); break;
    case 10: Variant10.Run(); break;
    case 11: Variant11.Run(); break;
    case 12: Variant12.Run(); break;
    case 13: Variant13.Run(); break;
    case 14: Variant14.Run(); break;
    case 15: Variant15.Run(); break;
    case 16: Variant16.Run(); break;
    case 17: Variant17.Run(); break;
    case 18: Variant18.Run(); break;
    case 19: Variant19.Run(); break;
    case 20: Variant20.Run(); break;
    case 21: Variant21.Run(); break;
    case 22: Variant22.Run(); break;
    case 23: Variant23.Run(); break;
    case 24: Variant24.Run(); break;
    case 25: Variant25.Run(); break;
    default: Console.WriteLine("Варианта с таким номером нет."); break;
}