using System;

namespace Pr1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                Console.WriteLine("Введите число для проверки на нечётность : ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x % 2 != 0)
                    Console.WriteLine("Число нечётное");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
