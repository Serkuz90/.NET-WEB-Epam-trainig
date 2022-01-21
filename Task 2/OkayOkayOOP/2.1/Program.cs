using System;
using OkayOkayOOP.Classes;

namespace OkayOkayOOP 
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hatsune ";
            string str2 = "Miku";


            
            //str1 = ReadAndCheck();
            //str2 = ReadAndCheck();

            

            CustomString someString1 = new CustomString(str1);
            CustomString someString2 = new CustomString(str2);
            CustomString someString3 = someString1 + someString2;
            Console.WriteLine(someString3);
            //CustomString someString3 = someString1 + someString2;
            //Console.WriteLine(someString3.GetValue());

            //someString1.Contains('a');


            //char[] chars = { 'H', 'a', 't', 's', 'u', 'n', 'e' };
            //CustomString.Multitool(chars);
        }

        static string ReadAndCheck()
        {
            string str = "";
            str = Console.ReadLine();

            if (str is null)
            {
                Console.WriteLine("Введите значение повторно");
                return ReadAndCheck();
            }
            else
            {
                
                return str;
            }
        }
    }


}
