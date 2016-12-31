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

        public int swing()
        {
            Random rnd = new Random();
            return rnd.Next(weaponDamage) + 1;

            
        }

        public bool parry()
        {
            Random rnd = new Random();
            return (rnd.Next(100) + 1 < parryChance) ? true : false;
            //This can be done with a standard if and else, but I decided to do it on one line.


        }
    }
}
