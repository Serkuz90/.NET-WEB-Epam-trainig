using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class Quadrate : Figure
    {
        private protected int _width;
        public Quadrate(int width)
        {
            if (width > 0)
            {
                _width = width;
            }
            else
            {
                // Кинуть эксепшн
            }
        }

        public override double Square()
        {
            return Math.Pow(_width, 2);
        }

        public override double Length()
        {
            return _width*4;
        }
    }
}
