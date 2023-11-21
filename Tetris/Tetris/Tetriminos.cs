using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Tetriminos
    {
        Color paint;
        int[] caseX = new int[4];
        int[] caseY = new int[4];

        public Tetriminos(Color paint, int[] caseX, int[] caseY)
        {
            this.paint = paint;
            this.caseX = caseX;
            this.caseY = caseY;
        }
        
        public Color Paint { get { return paint; } }
        public int[] CaseX { get { return caseX; } set { caseX = value; } }
        public int[] CaseY { get { return caseY; } set { caseY = value; } }
    }
}
