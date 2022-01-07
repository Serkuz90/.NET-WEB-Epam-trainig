using System;

namespace SomeApps
{
    class Program   //   1.1.1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную");
            int x = ReadSide();
            Console.WriteLine("Введите вторую переменную");
            int y = ReadSide();
            int res = x * y;
            Console.WriteLine($"Площадь данного прямоугольника равна {res}");

        }

        //static int ReadSide()
        //{
        //    string Side = Console.ReadLine() ?? string.Empty;

        //    int x;

        //    if (int.TryParse(Side, out x)) return CheckEngine(x);
        //    else
        //    {
        //        Console.WriteLine("Введите значение заново");
        //        return ReadSide();
        //    }

        //}

        static int CheckEngine(int x)
        {
            if (x <= 0)
            {
                Console.WriteLine("Введите значение заново");
                return ReadSide();
            }
            else return x;
        }

        static bool Check(int x) => x > 0;

        static int ReadSide()               // попробовать написать через do while
        {
            string Side = Console.ReadLine() ?? string.Empty;

            int x;

            if (int.TryParse(Side, out x) && Check(x)) return x;
            else
            {
                Console.WriteLine("Введите значение заново");
                return ReadSide();
            }

        }
    }

}

