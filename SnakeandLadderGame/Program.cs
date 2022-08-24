namespace SnakeandLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DiceRoll();
            game.Play();
        }
    }
}