using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomPaint.Figures;
using System.Threading.Tasks;


namespace CustomPaint
{
    public enum FiguresType
    {
        None,
        Circle,
        Ring,
        Rectangle,
        Quadrate,
        Triangle,
        Line,
    }
    public class FigureBuilder
    {


        public  Figure BuildFigure(FiguresType type) =>
            type switch
            {
                FiguresType.Circle => CreateCircle(),
                FiguresType.Ring => CreateRing(),
                FiguresType.Rectangle => CreateRectangle(),
                FiguresType.Quadrate => CreateQuadrate(),
                FiguresType.Triangle => CreateTriangle(),
                FiguresType.Line => CreateLine(),
                _ => throw new ArgumentException(nameof(type)),
            };

        private Circle CreateCircle()
        {
            Console.WriteLine("Введите параметр круга");
            int radius = ReaderOnlyPositive();
            Console.WriteLine("Введите координаты центра");
            Point coord;
            coord.x = Reader();
            coord.y = Reader();

            return new Circle(radius, coord.x, coord.y);
        }

        private Ring CreateRing()
        {
            Console.WriteLine("Введите Радиусы Кольца");
            int radius1= ReaderOnlyPositive();
            int radius2 = ReaderOnlyPositive();
            Console.WriteLine("Введите координаты центра");
            Point coord;
            coord.x = Reader();
            coord.y = Reader();

            return new Ring(radius1, radius2, coord.x,coord.y);

        }

        private Rectangle CreateRectangle()
        {
            Console.WriteLine("Введите Длину и Ширину");
            int length = ReaderOnlyPositive();
            int width = ReaderOnlyPositive();
            return new Rectangle(length, width);
        }

        private Quadrate CreateQuadrate()
        {
            Console.WriteLine("Введите длину стороны");
            int width = ReaderOnlyPositive();
            return new Quadrate(width);
        }

        private Triangle CreateTriangle()
        {
            Console.WriteLine("Введите координаты углов треугольника");
            Point a;
            Point b;
            Point c;

            a.x = Reader();
            a.y = Reader();
            b.x = Reader();
            b.y = Reader();
            c.x = Reader();
            c.y = Reader();

            return new Triangle(a, b, c);
        }

        private Line CreateLine()
        {
            Point a;
            Point b;
            Console.WriteLine("Введите координаты первой точки");
            a.x = Reader();
            a.y = Reader();
            Console.WriteLine("Введите координаты второй точки");
            b.x = Reader();
            b.y = Reader();

            return new Line(a, b);
        }






        static bool Check(int x) => x > 0;
        public static int ReaderOnlyPositive()
        {
            string N = Console.ReadLine() ?? string.Empty;

            int number;

            if (int.TryParse(N, out number) && Check(number)) return number;
            else
            {
                Console.WriteLine("Введите значение заново");
                return ReaderOnlyPositive();
            }
        }

        public static int Reader()
        {
            string someString = Console.ReadLine() ?? string.Empty;
            int number;

            if (int.TryParse(someString, out number)) return number;
            else
            {
                Console.WriteLine("Введите число");
                return Reader();
            }
        }


    }
}
