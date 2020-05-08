using System;

namespace Pr2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату x = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите координату y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (x * x + y * y < 100 && x * x + y * y > 25)
                    Console.WriteLine("Да");
                else if (x * x + y * y > 100 || x * x + y * y < 25)
                    Console.WriteLine("Нет");
                else
                    Console.WriteLine("На границе");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
