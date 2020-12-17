using System;

namespace Geometry
{
    public class Point
    {
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point() : this(1,1) { }

        public double X => _x;
        public double Y => _y;

        public double Distance() => Math.Sqrt(_x*_x + _y*_y);

        public double Distance(Point anotherPoint) => 
            Math.Sqrt(Math.Pow(_x - anotherPoint._x, 2) + Math.Pow(_y - anotherPoint._y, 2));

        public static double Distance(Point point, Point anotherPoint) => point.Distance(anotherPoint);

        public override string ToString() => $"({_x}, {_y})";
    }
}