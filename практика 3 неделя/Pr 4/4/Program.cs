using System;
using System.IO;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!Directory.Exists("c:\\temp"))
                {
                    Directory.CreateDirectory("c:\\temp");
                }
                Directory.CreateDirectory("c:\\temp\\K1");
                Directory.CreateDirectory("c:\\temp\\K2");
                StreamWriter s = new StreamWriter("c:\\temp\\K1\\t1.txt");
                s.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                s.Close();
                s = new StreamWriter("c:\\temp\\K1\\t2.txt");
                s.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                s.Close();
                s = new StreamWriter("c:\\temp\\K2\\t3.txt");
                StreamReader sr = new StreamReader("c:\\temp\\K1\\t1.txt");
                s.WriteLine(sr.ReadToEnd());
                sr.Close();
                sr = new StreamReader("c:\\temp\\K1\\t2.txt");
                s.WriteLine(sr.ReadToEnd());
                sr.Close();
                s.Close();
                File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
                File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
                Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
                Directory.Delete("c:\\temp\\K1", true);
                DirectoryInfo dinf = new DirectoryInfo("c:\\temp\\ALL");
                FileInfo[] finf = dinf.GetFiles();
                foreach (FileInfo f in finf)
                {
                    Console.WriteLine(f.FullName.ToString() + f.Attributes.ToString());
                }
            }
            catch
            {
                Console.WriteLine("Ошибка. Возможно эти папки уже есть");
            }
        }
    }
}
