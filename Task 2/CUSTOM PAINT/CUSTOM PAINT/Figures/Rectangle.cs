using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class Rectangle : Quadrate
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

        public override double Square()
        {
            return _length * _width;
        }

        public override double Length()
        {
            return (_length*2)+(_width*2);
        }
    }
}
