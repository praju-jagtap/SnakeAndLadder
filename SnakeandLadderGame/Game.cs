using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderGame
{
    internal class Game
    {
        public int DiceRoll()
        {
            Random random = new Random();
            int diceCount = random.Next(1, 7);
            return diceCount;
        }
    }
}
