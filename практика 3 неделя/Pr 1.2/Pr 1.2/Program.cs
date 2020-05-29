using System;
using System.Text;

namespace Pr_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку");
                string s = Console.ReadLine();
                string[] words = s.Split(' ');
                foreach (string word in words)
                    if (word[0] == word.ToLower()[0])
                        Console.Write(word + " ");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
