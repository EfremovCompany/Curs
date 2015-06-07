using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Maze
{
    public partial class Game : Form
    {
        private Image tex_wall;
        int gameTime;
        int xPos;
        int yPos;
        public const int MAZE_HEIGHT = 500;
        public const int MAZE_WIDTH = 800;
        public const int step = 20;
        public const int stepPl = 10;
        public Game()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Game_KeyDown);
            Paint += new PaintEventHandler(Game_Paint);
            MessageBox.Show("Ready?");
            GenerateMap();
            timer1.Start();
            Player obj = new Player();
            obj.SetPlayerHealth(GetComplexity);
            //HealthTextBox.Text = obj.GetPlayerHealth().ToString();
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void Game_Over()
        {
            if (rect.Left == 780 && rect.Top == 200)
            {
                timer1.Stop();
                MessageBox.Show("Winner!", "Good job!");
                Program.IMenu.Hide();
            }
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                Program.IMenu.Activate();
                Program.IGame.Hide();
            }
            if (e.KeyCode == Keys.Left)
            {
                bool goLeft = true;
                if (rect.Left > 0)
                {
                    for (int i = 0; i < array.Length; ++i)
                    {
                        if (array[i].X == rect.Left - step && array[i].Y == rect.Top)
                        {
                            goLeft = false;
                        }
                    }
                    if (goLeft)
                    {
                        rect.Location = new Point(rect.Left - stepPl, rect.Top);
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                bool goRight = true;
                if (rect.Left <= MAZE_WIDTH)
                {
                    for (int i = 0; i < array.Length;++i)
                    {
                        if (array[i].X == rect.Left + step && array[i].Y == rect.Top)
                        {
                            goRight = false;
                        }
                    }
                    if (goRight)
                    {
                        rect.Location = new Point(rect.Left + stepPl, rect.Top);
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                bool goUp = true;
                if (rect.Top > step)
                {
                    for (int i = 0; i < array.Length; ++i)
                    {
                        if (array[i].X == rect.Left && array[i].Y == rect.Top - step)
                        {
                            goUp = false;
                        }
                    }
                    if (goUp)
                    {
                        rect.Location = new Point(rect.Left, rect.Top - stepPl);
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                bool goDown = true;
                if (rect.Top < MAZE_HEIGHT)
                {
                    for (int i = 0; i < array.Length; ++i)
                    {
                        if (array[i].X == rect.Left 
                            && array[i].Y == rect.Top + step)
                        {
                            goDown = false;
                        }
                    }
                    if (goDown)
                    {
                        rect.Location = new Point(rect.Left, rect.Top + stepPl);
                    }
                }
            }
            Game_Over();
            Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTime++;
            SetTime();
        }
        private void SetTime()
        {
            if (gameTime / 60 < 1)
            {
                if (gameTime < 10)
                    PrintTime.Text = "0:0" + gameTime.ToString();
                else
                    PrintTime.Text = "0:" + gameTime.ToString();
            }
            else
            {
                if (gameTime % 60 < 10)
                    PrintTime.Text = (gameTime / 60).ToString() + ":0" + (gameTime % 60).ToString();
                else
                    PrintTime.Text = (gameTime / 60).ToString() + ":" + (gameTime % 60).ToString();
            }
        }
        public void ReturnToGame()
        {
            timer1.Start();
        }
        private int GetComplexity
        {
            get
            {
                return Program.IMenu.complexity;
            }
        }
        private bool GetSound
        {
            get
            {
                return Program.IMenu.isSound;
            }
        }
        private void GenerateMap()
        {
         
        }

        private void LoadAssets()
        {
            tex_wall = Maze.Properties.Resources.brick_wall;
        }

        Rectangle rect = new Rectangle(0, step, 19, 19);
        SolidBrush solidBrush = new SolidBrush(
        Color.FromArgb(255, 255, 0, step));
        Pen pen = new Pen(Color.Green);
        Point[] array = new Point[950];
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            tex_wall = Maze.Properties.Resources.brick_wall;
            e.Graphics.DrawEllipse(pen, rect);
            e.Graphics.FillEllipse(solidBrush, rect);
            
            xPos = step;
            yPos = step;
            int i = 0, j = 0;
            string[] mapLines = File.ReadAllLines("../../Resources/Map.txt");
            foreach (string str in mapLines)
            {
                foreach(char s in mapLines[i])
                {
                    
                    if (s == 'X')
                    {
                        e.Graphics.DrawImage(tex_wall, xPos, yPos);
                        array[j] = new Point(xPos, yPos);
                    }
                    xPos += step;
                    j++;
                }
                yPos += step;
                xPos = step;
                i++;
            }
        }
    }
}