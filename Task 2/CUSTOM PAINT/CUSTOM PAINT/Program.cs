using System;
using System.Collections.Generic;
using System.Linq;
using CustomPaint.Figures;



namespace CustomPaint
{
    public struct Point
    {
        public int x;
        public int y;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int action = -1;
            string str1 = "1: Добавить фигуру";
            string str2 = "2: Вывести фигуры";
            string str3 = "3: Очистить холст";
            string str4 = "5: Выход";
            string newL = Environment.NewLine;

            while (action != 5)
            {
                Console.WriteLine("Введите число");
                Console.WriteLine(str1 + newL + str2 + newL + str3 + newL + str4);
                action = ReadAndParce();

                switch (action) 
                {
                    case 1:
                        {
                            AddFigure();
                        }break;
                    case 2:
                        {
                            FigureList();
                        }break;
                    case 3:
                        {
                            figures.Clear();
                        }break;

                }
            }
        }
        public static FigureBuilder newBuilder = new FigureBuilder();
        public static List<Figure> figures = new List<Figure>();
        public IEnumerable<Figure> Figures => figures;
        public void AddFigure(Figure figure) => figures.Add(figure);
        public static void AddFigure()
        {
            FiguresType type = GetRequestFigureInput();
            Console.WriteLine();

            var figure = newBuilder.BuildFigure(type);
            Console.WriteLine($"Фигура {figure} создана!" + Environment.NewLine);
            figures.Add(figure);
        }

        public static void FigureList()
        {
            int length = figures.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(figures[i]);
                Console.WriteLine(figures[i].GetInfo());
            }
        }

        public static FiguresType GetRequestFigureInput()
        {
            FiguresType input;
            do
            {
                Console.WriteLine("Выберите фигуру");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Кольцо");
                Console.WriteLine("3. Прямоугольник");
                Console.WriteLine("4. Квадрат");
                Console.WriteLine("5. Треугольник");
                Console.WriteLine("6. Линия");
            } while (!TryParseFiguresType(ReadAndParce(), out input));

            return input;
        }

        static bool Check(int x) => x > 0;
        public static int ReadAndParce()
        {
            string N = Console.ReadLine() ?? string.Empty;

            int number;

            if (int.TryParse(N, out number) && Check(number)) return number;
            else
            {
                Console.WriteLine("Введите значение заново");
                return ReadAndParce();
            }
        }

        private static bool TryParseFiguresType(int number, out FiguresType result)
        {
            result = number switch
            {
                1 => FiguresType.Circle,
                2 => FiguresType.Ring,
                3 => FiguresType.Rectangle,
                4 => FiguresType.Quadrate,
                5 => FiguresType.Triangle,
                6 => FiguresType.Line,
                _ => FiguresType.None
            };

            return result != FiguresType.None;
        }
    }
}