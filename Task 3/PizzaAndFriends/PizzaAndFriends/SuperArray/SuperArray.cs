using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAndFriends.SuperArray
{
    public static class SuperArray
    {
        public static void Something(this int[] arr, Program.ActionWithElement Func)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Func.Invoke(arr[i]);
            }
            
        }
        public static int SumElement(this int[] arr)
        {
            return arr.Sum(x => x);
        }

        public static double TheAverage(this int[] arr)
        {
            return arr.Average();
        }

        public static int TheMostFrequentlyEncountered(this int[] arr)
        {
            return arr.GroupBy(x => x)
                    .OrderByDescending(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Count())
                    .FirstOrDefault()
                    .Key;
        }
    }
}
