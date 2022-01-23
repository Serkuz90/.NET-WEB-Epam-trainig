using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopment.Classes
{
    public class Buf
    {
        protected int _healthGiven;
        public int HPGive
        {
            get { return _healthGiven; }
            set { _healthGiven = value; }
        }

        public void GivePelmeni (Person person)
        {
            person.HP = person.HP + _healthGiven;
        }
    }
}
