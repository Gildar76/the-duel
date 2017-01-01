using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_duel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE DUEL!");
            Console.Write("Please enter the name you want to use for your character ");
            string playerName = Console.ReadLine();

            string[] opponentNames = new string[] { "Gildar", "Styrbjorn", "Twizz", "Kharog" };
            //Weapon test
            Weapon playerWeapon = new Weapon("test", 1, 5, 50);
            Character playerCharacter = new Character("Gildar", 20, playerWeapon, 35);
            Console.WriteLine(playerCharacter.attack());
            Console.WriteLine(playerCharacter.defend());
            //playerCharacter.attack();
            //playerCharacter.defend();
            Console.WriteLine(playerCharacter.characterName);


            //Console.WriteLine(playerWeapon.swing());
            //Console.WriteLine(playerWeapon.parry());

            //Adding a Console.readline to prevent window from closing
            Console.ReadLine();
        }
    }
}
