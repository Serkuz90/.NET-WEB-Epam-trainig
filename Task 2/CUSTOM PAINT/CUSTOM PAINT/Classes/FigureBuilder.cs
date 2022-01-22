using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOM_PAINT.Classes
{
    internal class FigureBuilder
    {
        public Figure BuildFigure(FiguresType type) =>
            type switch
            {
                FiguresType.Circle => CreateCircle(),
                FiguresType.Ring => CreateRing(),
                FiguresType.Rectangle => CreateRectangle(),
                FiguresType.Square => CreateSquare(),
                FiguresType.Triangle => CreateTriangle(),
                FiguresType.Line => CreateLine(),
                _ => throw new ArgumentOutOfRangeException(nameof(type)),
            };
    }
}
