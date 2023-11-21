using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naha
{
    internal class biere
    {
        string degre;
        string nom;
        string file;

        public biere(string nom, string degre, string file)
        {
            this.nom = nom;
            this.degre = degre;
            this.file = file;
        }
        public string Degre
        {
            set { degre = value; }
            get { return degre; }
        }

        public string File
        {
            set { file = value; }
            get { return file; }
        }

        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }


    }
}
