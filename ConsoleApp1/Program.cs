using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test init of decks
            Player player1 = new Player();
            Player player2 = new Player();
            Game testgame = new Game();
            Card c = new Card();
            testgame.initializeDecks(player1, player2);
            player1.toString();
            player2.toString();
            Console.Read();



            // 1. Initialize Players (Player Class)

            // 2. Initialize and shuffle decks (Game Class, Card Class)

            // 4. Both players play a round. (Game Class)

            // 7. Repeat until game over.

        }
    }
}
