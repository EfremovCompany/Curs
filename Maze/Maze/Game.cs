using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Game : Form
    {
        private Image m_wall;
        private Image m_player;
        private Image m_enemy;
        int gameTime;

        public Game()
        {
            InitializeComponent();
            MessageBox.Show("Ready?");
            GenerateMap();
            timer1.Start();
            //Exit.BackColor = Color.Transparent;
            Player obj = new Player();
            //if (!LoadImage(m_wall, "../../Resources/Map.txt"))
            //{
            //    Application.Exit();
            //}
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
                PauseMenu PauseForm = new PauseMenu();
                PauseForm.Show();
            }
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
            //xPos = 20;
            //yPos = 50;
            //string[] mapLines = System.IO.File.ReadAllLines("../../Resources/Map.txt");
            //for (int i = 1; i < System.IO.File.ReadAllLines("../../Resources/Map.txt").Length; i++)
            //{
            //    foreach(char str in mapLines[i])
            //    {
            //        if (str == 'X')
            //        {
            //            Point ulCorner = new Point(xPos, yPos);
            //            xPos = xPos + 25;
            //            yPos = yPos + 25;
            //        }
            //    }
            //}
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics wall = e.Graphics;
            int xPos = 20;
            int yPos = 50;
            string[] mapLines = System.IO.File.ReadAllLines("../../Resources/Map.txt");
            for (int i = 1; i < System.IO.File.ReadAllLines("../../Resources/Map.txt").Length; i++)
            {
                foreach (char str in mapLines[i-1])
                {
                    if (str == 'X')
                    {
                        //MessageBox.Show(xPos.ToString() + yPos.ToString());
                        //Graphics wall = e.Graphics;
                        //Image wall = Image.FromFile("../../Resources/brick_wall.png");
                        wall.DrawImage(Image.FromFile("../../Resources/brick_wall.png"), xPos, yPos);
                    }
                    xPos = xPos + 25;  
                }
                xPos = 20;
                yPos = yPos + 25;
                //MessageBox.Show(yPos.ToString() + xPos.ToString());
            }
        }
        private bool LoadImage(Image image, string fileName)
        {
            try
            {
                image = Image.FromFile(fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("Картинки не могут быть загружены!", "Ошибка");
                return false;
            }

            return true;
        }
    }
}