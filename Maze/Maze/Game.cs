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
        public Game(int complexity, bool isSound)
        {
            InitializeComponent();
            Exit.BackColor = Color.Transparent;
            Player obj = new Player();
            obj.SetPlayerHealth(complexity);
            HealthTextBox.Text = obj.GetPlayerHealth().ToString();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
