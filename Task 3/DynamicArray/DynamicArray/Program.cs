using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DynamicArray.Classes;
namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>(3);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Insert(2, 69);
            Console.WriteLine(arr.Capacity);
            Console.WriteLine(arr.Length);

            //foreach(int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}