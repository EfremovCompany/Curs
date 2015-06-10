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
       
            MoveMinotaur(playerPosX, playerPosY);
         
            return false;
        }

        public int GetWayX()
        {
            return xPos_enemy;
        }

        public int GetWayY()
        {
            return yPos_enemy;
        }

        public void MoveMinotaur(int minotaurPosX, int minotaurPosY)
        {
            xPos_enemy = minotaurPosX;
            yPos_enemy = minotaurPosY;
        }
    }
}
