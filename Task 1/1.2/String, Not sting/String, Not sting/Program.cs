using System;

namespace Strings
{
    class Srtings
    {
        static void Main()
        {

            Console.WriteLine("Введите последнее число номера задания");
            int taskNumber = ReadAndParce();


            switch (taskNumber)
            {
                case 1:
                    {
                        Averages();
                    }
                    break;
                case 2:
                    {
                      Doubler();
                    }
                    break;
                case 3:
                    {
                        LowerCase();
                    }
                    break;
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


        static void Averages()
        {
            Console.WriteLine("Введите предложение");
            string str1;
            float length = 0;
            str1 = Console.ReadLine();
            string[] someStrings = str1.Split(' ');

            float letterNumbers = 0;

            length = someStrings.GetLength(0);
            
            for (int i = 0; i < length; i++)
            {
                //Console.WriteLine(someStrings[i]);

                someStrings[i].Trim(' ');
                char[] arr = someStrings[i].ToCharArray();
                int lengthCharArr = arr.GetLength(0);
                for (int x = 0; x < lengthCharArr; x++)
                {
                    if (char.IsLetter(arr[x]))
                    {
                        letterNumbers++;
                    }
                }
            }

            float sredneeKolvo = letterNumbers / length;
            //Console.WriteLine(letterNumbers);
            Console.WriteLine(sredneeKolvo);




            //Console.WriteLine(sredneeKolvo);

        }

        static void Doubler()
        {
            Console.WriteLine("Введите предложение");
            string str1;
            str1 = Console.ReadLine();

            Console.WriteLine("Введите предложение 2");
            string str2;
            str2 = Console.ReadLine();


            List<char> endString = new List<char>();
            List<char> str2WithoutSeparator = new List<char>();

            char[] charArr1 = str1.ToCharArray();
            char[] charArr2 = str2.ToCharArray();

            int length1 = charArr1.GetLength(0);
            int length2 = charArr2.GetLength(0);

            for (int i = 0; i < length2; i++)
            {

                if ((str2WithoutSeparator.Contains(charArr2[i]) || charArr2[i] == ' ') != true )
                {
                    str2WithoutSeparator.Add(charArr2[i]);
                }
                else
                {
                    
                }
                
            }

            int listLength = str2WithoutSeparator.Count;

            //for(int i = 0; i < listLength; i++)
            //{
            //    Console.WriteLine(str2WithoutSeparator[i]);
            //}

            for (int i = 0; i < length1; i++)
            {
                if (str2WithoutSeparator.Contains(charArr1[i]))
                {
                    endString.Add(charArr1[i]);
                    endString.Add(charArr1[i]);
                }
                else
                {
                    endString.Add(charArr1[i]);
                }
                
            }

            int endListLength = endString.Count;
            for(int i = 0; i < endListLength; i++)
            {
                Console.Write(endString[i]);
            }
        }

        static void LowerCase()
        {
            Console.WriteLine("Введите предложение");
            string str1;
            float length = 0;
            str1 = Console.ReadLine();
            char[] separators = new char[] { ' ', '.', ',', '-', '!', '?', '"', ';', ':' };
            string[] someStrings = str1.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            float letterNumbers = 0;

            length = someStrings.GetLength(0);

            int wordCount = 0;

            for (int i = 0; i < length; i++)
            {
                char[] char1 = someStrings[i].ToCharArray();
                if (char.IsLower(char1[0]))
                {
                    wordCount++;                                
                }
                
            }
            Console.WriteLine(wordCount);
        }




    }
}
