using System;
using System.IO;
using System.Text;

namespace Pr_3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\123.txt";

            string[] file = File.ReadAllLines(path);
            string buf = file[0];
            int length = file[0].Length;
            for (int i = 0; i < file.Length; i++)
            {
                if (buf.Length < file[i].Length)
                {
                    length = file[i].Length;
                    buf = file[i];
                }
            }
            Console.WriteLine("Самая длинная строка содержит " + length + " символов:\n" + buf);

        }
    }
}
