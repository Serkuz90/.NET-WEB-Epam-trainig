using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDevelopment;

namespace GameDevelopment.Classes
{
    public abstract class Essence
    {
        protected double _damage;
        private Point _coord = new Point(0,0);
        protected double _hp;
        protected double _mp;
        public virtual double HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public virtual double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public virtual double MP 
        {
            get { return _mp; }
            set { _mp = value; }
        }

        public virtual Point Coordinates
        {
            get { return Coordinates; }
            set 
            {
                _coord.x = value.x;
                _coord.y = value.y;
            }
        }
    }
}
