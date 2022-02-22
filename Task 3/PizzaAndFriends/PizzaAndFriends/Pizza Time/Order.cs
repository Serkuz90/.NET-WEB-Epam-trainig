using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAndFriends.Pizza_Time
{
    public class Order
    {
        public Pizza? Pizza { get; set; }
        private int _orderNumber = 0;
        public int orderNumber = 0;
        private bool _orderState;
        public event Action<Order>? OnOrderChanged;
        public bool OrderState 
        {
            get { return _orderState; }
            set 
            {
                if (value)
                {
                    OnOrderChanged?.Invoke(this);
                }
                
                _orderState = value; 
            } 
        }

        public int orderPizzaType = 0;
        public Order(int pizzaType)
        {
            orderNumber = _orderNumber + 1;
            _orderNumber++;
            orderPizzaType = pizzaType;

            _orderState = false;
            
            Terminal.Message("Номер вашего заказа " + orderNumber);

        }



    }
}
