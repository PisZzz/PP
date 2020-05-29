using System;

namespace Prog_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle(4, 5, 6);
                Console.WriteLine("Вывод");
                triangle.Print();
                Console.WriteLine("\nP = " + triangle.P());
                Console.WriteLine("S = " + triangle.S());
                Console.WriteLine("\nЗаполнение через свойства");
                triangle.A = 7;
                triangle.B = 3;
                triangle.C = 4;
                triangle.Print();
                if (triangle.isTriangle)
                    Console.WriteLine("Треугольник существует");
                else
                    Console.WriteLine("Треугольник не существует");
                Console.WriteLine();
                Console.WriteLine("Обращение по индексу");
                triangle[0] = 17;
                triangle[1] = 18;
                triangle[2] = 19;
                triangle[3] = 100;
                triangle.Print();
                Console.WriteLine("--");
                --triangle;
                triangle.Print();
                Console.WriteLine("++");
                ++triangle;
                triangle.Print();
                int i = 3;
                Console.WriteLine("* "+i);
                triangle *= i;
                triangle.Print();
                Console.WriteLine("Строка\n"+triangle);
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
