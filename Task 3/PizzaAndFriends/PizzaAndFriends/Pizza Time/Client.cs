using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAndFriends.Pizza_Time
{
    public class Client
    {
        public string clientName;
        public Client(string name)
        {
            clientName = name;
        }

        public void IWantPizza()
        {
            Console.WriteLine("Я хочу ПИЦЦЫ");
        }

        public void GoToTerminal()
        {
            Terminal.GetMenu();
            Terminal.MakeOrder();
        }


    }
}
