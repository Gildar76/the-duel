using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_duel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("WELCOME TO THE DUEL!");
            Console.Write("Please enter the name you want to use for your character ");
            string playerName = Console.ReadLine();

            string[] opponentNames = new string[] { "Gildar", "Styrbjorn", "Twizz", "Kharog" };

            //Weapons. We could create these when we create the character, but creating them as separate variables will be easier to read.
            Weapon playerWeapon = new Weapon("sword", 1, 3, 25);
            Weapon opponentWeapon = new Weapon("axe", 1, 4, 5);

            //Characters
            Character playerCharacter = new Character(playerName, 20, playerWeapon, 50);
            Character opponentCharacter = new Character("opponent", 25, opponentWeapon, 40);

            //generate the fight
            bool fightIsRunning = false;
            Console.WriteLine("Press enter to start the fight!");
            Console.ReadLine();
            fightIsRunning = true;
            while (fightIsRunning)
            {
                fight(playerCharacter, opponentCharacter);
                if (playerCharacter.hitPoints <= 0 || opponentCharacter.hitPoints <= 0)
                {
                    fightIsRunning = false;
                }
                Console.WriteLine(playerCharacter.characterName + " has " + playerCharacter.hitPoints + " hit points left");
                Console.WriteLine(opponentCharacter.characterName + " has " + opponentCharacter.hitPoints + " hit points left");
                Console.ReadLine();
            }
            //Fight is done. In the exercise. Step 17 and 18 is inside the while loop, but I decided to put them here instead to make things clearer.
            if (playerCharacter.hitPoints <= 0)
            {
                Console.WriteLine("Player lost!");
            }
            if (opponentCharacter.hitPoints <= 0)
            {
                Console.WriteLine("Opponent lost!");
            }

            Console.ReadLine();
        }

        public static void fight(Character playerCharacter, Character opponentCharacter)
        {
            int damageDealt = 0;
            //Player character round.
            damageDealt = playerCharacter.attack();
            if (damageDealt > 0)
            {
                if (opponentCharacter.defend())
                {
                    Console.WriteLine(playerCharacter.characterName + " Tries to hit " + opponentCharacter.characterName + " with his " + playerCharacter.weapon.weaponName
                        + ", but " + opponentCharacter.characterName + " parries");
                } else
                {
                    Console.WriteLine(playerCharacter.characterName + " hits " + opponentCharacter.characterName + " with his " + playerCharacter.weapon.weaponName
                        + " for " + damageDealt + " points of damage" );
                    opponentCharacter.hitPoints -= damageDealt;
                }
            } else
            {
                Console.WriteLine(playerCharacter.characterName + " tries to hit " + opponentCharacter.characterName
                    + " with his " + playerCharacter.weapon.weaponName + " but misses");
            }

            //Opponent character round
            damageDealt = 0;
            damageDealt = opponentCharacter.attack();
            if (damageDealt > 0)
            {
                if (playerCharacter.defend())
                {
                    Console.WriteLine(opponentCharacter.characterName + " Tries to hit " + playerCharacter.characterName + " with his " + opponentCharacter.weapon.weaponName
                        + ", but " + playerCharacter.characterName + " parries");
                }
                else
                {
                    Console.WriteLine(opponentCharacter.characterName + " hits " + playerCharacter.characterName + " with his " + opponentCharacter.weapon.weaponName
                        + " for " + damageDealt + " points of damage");
                    playerCharacter.hitPoints -= damageDealt;
                }
            }
            else
            {
                Console.WriteLine(opponentCharacter.characterName + " tries to hit " + playerCharacter.characterName
                    + " with his " + opponentCharacter.weapon.weaponName + " but misses");
            }



        }
    }
}
