using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Weakest.Text 
{
    class Program 
    {
        static void Main(string[] args)
        {
            int peopleNumber = 0;
            int strikeout = 0;
            Console.WriteLine("Введите колличество людей");
            peopleNumber = ReadAndParce();
            Console.WriteLine("Введите какого по счету человека будем вычеркивать");
            strikeout = ReadAndParce();
            Console.WriteLine("Сгенерирован круг людей начинаем вычеркивать каждого N ого");

            List<int> peopleList = new List<int>();

            for (int i = 0; i < peopleNumber; i++)
            {
                peopleList.Add(i+1);
            }

            //for (int i = 0; i < peopleList.Count; i++)
            //{
            //    Console.Write(peopleList[i]);
            //}
            //int position = 0;
            //int del = 0;
            //do
            //{
            //    if (del == 2)
            //    {
            //        peopleList.RemoveAt(position);
            //        del = -1;
            //    }
            //    if (position == peopleList.Count)
            //    {
            //        position = 0;
            //    }
            //    else
            //    {
            //        position++;
            //    }
            //    del++;
            //    for (int i = 0; i < peopleList.Count; i++)
            //    {
            //        Console.Write(peopleList[i]);
            //    }
            //    Console.WriteLine(Environment.NewLine);
            //} while (peopleList.Count >= strikeout);

            int position = 0;
            int del = 1;
            while (peopleList.Count >= strikeout)
            {
                if((del % strikeout) == 0)
                {
                    peopleList.RemoveAt(position);
                    del = 1;
                    position--;
                }
                else
                {
                    del++;
                }
                for (int i = 0; i < peopleList.Count; i++)
                {
                    Console.Write(peopleList[i]);
                }
                Console.WriteLine(Environment.NewLine);
                if (position == (peopleList.Count - 1))
                {
                    position = 0;
                }else
                {
                    position++;
                }


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
