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

        public Character(string name, int hitPoints)
        {
            characterName = name;
            this.hitPoints = hitPoints;
        }

        public void attack()
        {
            Console.WriteLine("Attacking!");
        }

        public void defend()
        {
            Console.WriteLine("Defending!");

        }
    }
}
