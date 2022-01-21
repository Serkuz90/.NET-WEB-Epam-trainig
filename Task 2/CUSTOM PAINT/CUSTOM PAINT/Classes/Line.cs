using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Classes
{
    internal class Line
    {
        private Point _a;
        private Point _b;

        public Line(Point a, Point b)
        {
            _a = a;
            _b = b;
        }

        public double LineLenght()
        {
            return Math.Sqrt(Math.Pow((_a.x - _b.x), 2) + Math.Pow((_a.y - _b.y), 2));
        }
    }
}
