using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PizzaAndFriends.SuperString
{
    public static class SuperString
    {
        public static void GetLanguage(this string str)
        {
            List<string> languages = new List<string>();
            if (Regex.IsMatch(str, "[а-яА-ЯеЁ]")) languages.Add(" Russian");
            if (Regex.IsMatch(str, "[a-zA-Z]")) languages.Add(" English");
            if (Regex.IsMatch(str, "[0-9]")) languages.Add(" Number");
            if (languages.Count >= 2)
            {
                Console.WriteLine("Mixed");
            }
            else
            {
                Console.WriteLine(languages[0]);
            }
        }
    }
}
