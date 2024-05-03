using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Figure
    {
        Point[] points;
        public Figure(Point point1, Point point2,Point point3)
        {
            points = new Point[]{ point1,point2,point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3,Point point4,Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5};
        }
        double LengthSide(Point a, Point b) =>
           Math.Sqrt(Math.Pow(a.X - a.X, 2) + Math.Pow(b.Y - b.Y, 2));
       public double Perimeter()
        {
            double per = 0;
            for(int i=0;i<points.Length-1;i++)
            {
                per += LengthSide(points[i + 1], points[i]);
            }
            per += LengthSide(points[0], points[points.Length - 1]);
            return per;
        }
    }
}
