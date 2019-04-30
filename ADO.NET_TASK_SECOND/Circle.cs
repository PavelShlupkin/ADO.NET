using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    public struct Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

        public Circle(double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }

        //public static Point operator -(Point a, Point b)
        //{
        //    return new Point { x = b.x - a.x, y = b.y - a.y };
        //}

        //public static double Length(Point a, Point b)
        //{
        //    Point vector = b - a;
        //    return Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2));
        //}

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
