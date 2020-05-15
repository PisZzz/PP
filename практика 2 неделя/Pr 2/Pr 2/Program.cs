using System;

namespace _2
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (x == -1)
                    throw new Exception();
                else
                    return Math.Pow(Math.E, (((x - 1) * (x - 1)) / x));
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                if (a == 0)
                    throw new Exception("x = 0");
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                if (a > b)
                    throw new Exception("b не может быть больше a");
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                if (h < 1)
                    throw new Exception("h должен быть больше 0");
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
