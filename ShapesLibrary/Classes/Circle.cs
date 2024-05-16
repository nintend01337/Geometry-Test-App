using System;
using ShapesLibrary.Interfaces;

namespace ShapesLibrary.Classes
{
    public class Circle : IShape
    {
        private double _radius {get;}

        public Circle(double radius)
        {
            _radius = radius;
            
            if(radius < 0) 
            {
                throw new ArgumentException("Радиус не может быть отрицательным"); 
            }
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
