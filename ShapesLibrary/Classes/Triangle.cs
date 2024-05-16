using ShapesLibrary.Interfaces;
using System;

namespace ShapesLibrary.Classes
{
    public class Triangle : IShape
    {
        private double _a { get; }
        private double _b { get; }
        private double _c { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateArea()
        {
            double p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * ((p - _a) * (p - _b) * (p - _c)));
        }
        public bool isRightAngled()
        {
            if ((_a * _a + _b * _b == _c * _c) || (_a * _a + _c * _c == _b * _b) || (_c * _c + _b * _b == _b * _a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
