using System;
using System.Text.RegularExpressions;

namespace Pr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите текст");
                string text = Console.ReadLine() + " ";
                Console.WriteLine("Введите длину слова");
                int x = int.Parse(Console.ReadLine());
                Regex r = new Regex(@"\b(\w){" + x + @"}\b");
                Match words = r.Match(text);
                while (words.Success)
                {
                    Console.Write(words + " ");
                    words = words.NextMatch();
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
