using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopment.Classes
{
    public class Person : Essence
    {

        public Person(double healthPoint, double manaPoint, Point Coords, double damage)
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

        public void DealDamage(Enemy enemy)
        {
            enemy.HP = enemy.HP - Damage;
            MP = MP - 1;
        }

        public void TeleportTo(Point point)
        {
            if (point.x > 100 && point.y > 100)
            {
                throw new ArgumentException("Ты телепортировался в лаву и вмер");
            }
            else
            {
                if (Field.points.Contains(point))
                {
                    HP = HP - 20;
                    Console.WriteLine("Ай блин я паходу в камень влетел");
                }
                Coordinates = point;
            }

        }




    }
}
