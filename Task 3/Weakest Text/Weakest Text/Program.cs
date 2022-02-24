using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Weakest.Text 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //WeakestLink();
            KowalskiAnalysis();
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
        static void WeakestLink()
        {
            int peopleNumber = 0;
            int strikeout = 0;
            Console.WriteLine("Введите колличество людей");
            peopleNumber = ReadAndParce();
            Console.WriteLine("Введите какого по счету человека будем вычеркивать");
            strikeout = ReadAndParce();
            
            if (peopleNumber < strikeout)
            {
                Console.WriteLine("Колличество человек не может быть меньше чем номер вычеркиваемого");
            }else
            {
                Console.WriteLine("Сгенерирован круг людей начинаем вычеркивать каждого N ого");
            }

            List<int> peopleList = new List<int>();

            for (int i = 0; i < peopleNumber; i++)
            {
                peopleList.Add(i+1);
            }

            int position = 0;
            int del = 1;

            int roundCount = 1;
            while (peopleList.Count >= strikeout)
            {
                
                if ((del % strikeout) == 0)
                {
                    peopleList.RemoveAt(position);
                    del = 1;
                    position--;
                    Console.WriteLine("Раунд: "+ roundCount + " Осталось: "+ peopleList.Count + " человек!");
                    roundCount++;
                }
                else
                {
                    del++;
                }

                if (position == (peopleList.Count - 1))
                {
                    position = 0;
                }
                else
                {
                    position++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Игра окончена невозможно вычеркнуть больше людей");
        }

        static void KowalskiAnalysis()
        {
            string text = "";
            Console.WriteLine("Введите английски текст");
            //text = Console.ReadLine();
            text = "So many of you asked me for a thumbnail version, so i remade the mix with an animated on. Keep";
            string lowerText = "";
            lowerText = text.ToLower();
            Console.WriteLine(lowerText);

            List<string> wordList = new List<string>();
            string [] words = lowerText.Split(new char[] { ' ' });
            char[] symbols = { '.', ',', '!', '?', '$', '#', '@' };
            foreach (string word in words)
            {
                wordList.Add(word.TrimEnd(symbols));
            }

            Dictionary<int, string> wordDictionary = new Dictionary<int, string>();
            for (int i = 0; i < wordList.Count; i++)            // заполняем словарь не повторяющимеся словами
            {
                if (wordDictionary.ContainsValue(wordList[i])!= true)
                {
                    wordDictionary.Add(i, wordList[i]);
                }
            }
            List<int> repeates = new List<int>();
            for (int i = 0; i <wordList.Count; i++) // Заполняем счетчик повторений нулями
            {
                repeates.Add(0);
            }

            for (int i = 0; i < wordList.Count; i++)        // Заполняем счетчик повторений кол-вом повторений
            {
                int repeate = 0;
                for (int j = 0; j < wordList.Count; j++)
                {
                    
                    if (wordList[i] == wordList[j])
                    {
                        repeate++;
                        repeates[i] = repeate;
                    }
                    
                }
                
            }
            
            for (int i = 0; i < wordDictionary.Count; i++) // выписываем какие слова сколько повторяются
            {
                try { Console.WriteLine(wordDictionary[i]+" Встречается столько раз "+repeates[i]); }
                catch { i++; }
            }

           

        }

        

    }
}
