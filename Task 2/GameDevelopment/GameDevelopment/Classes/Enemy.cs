using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopment.Classes
{
    public class Enemy : Essence
    {
        public Enemy(double healthPoint, double manaPoint, Point Coords, double damage)
        {
            if (Coords.x > 100 && Coords.y > 100)
            {
                throw new ArgumentException("Нильзя СОЗДАТЬ персонажа ВНЕ поля ПЕЛЬМЕНЕЙ");
            }
            HP = healthPoint;
            MP = manaPoint;
            Coordinates = Coords;
            Damage = damage;
        }

        public void EnemyMove()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Point point = new Point(rnd1.Next(100), rnd2.Next(100));
            Coordinates = point;
        }


    }
}
