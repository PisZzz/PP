namespace Prog_3_WF
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
}
