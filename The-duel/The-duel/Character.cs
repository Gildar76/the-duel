using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_duel
{
    class Character
    {
        public int hitPoints;
        public string characterName;
        public Weapon weapon;
        public int hitChance;

        public Character(string name, int hitPoints, Weapon weapon, int hitChance)
        {
            characterName = name;
            this.hitPoints = hitPoints;
            this.weapon = weapon;
            this.hitChance = hitChance;
        }

        public int attack()
        {
            Random rnd = new Random();
            bool isHit = (rnd.Next(100) + 1 < hitChance) ? true : false;
            if (isHit)
            {
                return weapon.swing();

            }
            return 0;
        }

        public bool defend()
        {
            return weapon.parry();

        }
    }
}
