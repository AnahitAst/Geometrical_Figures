using System;

namespace Geometrical_Figures_Lib
{
    public class Circle
    {
        public double radius;            

        public void CircleRadiusCalculation(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);            
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);           
        }

    }
}
