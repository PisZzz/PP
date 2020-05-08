using System;

namespace Pr3._2
{
    class Program
    {

        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < 3)
                y = Math.Sin(x);
            else if (3 <= Math.Abs(x) && Math.Abs(x) < 9)
            {
                y = Math.Sqrt((x * x) + 1) / Math.Sqrt((x * x) + 5);
            }
            else
                y = Math.Sqrt((x * x) + 1) - Math.Sqrt((x * x) + 5);
            return y;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                {
                    Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
