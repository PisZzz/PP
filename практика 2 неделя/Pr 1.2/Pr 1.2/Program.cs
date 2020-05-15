using System;

namespace _12
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("число = ");
                double q = double.Parse(Console.ReadLine());
                Console.Write("знаменатель = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("n = ");
                int n = int.Parse(Console.ReadLine());
                double fn = q;
                double sum = 0;
                sum = F(q, b, n, ref fn);

                Console.WriteLine("fn = " + fn);
                Console.WriteLine("sum = " + sum);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }

        static double F(double q, double b, int n, ref double fn)
        {
            if (n == 0) return 0;
            if (n == 1) return q;
            fn *= b;
            return fn + F(q, b, --n, ref fn);
        }
    }
}