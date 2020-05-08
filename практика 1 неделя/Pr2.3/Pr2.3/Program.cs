using System;

namespace Pr2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int i = 0, a = 0;
            for (i = 0, a = 10; i <= n; i++, a++)
            {
                Console.WriteLine(a + " " + (a + 0.4));
            }
            Console.WriteLine();
            i = 0;
            a = 10;
            while (i <= n)
            {
                Console.WriteLine(a + " " + (a + 0.4));
                i++;
                a++;
            }
            Console.WriteLine();
            i = 0;
            a = 10;
            do
            {
                Console.WriteLine(a + " " + (a + 0.4));
                i++;
                a++;
            } while (i <= n);
        }
    }
}
