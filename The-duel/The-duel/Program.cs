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

            //Adding a Console.readline to prevent window from closing
            Console.ReadLine();
        }
    }
}
