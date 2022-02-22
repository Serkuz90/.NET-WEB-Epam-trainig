using System;
using System.Collections.Generic;
using System.Linq;
using PizzaAndFriends.SuperArray;
using PizzaAndFriends.SuperString;
using PizzaAndFriends.Pizza_Time;

namespace PizzaAndFriends
{
    public class Program
    {
        public delegate int ActionWithElement(int element);
        public static void Main(string[] args)
        {
            Client JoJo = new Client("Jojo");
            JoJo.IWantPizza();
            JoJo.GoToTerminal();

        }
        
    }
}