using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class Line : Figure
    {
        private Point _a;
        private Point _b;

        public Line(Point a, Point b)
        {
            _a = a;
            _b = b;
        }

        public override double Length()
        {
            return Math.Sqrt(Math.Pow((_a.x - _b.x), 2) + Math.Pow((_a.y - _b.y), 2));
        }

        public override double Square()
        {
            double square = 0;
            return square;
        }
    }
}
