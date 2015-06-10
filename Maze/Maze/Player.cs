using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Player
    {
        private int yPos = 20, xPos = 0;

        public void MovePlayer(int newPosX, int newPosY)
        {
            xPos = newPosX;
            yPos = newPosY;
        }

        public int GetPosX()
        {
            return xPos;
        }

        public int GetPosY()
        {
            return yPos;
        }
    }
}
