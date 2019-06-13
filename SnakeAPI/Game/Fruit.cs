using System;
using System.Drawing;

namespace SnakeAPI
{
    public class Fruit
    {
        private int width, height;
        private Random rand;

        public Point Location { get; private set; }

        public Fruit(int width, int height)
        {
            this.width = width;
            this.height = height;
            rand = new Random();
            Location = new Point(rand.Next(width), rand.Next(height));
        }

        internal protected void New()
        {
            Location = new Point(rand.Next(width), rand.Next(height));
        }
    }
}
