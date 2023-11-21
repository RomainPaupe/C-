using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    public class Jeton
    {
        char lettre;
        int score;

        public char Lettre
        {
            get { return lettre; }
        }

        public Jeton(char lettre, int score) 
        {
            this.lettre = lettre;
            this.score = score;
        }

        

        public override string ToString() // Décris le jeton appelé
        {
            string resul = "Lettre : " + this.lettre + "\nScore : " + this.score;
            return resul;
        }


    }
}
