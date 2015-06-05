using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Maze
{
    public partial class Menu : Form
    {
        SoundPlayer intro;
        public bool isSound;
        public int complexity;
        public bool isStarted = false;
        
        public Menu()
        {
            InitializeComponent();
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            complexity = 1;
            Continue.Visible = true;
            isStarted = true;
            Program.IGame = new Game();
            Program.IGame.ShowDialog();
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                Program.IGame.Show();
                Program.IGame.ReturnToGame();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            intro = new SoundPlayer(Properties.Resources.intro1);
            intro.PlayLooping();
        }
        private void SoundON_Click(object sender, EventArgs e)
        {
            if (isSound)
            {
                isSound = false;
                intro.PlayLooping();
            }
            else
            {
                isSound = true;
                intro.Stop();
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Program.IGame.ReturnToGame();
            }
        }

    }
}
