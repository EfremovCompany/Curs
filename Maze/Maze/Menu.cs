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
        bool isSound = true;
        
        public Menu()
        {
            InitializeComponent();
            SoundOFF.Visible = false;
        }

        private void SoundOFF_Click(object sender, EventArgs e)
        {
            SoundOFF.Visible = false;
            SoundON.Visible = true;
            intro.PlayLooping();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            intro.Stop();
        }

    }
}
