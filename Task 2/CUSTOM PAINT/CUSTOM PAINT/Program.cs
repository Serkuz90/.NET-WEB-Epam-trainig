using System;
using System.Collections.Generic;
using System.Linq;
using CustomPaint.Classes;


namespace CustomPaint
{
    struct Point
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
            }
        }

        static bool Check(int x) => x > 0;
        static int ReadAndParce()
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
    }
}