using System;

namespace _2
{
    class Program
    {
        static double n(int x)
        {
            return x == 1 ? 5 : n(x - 1) * (x * x + x + 1);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("n=");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine(n(n1));
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
