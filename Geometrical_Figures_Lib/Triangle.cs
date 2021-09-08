using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrical_Figures_Lib
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        double maxSide, _2Side, _3side;

        public void TriangleSidesCalculation(double a, double b, double c)
        {
            double k = (a + b + c) / 2;

            double area = Math.Sqrt(k * (k - a) * (k - b) * (k - c));
            Console.Write("Площадь треугольника равна {0}", area);
                        
            if (a > b && a > c)
            {
                maxSide = a;
                _2Side = b;
                _3side = c;
            }
            else if (a > b && a < c)
            {
                maxSide = c;
                _2Side = b;
                _3side = a;
            }
            else if (b > c)
            {
                maxSide = b;
                _2Side = c;
                _3side = a;
            }
            else if (b < c)
            {
                maxSide = c;
                _2Side = b;
                _3side = a;
            }

            if (Math.Sqrt(maxSide) == Math.Sqrt(_2Side) + Math.Sqrt(_3side))
                Console.Write("Треугольник является прямоугольным");           
            else 
                 Console.WriteLine("Треугольник не является прямоугольным");
        }

    }
}
