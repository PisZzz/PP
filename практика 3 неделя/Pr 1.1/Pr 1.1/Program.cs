using System;
using System.Text;

namespace Pr_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Введите строку: ");
                StringBuilder sb = new StringBuilder(Console.ReadLine());
                Console.Write("Введите букву 1 = ");
                char s1 = char.Parse(Console.ReadLine());
                Console.Write("Введите букву 2 = ");
                char s2 = char.Parse(Console.ReadLine());
                int amount1 = 0, amount2 = 0;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == s1)
                        amount1++;
                    if (sb[i] == s2)
                        amount2++;
                }
                if (amount1 > amount2)
                    Console.WriteLine(s1 + " > " + s2);
                else if (amount1 < amount2)
                    Console.WriteLine(s2 + " > " + s1);
                else
                    Console.WriteLine(s2 + " = " + s1);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
