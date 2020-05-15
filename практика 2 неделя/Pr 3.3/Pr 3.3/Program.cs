using  System;

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
                int[][] arr = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new int[n];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i][j] = rnd.Next(1, 10);
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                int a = 0, b = n - 1;
                int summ = 0;
                while (a != n)
                {
                    summ += arr[b--][a++];
                }
                Console.WriteLine(summ);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }

}
