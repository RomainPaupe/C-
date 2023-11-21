using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naha
{

    public partial class Pacman : Form
    {
        string file = "C:/Users/rpaup/Desktop/Naha/Naha/pacman.txt";
        string mure = "C:/Users/rpaup/Desktop/Naha/Naha/Images/Pacman/mure.bmp";
        string point = "C:/Users/rpaup/Desktop/Naha/Naha/Images/Pacman/point.bmp";
        string pc = "C:/Users/rpaup/Desktop/Naha/Naha/Images/Pacman/pacman.bmp";
        string vide = "C:/Users/rpaup/Desktop/Naha/Naha/Images/Pacman/vide.bmp";
        public Pacman()
        {
            InitializeComponent();
            affichage();
        }

        public void affichage()
        {
            Image objet = Image.FromFile(vide);
            string fichier = File.ReadAllText(file);
            int j = 0;
            for(int i = 0; i < fichier.Length; i++)
            {
                if (fichier[i] == '.') j++;
                else if (fichier[i] == '/') objet = Image.FromFile(mure);
                else if (fichier[i] == 'O') objet = Image.FromFile(point);
                else if (fichier[i] == 'P') objet = Image.FromFile(pc);
            }
            
        }
    }
}
