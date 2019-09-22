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
            //Initialize players. (playGame will read names)
            Player player1 = new Player();
            Player player2 = new Player();
            //Initialize Game, (Will also initialize, shuffle, and deal the decks)
            Game testgame = new Game();
            testgame.initializeDecks(player1, player2);
            //Plays a game of War.
            testgame.playGame(player1, player2);

            Console.Read();
        }
    }
}
