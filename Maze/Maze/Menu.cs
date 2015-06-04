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
        
        public Menu()
        {
            InitializeComponent();
            SoundOFF.Visible = false;
        }
        private void SoundOFF_Click(object sender, EventArgs e)
        {
            SoundOFF.Visible = false;
            SoundON.Visible = true;
            isSound = true;
            intro.PlayLooping();
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            complexity = 1;
            Program.IGame = new Game();
            Program.IGame.ShowDialog();
            Hide();
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
            SoundON.Visible = false;
            SoundOFF.Visible = true;
            isSound = false;
            intro.Stop();
        }
    }
}
