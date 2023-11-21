using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    internal class Noeud
    {
        char pix;
        int frequenceDansImg;
        Noeud gauche;
        Noeud droit;

        public Noeud(char pixStr, int frequenceDansImg)
        {
            this.frequenceDansImg = frequenceDansImg;
            this.pix = pixStr;
            gauche = null;
            droit = null;
        }

        public Noeud(int frequenceDansImg, Noeud gauche, Noeud droit)
        {
            this.frequenceDansImg = frequenceDansImg;
            this.gauche = gauche;
            this.droit = droit;
        }

        public Noeud() { }

        public char Pix
        {
            get { return pix; }
            set { pix = value; }
        }
        public int FrequenceDansImg
        {
            get { return frequenceDansImg; }
            set { frequenceDansImg = value; }
        }
        public Noeud Droit
        {
            get { return droit; }
            set { droit = value; }
        }
        public Noeud Gauche
        {
            get { return gauche; }
            set { gauche = value; }
        }
    }
}
