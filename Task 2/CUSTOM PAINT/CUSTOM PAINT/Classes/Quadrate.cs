using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Classes
{
    internal class Quadrate
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

        public virtual double CalculateSquare()
        {
            return _width*4;
        }
    }
}
