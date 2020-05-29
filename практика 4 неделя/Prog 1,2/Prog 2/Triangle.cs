using System;
using System.Collections.Generic;
using System.Text;

namespace Prog_2
{
    class Triangle
    {
        public int a, b, c;

        public int A
        {
            set
            {
                a = value;
            }
            get { return a; }
        }
        public int B
        {
            set
            {
                b = value;
            }
            get { return b; }
        }
        public int C
        {
            set
            {
                c = value;
            }
            get { return c; }
        }
        public bool isTriangle
        {
            get
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Print()
        {
            Console.WriteLine("a = " + a + "\n" + "b = " + b + "\n" + "c = " + c);
        }
        public double P()
        {
            return a + b + c;
        }
        public double S()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return a;
                else if (index == 1)
                    return b;
                else if (index == 2)
                    return c;
                else
                    throw new Exception("Ошибка, индекс долженбыть только 0,1 или 2");
            }
            set
            {
                if (index == 0)
                    a = value;
                else if (index == 1)
                    b = value;
                else if (index == 2)
                    c = value;
                else
                    throw new Exception("Ошибка, индекс должен быть только 0,1 или 2");
            }
        }


        public static Triangle operator ++(Triangle triangle)
        {
            return new Triangle(++triangle.a, ++triangle.b, ++triangle.c);
        }
        public static Triangle operator --(Triangle triangle)
        {
            return new Triangle(--triangle.a, --triangle.b, --triangle.c);
        }
        public static Triangle operator *(Triangle triangle, int skal)
        {
            return new Triangle(triangle.a * skal, triangle.b * skal, triangle.c * skal);
        }
        public override string ToString()
        {
            return "Стороны: " + "a = " + A + " b = " + B + " c = " + C;
        }


        public static bool operator true(Triangle t)
        {
            return t.isTriangle;
        }
        public static bool operator false(Triangle t)
        {
            return t.isTriangle;
        }
    }
}
