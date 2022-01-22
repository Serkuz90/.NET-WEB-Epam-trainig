using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class Circle : Figure
    {
        private protected int _radius;
        Point _point;
        public Circle(int radius, int x, int y)
        {
            if (radius >= 0)
            {
                _radius = radius;
            }else
            {
                //Воткнуть эксепшн
            }

            _point.x = x;
            _point.y = y;
        }

        public override double Length()
        {
            double length = 2 * Math.PI * _radius;
            return length;
        }

        public override double Square()
        {
            double square = Math.PI * (_radius * _radius);
            return square;
        }

        
    }


}
