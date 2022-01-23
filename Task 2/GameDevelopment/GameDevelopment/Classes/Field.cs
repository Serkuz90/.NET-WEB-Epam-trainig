using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopment.Classes
{
    public class Field
    {
        public static List<Point> points;
        public static void AddStone(Point point)
        {
            points.Add(point);
        }
    }
}
