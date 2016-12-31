using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_duel
{
    class Weapon
    {
        public string weaponName;
        public int weaponSpeed;
        public int weaponDamage;
        public int parryChance;

        public Weapon(string name, int speed, int damage, int parry)
        {
            weaponName = name;
            weaponSpeed = speed;
            weaponDamage = damage;
            parryChance = parry;
        }

        public void swing()
        {
            Console.WriteLine("Swinging " + weaponName);
        }

        public void parry()
        {
            Console.WriteLine("Trying to parry");

        }
    }
}
