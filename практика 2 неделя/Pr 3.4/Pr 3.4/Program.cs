using System;
using System.Numerics;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                Console.Write("n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("m = ");
                int m = Convert.ToInt32(Console.ReadLine());

                int[] x = new int[n];
                for (int i = 0; i < n; i++)
                {
                    x[i] = rnd.Next(1, 10);
                    Console.Write(x[i] + " ");
                }
                Console.WriteLine();
                int[][] arr = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new int[m];
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i][j] = rnd.Next(1, 10);
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i % 2 != 0)
                        {
                            arr[j][i] = x[j];
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(arr[i][j] + " ");
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
