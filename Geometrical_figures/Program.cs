using System;
using Geometrical_Figures_Lib;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите радиус площади = ");
            bool result = double.TryParse(Console.ReadLine(), out double radius);
            if (result)
            {              
                Circle circle = new Circle();
                circle.CircleRadiusCalculation(radius);                         
            }



            Console.WriteLine("Введите стороны треугольника:");
            double side1, side2, side3;
            Console.Write("side1 = ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("side2 = ");
            side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("side3 = ");
            side3 = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle();
            triangle.TriangleSidesCalculation(side1, side2, side3);                
            
        }

    }
}