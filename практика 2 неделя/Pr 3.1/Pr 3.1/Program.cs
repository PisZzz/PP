using System;

namespace _2
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                int n, a, b;
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine()) - 1;

                int[] mass = new int[n];
                Random rnd = new Random();

                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(100);
                    Console.Write(mass[i] + " ");
                }


                for (int i = a; i <= b; i++)
                {
                    mass[i] = 0;
                }
                Console.WriteLine();
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine("\n");




                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("m = ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("ax = ");
                int ax = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("ay = ");
                int ay = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.Write("bx = ");
                int bx = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("by = ");
                int by = Convert.ToInt32(Console.ReadLine()) - 1;

                int[,] arr = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = rnd.Next(1, 10);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (int i = ay; i <= by; i++)
                {
                    for (int j = ax; j <= bx; j++)
                    {
                        arr[i, j] = 0;
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }

}
