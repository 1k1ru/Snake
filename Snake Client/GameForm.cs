using System;
using System.Drawing;
using System.Windows.Forms;
using Snake.API;

namespace SnakeClient
{
    public partial class GameForm : Form
    {
        static int TileSize = 16;
        static int TileInterval = 4;

        static int Zero = TileInterval / 2;
        static int Tile = TileSize + TileInterval;
        static int hTiles, vTiles;

        static int speed = 80;
        static bool rotate;

        Bitmap bm;
        Graphics g;
        SolidBrush sbG, sbH, sbT, sbF;

        Game game;

        public GameForm()
        {
            InitializeComponent();

            hTiles = canvas.Width / Tile;
            vTiles = canvas.Height / Tile;

            bm = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(bm);
            sbG = new SolidBrush(Color.LightGray);
            sbH = new SolidBrush(Color.DarkGreen);
            sbT = new SolidBrush(Color.Green);
            sbF = new SolidBrush(Color.Red);
        }

        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (!timerGame.Enabled)
            {
                bPlay.BackgroundImage = Properties.Resources.pause;
                timerGame.Enabled = true;
                canvas.Focus();
            }
            else
            {
                bPlay.BackgroundImage = Properties.Resources.play;
                timerGame.Enabled = false;
                canvas.Focus();
            }
        }

        private void radioButton_WithBorders_CheckedChanged(object sender, EventArgs e)
        {
            bPlay.BackgroundImage = Properties.Resources.play;
            bPlay.Enabled = true;
            timerGame.Enabled = false;

            game = new Game(Mode.WithBorders, hTiles, vTiles);

            lScore.Text = game.Score.ToString();
            Draw();
        }

        private void radioButton_Borderless_CheckedChanged(object sender, EventArgs e)
        {
            bPlay.BackgroundImage = Properties.Resources.play;
            bPlay.Enabled = true;
            timerGame.Enabled = false;

            game = new Game(Mode.Borderless, hTiles, vTiles);

            lScore.Text = game.Score.ToString();
            Draw();
        }

        private void canvas_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!rotate)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        if (game.Snake.Direction != Direction.Down)
                            game.Snake.Direction = Direction.Up;
                        break;
                    case Keys.A:
                        if (game.Snake.Direction != Direction.Right)
                            game.Snake.Direction = Direction.Left;
                        break;
                    case Keys.S:
                        if (game.Snake.Direction != Direction.Up)
                            game.Snake.Direction = Direction.Down;
                        break;
                    case Keys.D:
                        if (game.Snake.Direction != Direction.Left)
                            game.Snake.Direction = Direction.Right;
                        break;
                    case Keys.Space:
                        bPlay_Click(sender, e);
                        break;
                }
                rotate = true;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            Logic();
            Draw();
            
            rotate = false;
            if (speed > 40)
                timerGame.Interval = speed - game.Score;
        }

        private void Logic()
        {
            if (!game.Logic())
                GameOver();
            lScore.Text = game.Score.ToString();
        }

        private void GameOver()
        {
            timerGame.Enabled = false;
            var gameOver = new GameOverForm(game.Score);
            gameOver.ShowDialog();
            bPlay.BackgroundImage = Properties.Resources.play;

            if (radioButton_WithBorders.Checked)
                game = new Game(Mode.WithBorders, hTiles, vTiles);
            else if (radioButton_Borderless.Checked)
                game = new Game(Mode.Borderless, hTiles, vTiles);
        }

        private void Draw()
        {
            DrawGrid();
            DrawSnake();
            DrawFruit();

            canvas.CreateGraphics().DrawImageUnscaled(bm, 0, 0);
            g.Clear(canvas.BackColor);
        }

        private void DrawGrid()
        {
            for (int i = 2; i < canvas.Width; i += 20)
                for (int j = 2; j < canvas.Height; j += 20)
                    g.FillRectangle(sbG, i, j, 16, 16);
        }

        private void DrawSnake()
        {
            for (int i = 0; i < game.Snake.Tail.Count; i++)
                g.FillRectangle(sbT, Zero + game.Snake.Tail[i].X * Tile, Zero + game.Snake.Tail[i].Y * Tile, TileSize, TileSize);
            g.FillRectangle(sbH, Zero + game.Snake.Head.X * Tile, Zero + game.Snake.Head.Y * Tile, TileSize, TileSize);
        }

        private void DrawFruit()
        {
            g.FillRectangle(sbF, Zero + game.Fruit.Location.X * Tile, Zero + game.Fruit.Location.Y * Tile, TileSize, TileSize);
        }
    }
}
