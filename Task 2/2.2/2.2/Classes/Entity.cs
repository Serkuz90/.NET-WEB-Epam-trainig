using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public abstract class Entity
    {
        public int HealthPoint;
        public int ManaPoint;


        public void DealDamage()
        {
            Console.WriteLine("Таа Шаа");
        }
        public void GetDamage()
        {
            Console.WriteLine("Маслину поймав");
        }

    }
}
