using System;

namespace Pr1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                double a, b, c, d;
                Console.WriteLine("Введите координату a : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату b : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату c : ");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату d : ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nРасстояние между точками а, b = " + Math.Abs(a - b));
                Console.WriteLine("\nРасстояние между точками c, d = " + Math.Abs(c - d));
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
