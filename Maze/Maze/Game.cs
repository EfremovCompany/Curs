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
using System.Media;

namespace Maze
{
    public partial class Game : Form
    {
        public bool gameIsOver = false;
        //public Point[] array = new Point[950];
        int [ , ] bricksArray= new int[800, 800];
        private Image tex_wall;
        private Image player_icon;
        private Image minotaur_icon;
        int gameTime;
        public const int MAZE_HEIGHT = 500;
        public const int MAZE_WIDTH = 800;
        private const int enterX = 20;
        private const int enterY = 200;
        private const int exitY = 200;
        private const int exitX = 780;
        public const int step = 20;
        public const int stepPl = 10;
        SoundPlayer win;
        Player obj = new Player();
        Minotaur enemy = new Minotaur();
        private bool startMoving = false;
        

        public Game()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Game_KeyDown);
            Paint += new PaintEventHandler(Game_Paint);
            MessageBox.Show("Ready?");
            timer1.Start();
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
            if (obj.GetPosX() == enemy.xPos_enemy && obj.GetPosY() == enemy.yPos_enemy)
            {
                gameIsOver = true;
                timer1.Stop();
                MessageBox.Show("You died!", ":(");
                Program.IGame.Hide();
                Program.IMenu.Activate();
            }
            if (obj.GetPosX() == exitX && obj.GetPosY() == exitY)
            {
                gameIsOver = true;
                timer1.Stop();
                if (!Program.IMenu.isSound)
                {
                    win = new SoundPlayer(Properties.Resources.win);
                    win.Play();
                }
                MessageBox.Show("Winner! Your time - " + gameTime.ToString(), "Good job!");
                Program.IGame.Hide();
                Program.IMenu.Activate();
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
                if (obj.GetPosX() > 0)
                {
                    if (obj.GetPosX() - step < 0)
                    {
                        obj.MovePlayer(20, obj.GetPosY());
                        MessageBox.Show("There is no escape!");
                    }
                    else if (bricksArray[obj.GetPosX() - step, obj.GetPosY()] == 0)
                    {
                        obj.MovePlayer(obj.GetPosX() - stepPl, obj.GetPosY());
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (obj.GetPosX() <= MAZE_WIDTH)
                 {
                    if (bricksArray[obj.GetPosX() + step, obj.GetPosY()] == 0)
                    {
                        obj.MovePlayer(obj.GetPosX() + stepPl, obj.GetPosY());
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (obj.GetPosY() > step)
                {
                    if (bricksArray[obj.GetPosX(), obj.GetPosY() - step] == 0)
                    {
                        obj.MovePlayer(obj.GetPosX(), obj.GetPosY() - stepPl);
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (obj.GetPosY() < MAZE_HEIGHT)
                {
                    if (bricksArray[obj.GetPosX(), obj.GetPosY() + step] == 0)
                    {
                        obj.MovePlayer(obj.GetPosX(), obj.GetPosY() + stepPl);
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
            MinotaurAI();
            this.Refresh();
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

        private void MinotaurAI()
        {
            if (obj.GetPosX() == enterX && obj.GetPosY() == enterY)
            {
                startMoving = true;
            }
            if (startMoving)
            {
                if (enemy.GetWayX() > 20)
                {
                    if (bricksArray[enemy.GetWayX() - step, enemy.GetWayY()] == 0)
                    {
                        enemy.MoveMinotaur(enemy.GetWayX() - step, enemy.GetWayY());
                        return;
                    }
                }
                if (enemy.GetWayX() <= MAZE_WIDTH)
                {
                    if (bricksArray[enemy.GetWayX() + step, enemy.GetWayY()] == 0)
                    {
                        enemy.MoveMinotaur(enemy.GetWayX() + step, enemy.GetWayY());
                        return;
                    }
                }
                if (enemy.GetWayY() > step)
                {
                    if (bricksArray[enemy.GetWayX(), enemy.GetWayY() - step] == 0)
                    {
                        enemy.MoveMinotaur(enemy.GetWayX(), enemy.GetWayY() - step);
                        return;
                    }
                } 
                if (enemy.GetWayY() < exitX)
                {
                    if (bricksArray[enemy.GetWayX(), enemy.GetWayY() + step] == 0)
                    {
                        enemy.MoveMinotaur(enemy.GetWayX(), enemy.GetWayY() + step);
                        return;
                    }
                }
            }
        }

        private void LoadAssets()
        {
            tex_wall = Maze.Properties.Resources.brick_wall;
            player_icon = Maze.Properties.Resources.PlayerIcon;
            minotaur_icon = Maze.Properties.Resources.MinotaurIcon;
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            LoadAssets();
            e.Graphics.DrawImage(minotaur_icon, enemy.xPos_enemy, enemy.yPos_enemy);
            e.Graphics.DrawImage(player_icon, obj.GetPosX(), obj.GetPosY());
            int xPos;
            int yPos;

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
                        bricksArray[xPos, yPos] = 1;
                        e.Graphics.DrawImage(tex_wall, xPos, yPos);
                        //array[j] = new Point(xPos, yPos);
                    }
                    else bricksArray[xPos, yPos] = 0;
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