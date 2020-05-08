using System;

namespace Pr2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int j = 0; j < 5; j++)
            {
                for (int k = -10; k <= 12; Console.Write(k++ + " ")) ;
                Console.WriteLine();
            }
        }
    }
}
