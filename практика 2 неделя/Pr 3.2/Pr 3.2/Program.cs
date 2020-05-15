using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());

                int[] mass = new int[n];
                int max = mass[0];
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                    if (max < mass[i])
                        max = mass[i];
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == max)
                        mass[i] = 0;
                    Console.Write(mass[i] + " ");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }

}
