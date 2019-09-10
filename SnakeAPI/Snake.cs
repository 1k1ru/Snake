using System.Collections.Generic;
using System.Drawing;

namespace Snake.API
{
    public class Snake
    {
        private Game game;

        public Point Head { get { return head; } }
        private Point head;
        public List<Point> Tail { get; private set; }

        
        public Direction Direction { get; set; }

        public Snake(Game game)
        {
            this.game = game;
            head = new Point(game.FieldWidth / 2, game.FieldHeight / 2);
            Direction = Direction.Right;
            Tail = new List<Point>();
            Tail.Add(head);
        }

        internal protected bool Move()
        {
            for (int i = Tail.Count - 1; i > 0; i--)
                Tail[i] = Tail[i - 1];
            Tail[0] = head;

            switch (Direction)
            {
                case Direction.Up:
                    head.Y--;
                    if (game.Mode == Mode.Borderless && head.Y == -1)
                        head.Y = game.FieldHeight - 1;
                    break;
                case Direction.Down:
                    head.Y++;
                    if (game.Mode == Mode.Borderless && head.Y == game.FieldHeight)
                        head.Y = 0;
                    break;
                case Direction.Left:
                    head.X--;
                    if (game.Mode == Mode.Borderless && head.X == -1)
                        head.X = game.FieldWidth - 1;
                    break;
                case Direction.Right:
                    head.X++;
                    if (game.Mode == Mode.Borderless && head.X == game.FieldWidth)
                        head.X = 0;
                    break;
            }
            return !Collision();
        }

        private bool Collision()
        {
            if (game.Mode == Mode.WithBorders)
                return Tail.Contains(head) || head.X < 0 || head.X >= game.FieldWidth || head.Y < 0 || head.Y >= game.FieldHeight;
            else
                return Tail.Contains(head);
        }

        internal protected void Eat(Fruit fruit)
        {
            Tail.Insert(0, fruit.Location);
        }
    }
}