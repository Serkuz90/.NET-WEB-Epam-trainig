using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopment.Classes
{
    public class Stone
    {
        private Point _coordinate;
        public Point Coordinate
        {
            get { return _coordinate; }
            set { _coordinate = value; }
        }
        public Stone(Point Coord)
        {
            Coordinate = Coord;
            Field.AddStone(Coord);
        }
    }
}
