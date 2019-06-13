using System.Collections.Generic;
using System.Drawing;

namespace SnakeAPI
{
    public class Snake
    {
        private Game.Mode mode;
        private int width, height;

        public Point Head { get { return head; } }
        private Point head;
        public List<Point> Tail { get; private set; }

        public enum Direction { Up, Down, Left, Right }
        public Direction Dir { get; set; }

        public Snake(Game.Mode mode, int width, int height)
        {
            this.mode = mode;
            this.width = width;
            this.height = height;

            head = new Point(width / 2, height / 2);
            Dir = Direction.Right;
            Tail = new List<Point>();
            Tail.Add(head);
        }

        internal protected bool Move()
        {
            for (int i = Tail.Count - 1; i > 0; i--)
                Tail[i] = Tail[i - 1];
            Tail[0] = head;

            switch (Dir)
            {
                case Direction.Up:
                    head.Y--;
                    if (mode == Game.Mode.Borderless && head.Y == -1)
                        head.Y = height - 1;
                    break;
                case Direction.Down:
                    head.Y++;
                    if (mode == Game.Mode.Borderless && head.Y == height)
                        head.Y = 0;
                    break;
                case Direction.Left:
                    head.X--;
                    if (mode == Game.Mode.Borderless && head.X == -1)
                        head.X = width - 1;
                    break;
                case Direction.Right:
                    head.X++;
                    if (mode == Game.Mode.Borderless && head.X == width)
                        head.X = 0;
                    break;
            }
            return !Collision();
        }

        private bool Collision()
        {
            if (mode == Game.Mode.WithBorders)
                return Tail.Contains(head) || head.X < 0 || head.X >= width || head.Y < 0 || head.Y >= height;
            else
                return Tail.Contains(head);
        }

        internal protected void Eat(Fruit fruit)
        {
            Tail.Insert(0, fruit.Location);
        }
    }
}