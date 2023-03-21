using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        private double a, b, c;
        private double x1, x2;

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private double CalculateDiscriminant()
        {
            return b * b - 4 * a * c;
        }

        public void CalculateRoots()
        {
            double discriminant = CalculateDiscriminant();

            if (discriminant < 0)
            {
                Console.WriteLine("Нет корней");
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
            }
        }

        public double GetX1()
        {
            return x1;
        }

        public double GetX2()
        {
            return x2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new QuadraticEquation(1, -5, 6);
            Console.Write("Уравнение: ");
            Console.WriteLine("x^2 - 5x + 6 = 0");
            Console.Write("Корни: ");
            equation.CalculateRoots();
        }
    }
}