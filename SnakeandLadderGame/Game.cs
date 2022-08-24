using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderGame
{
    internal class Game
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int playerPosition = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            int diceCount = random.Next(1, 7);
            return diceCount;
        }
        public void Play()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    playerPosition += 0;
                    Console.WriteLine("Player is Not Play the Game");
                    break;
                case LADDER:
                    playerPosition += DiceRoll();
                    Console.WriteLine("Player Play Ladder Game");
                    break;
                case SNAKE:
                    playerPosition -= DiceRoll();
                    Console.WriteLine("Player Play Snake Game");
                    break;
            }
            Console.WriteLine(playerPosition);
        }
    }
}
