﻿using System;

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
    }
}