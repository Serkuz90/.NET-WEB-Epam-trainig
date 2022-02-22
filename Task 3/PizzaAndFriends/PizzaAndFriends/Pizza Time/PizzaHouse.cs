using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAndFriends.Pizza_Time
{
    public static class PizzaHouse
    {

        public static void MakingPizza(Order order)
        {
            Thread.Sleep(1000);
            switch (order.orderPizzaType)
            {
                case 1:
                    order.Pizza = new Pizza("Пицца с пеперони и ананасами");
                    break;
                case 2:
                    order.Pizza = new Pizza("Пицца с сыром и ананасами");
                    break;
                case 3:
                    order.Pizza = new Pizza("Пицца с ананасами и ананасами");
                    break;
                case 4:
                    order.Pizza = new Pizza("Пицца с итальянской плесенью и ананасами");
                    break;
                case 5:
                    order.Pizza = new Pizza("Пицца <JOJO> с кабачками и ананасами");
                    break;
                case 6:
                    order.Pizza = new Pizza("Пицца <Скажи нет ананасам> секретный ингридиент ананасы");
                    break;
            }
            order.OrderState = true;


        }
    }
}
