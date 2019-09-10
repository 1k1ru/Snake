using System;
using System.Drawing;

namespace Snake.API
{
    public class Fruit
    {
        Game game;
        private Random rand;
        public Point Location { get; private set; }

        public Fruit(Game game)
        {
            this.game = game;
            rand = new Random();
            this.New();
        }

        internal protected void New()
        {
            Location = new Point(rand.Next(game.FieldWidth), rand.Next(game.FieldHeight));
        }
    }
}
