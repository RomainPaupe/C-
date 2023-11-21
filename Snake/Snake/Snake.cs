using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        int taille;
        int[] x;
        int[] y;
        int[] x2;
        int[] y2;
        public Snake()
        {
            taille = 1;
            x = new int[1000];
            y = new int[1000];
            x2 = new int[1000];
            y2 = new int[1000];
        }

        public int Taille { get { return taille; } set { taille = value; } }
        public int[] X { get { return x; } set { x = value; } }
        public int[] Y { get { return y; } set { y = value; } }
        public int[] X2 { get { return x2; } set { x2 = value; } }
        public int[] Y2 { get { return y2; } set { y2 = value; } }
    }
}
