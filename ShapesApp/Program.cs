using ShapesLibrary.Classes;
using ShapesLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace ShapesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(9.0),
                new Circle(3.0),
                new Circle(4.0),
                new Circle(6.0),
                new Triangle(6.0, 5.0, 12.0),
                new Triangle(3.0, 7.0, 6.0),
                new Triangle(5.0, 9.0, 4.0),
                new Triangle(3.0, 6.0, 4.0),
                new Triangle(3.0, 4.0, 5.0)

            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Площадь фигуры: {shape.CalculateArea()}");
                if (shape is Triangle triangle)
                {
                    Console.WriteLine($"Является ли треугольник прямоугольным ? : {Utils.YesNoConverter(triangle.isRightAngled())}");
                }
            }
            Console.ReadKey();
        }
    }
}
