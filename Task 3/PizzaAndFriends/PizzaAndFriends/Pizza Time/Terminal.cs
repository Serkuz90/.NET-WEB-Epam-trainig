using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAndFriends.Pizza_Time
{
    public static class Terminal
    {
        public static void GetMenu()
        {
            Console.WriteLine("Меню пиццы");
            Console.WriteLine("Пицца по купону 1: Пицца с пеперони и ананасами");
            Console.WriteLine("Пицца по купону 2: Пицца с сыром и ананасами");
            Console.WriteLine("Пицца по купону 3: Пицца с ананасами и ананасами");
            Console.WriteLine("Пицца по купону 4: Пицца с итальянской плесенью и ананасами");
            Console.WriteLine("Пицца по купону 5: Пицца <JOJO> с кабачками и ананасами");
            Console.WriteLine("Пицца по купону 6: Пицца <Скажи нет ананасам> секретный ингридиент ананасы");
            Console.WriteLine("не выберешь пиццу мы из тебя пеперони сделаем");
        }
        public static void MakeOrder()
        {
            int pizzaType = 0;
            pizzaType = ReadAndParce();

            if (pizzaType > 6)
            {
                Console.WriteLine("ну все ты пойдешь на пеперони");
            }
            else
            {
                Order order = new Order(pizzaType);
                order.OnOrderChanged += PizzaReady;
                PizzaHouse.MakingPizza(order);
            }
        }

        public static void PizzaReady(Order order)
        {
            Console.WriteLine("Пицца готова: " + order.Pizza?.pizzaName+ " " + order.orderNumber);
        }


        public static void Message(string message)
        {
            Console.WriteLine(message);

        }


        public static int ReadAndParce()
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
        static bool Check(int x) => x > 0;
    }

}
