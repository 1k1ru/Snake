namespace Snake.API
{
    public class Game
    {
        internal protected Mode Mode { get; set; }
        public int FieldWidth { get; }
        public int FieldHeight { get; }
        public Snake Snake { get; private set; }
        public Fruit Fruit { get; private set; }
        public int Score { get; private set; }

        public Game(Mode mode, int width, int height)
        {
            this.Mode = mode;
            this.FieldWidth = width;
            this.FieldHeight = height;

            Snake = new Snake(this);
            Fruit = new Fruit(this);
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
