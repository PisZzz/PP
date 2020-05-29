using System;
using System.IO;
using System.Text;

namespace Pr_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\123.txt";
                string buffer = "";
                int n = int.Parse(Console.ReadLine());
                double x = 0, j = 1;
                for (int i = 0; i < n; i++)
                {
                    x = 1 / j++;
                    buffer = buffer + Convert.ToString(x) + ";";
                }
                File.WriteAllText(path, buffer);
                string[] file = File.ReadAllLines(path);
                string[] buf = file[0].Split(';');
                for (int i = 0; i < n; i++)
                {
                    if(i % 3 == 0)
                        Console.WriteLine(buf[i]);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
