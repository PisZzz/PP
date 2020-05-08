using System;

namespace Pr3._1
{
    class Program
    {
        static double max(double a, double b)
        {
            return (a > b) ? a : b;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                double z = max(x, (2 * y - x)) + max(5 * x + 3 * y, y);
                Console.WriteLine("z = " + z);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
