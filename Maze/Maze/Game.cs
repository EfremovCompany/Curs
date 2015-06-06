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
        private Graphics m_drawHandle;
        private Image tex_wall;
        int gameTime;
        int xPos;
        int yPos;
        public const int CANVAS_WIDTH = 600;
        public const int CANVAS_HEIGHT = 1000;
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
                rect.Location = new Point(rect.Left - 5, rect.Top);
            }
            if (e.KeyCode == Keys.Right)
            {
                rect.Location = new Point(rect.Left + 5, rect.Top);
            }
            if (e.KeyCode == Keys.Up)
            {
                rect.Location = new Point(rect.Left, rect.Top - 5);
            }
            if (e.KeyCode == Keys.Down)
            {
                rect.Location = new Point(rect.Left, rect.Top + 5);
            }
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

        Rectangle rect = new Rectangle(0, 0, 25, 25);

        Pen pen = new Pen(Color.Green);
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            tex_wall = Maze.Properties.Resources.brick_wall;
            e.Graphics.DrawEllipse(pen, rect);
            
            xPos = 20;
            yPos = 20;
            int i = 0;
            string[] mapLines = File.ReadAllLines("../../Resources/Map.txt");
            foreach (string str in mapLines)
            {
                foreach(char s in mapLines[i])
                {
                    
                    if (s == 'X')
                    {
                        e.Graphics.DrawImage(tex_wall, xPos, yPos);
                    }
                    xPos += 20;
                    
                }
                yPos += 20;
                xPos = 20;
                i++;
            }
       
        }
    }
}