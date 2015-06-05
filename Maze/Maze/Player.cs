using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Player
    {
        private int m_health;
        private int yCoord, xCoord;
        public int GetPlayerHealth()
        {
            return m_health;
        }

        public void SetPlayerHealth(int complexity)
        {
            if (complexity == 1)
            {
                m_health = 3;
            }
            if (complexity == 2)
            {
                m_health = 2;
            }
            if (complexity == 3)
            {
                m_health = 1;
            }
        }

        public bool IfHaveKey()
        {
            return false;
        }
        public void SetCoordinates(int x, int y)
        {
            if (x > 600 || x < 0)
            {
                return;
            }
            else
            {
                xCoord = x;
            }
            if (y > 1000 || y < 0)
            {
                return;
            }
            else
            {
                yCoord = y;
            }
        }

        public void GetPos()
        {

        }
    }
}
