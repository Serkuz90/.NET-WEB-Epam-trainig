using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class Ring : Figure
    {
        private protected int _insideRadius;
        private protected int _outsideRadius;
        private protected Circle Outside;
        private protected Circle Inside;

        public Ring(int radius1, int radius2, int x, int y)
        {
            if (radius1 == radius2)
            {
                //всунуть эксепшн
            }
            else
            {
                if (radius1 > radius2)
                {
                    _insideRadius = radius2;
                    _outsideRadius = radius1;
                }
                else
                {
                    _outsideRadius = radius2;
                    _insideRadius = radius1;
                }

                Circle Outside = new Circle(_outsideRadius, x, y);
                Circle Inside = new Circle(_insideRadius, x, y);
            }
        }
        public override double Square()
        {
           return Outside.Square() - Inside.Square();
        }

        public override double Length()
        {
            return Outside.Length() + Inside.Length();
        }

    }
}
