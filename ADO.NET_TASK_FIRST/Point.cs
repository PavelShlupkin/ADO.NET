﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    public struct Point
    {
        public double x, y, z;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point { x = b.x - a.x, y = b.y - a.y, z = b.z - a.z };
        }

        public static double Length(Point a, Point b)
        {
            Point vector = b - a;
            return Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2) + Math.Pow(vector.z, 2));
        }
    }
}
