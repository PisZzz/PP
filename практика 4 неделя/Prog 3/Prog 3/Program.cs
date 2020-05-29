using System;

namespace Prog_3
{
    abstract class Function
    {
        public abstract double Count(double x);
    }

    class Line : Function
    {
        public double a;
        public double b;

        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Count(double x)
        {
            return a * x + b;
        }
    }

    class Kub : Function
    {
        public double a;
        public double b;
        public double c;

        public Kub(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Count(double x)
        {
            return a * x * x + b * x + c;
        }
    }

    class Hyperbola : Function
    {
        public double a;

        public Hyperbola(double a)
        {
            this.a = a;
        }

        public override double Count(double x)
        {
            return a / x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Function[] func = new Function[3];
            func[0] = new Line(2, 3);
            func[1] = new Kub(2, 3, 4);
            func[2] = new Hyperbola(3);
            double x = 3.6;
            foreach (Function f in func)
                Console.WriteLine("значение функции {0} для x = {1} равно {2}", f.GetType(), x, f.Count(x));
        }
    }
}

