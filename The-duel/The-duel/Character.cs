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
