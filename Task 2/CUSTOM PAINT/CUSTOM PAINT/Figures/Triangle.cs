using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class Triangle : Figure
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

        public override double Square()
        {
            return 0.5*((_a.x*(_b.y - _c.y)) + (_b.x*(_c.y - _a.y)) + (_c.x*(_a.y - _b.y)));
        }

        public override double Length()
        {
            double AB = Math.Sqrt(Math.Pow((_b.x - _a.x), 2) + Math.Pow((_b.y - _a.y), 2));
            double AC = Math.Sqrt(Math.Pow((_c.x - _a.x), 2) + Math.Pow((_c.y - _a.y), 2));
            double BC = Math.Sqrt(Math.Pow((_c.x - _b.x), 2) + Math.Pow((_c.y - _b.y), 2));
            return AB + AC + BC;
        }
    }
}
