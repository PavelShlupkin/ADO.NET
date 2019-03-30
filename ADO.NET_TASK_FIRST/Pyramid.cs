using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    public class Pyramid
    {       
        private Point _a;
        private Point _b;
        private Point _c;
        private Point _d;
        private Point top;

        public Pyramid(List <Point> point)
        {
            Guard(point);
        }

        public void Guard(List <Point> point)
        {
            if (!IsExistBase(point[0], point[1], point[2], point[3]))
            {
                throw new ArgumentException("Wrong basic");
            }
            else
            {
                _a = point[0];
                _b = point[1];
                _c = point[2];
                _d = point[3];
                top = point[4];
            }
        }
        
        public Point A
        {
            get
            {
                return _a;
            }
            set
            {
                if (IsExistBase(value, _b, _c, _d))
                {
                    _a = value;
                }
                else
                {
                    throw new ArgumentException("There is no such basic");
                }
            }
        }
        public Point B
        {
            get
            {
                return _b;
            }
            set
            {
                if (IsExistBase(_a, value, _c, _d))
                {
                    _b = value;
                }
                else
                {
                    throw new ArgumentException("There is no such basic");
                }
            }
        }
        public Point C
        {
            get
            {
                return _c;
            }
            set
            {
                if (IsExistBase(_a, _b, value, _d))
                {
                    _c = value;
                }
                else
                {
                    throw new ArgumentException("There is no such basic");
                }
            }
        }
        public Point D
        {
            get
            {
                return _d;
            }
            set
            {
                if (IsExistBase(_a, _b, _c, value))
                {
                    _d = value;
                }
                else
                {
                    throw new ArgumentException("There is no such basic");
                }
            }
        }



        private bool IsExistBase(Point a, Point b, Point c, Point d)
        {
            double a1 = Point.Length(a, b);
            double b1 = Point.Length(a, c);
            double c1 = Point.Length(b, c);
            double d1 = Point.Length(c, d);
            
            return (a1 < b1 + c1 + d1) && (b1 < a1 + c1 + d1) && (c1 < b1 + a1 + d1) && (d1 < b1 + c1 + a1);
        }
    
      
        public double QuadrangleS()
        {
            double a = Point.Length(A, B);
            double b = Point.Length(A, C);
            double c = Point.Length(B, C);
            double d = Point.Length(C, D);
            double s = 2*(((a + b) / 2) * Math.Sqrt((c * c) - Math.Pow((Math.Pow((a - b), 2) + (c * c) - (d * d)) / (2 * (a - b)), 2)));              
            return s;
        }

        public double QuadrangleV()
        {
            double a = Point.Length(A, B);
            double b = Point.Length(B, C);
            double h = Math.Sqrt((a * a) - (b * b) / 4);
            double v = h * (a*a) / 3;
            return v;
        }


    }
}
