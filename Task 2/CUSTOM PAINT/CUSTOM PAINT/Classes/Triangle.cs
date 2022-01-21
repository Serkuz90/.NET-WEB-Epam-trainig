using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Classes
{
    internal class Triangle
    {
        private protected Point _a;
        private protected Point _b;
        private protected Point _c;

        public Triangle(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double triangleSquare()
        {
            return 0.5*((_a.x*(_b.y - _c.y)) + (_b.x*(_c.y - _a.y)) + (_c.x*(_a.y - _b.y)));
        }
    }
}
