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

        public void GetPos()
        {

        }
    }
}
