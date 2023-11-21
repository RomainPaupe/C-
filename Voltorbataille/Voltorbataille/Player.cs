using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltorbataille
{
    internal class Player
    {
        int x;
        int y;
        int score;
        int nbmove;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int NbMove
        {
            get { return nbmove; }
            set { nbmove = value; }
        }
        public Player()
        {
            x = 0;
            y = 0;
            score = 0;
            nbmove = 0;
        }

        public int AddScore(int points)
        {
            int oldScore = score;
            if (score == 0) score = points;
            else score *= points;
            return score - oldScore;
        }

        public void Move(int x, int y)
        {
            if(x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
