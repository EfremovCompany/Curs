using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Minotaur
    {
        public int xPos_enemy = 160, yPos_enemy = 380;

        public bool SearchPlayer(int playerPosX, int playerPosY)
        {
            if(playerPosX == 20 && playerPosY == 200)
            {
                Move(playerPosX, playerPosY);
                return true;
            }
            return false;
        }

        private int GetWayX()
        {
            return 0;
        }

        private int GetWayY()
        {
            return 0;
        }

        private void Move(int playerPosX, int playerPosY)
        {
            int newPosEnemyX = xPos_enemy, newPosEnemyY;
            //while (xPos_enemy != playerPosX && yPos_enemy != playerPosY)
            //{
                xPos_enemy = newPosEnemyX + 20;
            //}
            GetWayX();
            GetWayY();
        }
    }
}
