namespace SnakeAPI
{
    public class Game
    {
        public enum Mode { Borderless, WithBorders }

        public SnakeAPI.Snake Snake { get; private set; }
        public SnakeAPI.Fruit Fruit { get; private set; }

        public int Score { get; private set; }

        public Game(Mode mode, int width, int height)
        {
            Snake = new Snake(mode, width, height);
            Fruit = new Fruit(width, height);
            Score = 0;
        }

        public bool Logic()
        {
            if (!Snake.Move())
                return false;

            if (Snake.Head == Fruit.Location)
            {
                Snake.Eat(Fruit);
                Fruit.New();
                Score++;
            }
            return true;
        }
    }
}
