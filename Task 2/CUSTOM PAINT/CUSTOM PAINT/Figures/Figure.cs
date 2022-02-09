using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public abstract class Figure
    {

        public virtual double Length() => 0;
        public virtual double Square() => 0;

        public virtual string GetInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(ToString());
            builder.AppendLine($"Длина: {Length}");
            builder.AppendLine($"Площадь: {Square}");
            return builder.ToString();
        }
    }
}
