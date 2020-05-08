using System;

namespace Pr2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Введите номер месяца: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите день месяца: ");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Осталось " + (30 - a));
                        break;
                    case 2:
                        Console.WriteLine("Если високосный год. Осталось " + (29 - a));
                        Console.WriteLine("Если не високосный год. Осталось " + (28 - a));
                        break;
                    case 3:
                        Console.WriteLine("Осталось " + (31 - a));
                        break;
                    case 4:
                        Console.WriteLine("Осталось " + (30 - a));
                        break;
                    case 5:
                        Console.WriteLine("Осталось " + (31 - a));
                        break;
                    case 6:
                        Console.WriteLine("Осталось " + (30 - a));
                        break;
                    case 7:
                        Console.WriteLine("Осталось " + (31 - a));
                        break;
                    case 8:
                        Console.WriteLine("Осталось " + (31 - a));
                        break;
                    case 9:
                        Console.WriteLine("Осталось " + (30 - a));
                        break;
                    case 10:
                        Console.WriteLine("Осталось " + (31 - a));
                        break;
                    case 11:
                        Console.WriteLine("Осталось " + (30 - a));
                        break;
                    case 12:
                        Console.WriteLine("Осталось " + (31 - a));
                        break;
                    default:
                        Console.WriteLine("нет такого месяца");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
