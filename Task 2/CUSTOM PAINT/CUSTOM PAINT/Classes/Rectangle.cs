using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Classes
{
    internal class Rectangle : Quadrate
    {
        private protected int _length;
        public Rectangle(int length, int width) : base(width)
        {
            if (_length > 0)
            {
                _length = length;
            }
            else
            {
                //exception
            }
        }

        public override double CalculateSquare()
        {
            return _length * _width;
        }
    }
}
