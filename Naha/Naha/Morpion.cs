using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace Naha
{
    public partial class Morpion : Form
    {
        int counter = 0;
        int modeDeJeu = 1;
        int nbManche = 0;
        int score1 = 0;
        int score2 = 0;
        int nbTour = 0;
        string[,] jeu = { { "", "", "", },{ "", "", "" },{ "","","" } };
        public Morpion()
        {
            InitializeComponent();
        }
        
        public void tour(int i, int j)
        {

            if (modeDeJeu == 1)
            {
                if (counter == 0 && jeu[i, j] == "")
                {
                    jeu[i, j] = "X";
                    label_phrasefin.Text = "C'est au joueur 2 de jouer";
                    counter++;
                }
                else if (counter == 1 && jeu[i, j] == "")
                {
                    jeu[i, j] = "O";
                    label_phrasefin.Text = "C'est au joueur 1 de jouer";
                    counter--;
                }
            }

            else if ((modeDeJeu == 2 || modeDeJeu == 3 || modeDeJeu == 4) && counter !=2)
            {
                if (jeu[i, j] == "")
                {
                    jeu[i, j] = "X";
                    nbTour++;
                    surveillance();
                    if (nbTour >= 8) finpartie(2);
                    else
                    {
                        switch (modeDeJeu)
                        {
                            case 2:
                                robotLev1(caseLibre());
                                break;
                            case 3:
                                robotLev2(caseLibre());
                                break;
                            case 4:
                                robotLev3(caseLibre());
                                break;
                        }
                    }
                }
            }
            surveillance();
            if(nbTour >= 8) finpartie(2);
            nbTour++;
            affichage();
        }
        public void robotLev1(int[] plateau)
        {
            var random = new Random();
            int a = plateau[random.Next(plateau.Length)];

            remplireChoixRobot(a);
        }
        public void robotLev2(int[] plateau)
        {
            bool resul = false;
            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    int y = j + 1;
                    if (y == 3) y = 0;

                    int z = y + 1;
                    if (z == 3) z = 0;

                    int x = 2 - j;

                    int c = x - 1;
                    if (c == -1) c = 2;

                    int v = c - 1;
                    if(v == -1) v = 2;

                    for (int k = 0; k < 2; k++)
                    {
                        string index = "";
                        if (k == 0) index = "O";
                        else if (k == 1) index = "X";
                        //Verfifie ligne
                        if (jeu[i, j] == jeu[i, y] && jeu[i, j] == index && jeu[i, z] == "")
                        {
                            jeu[i, z] = "O";
                            resul = true;
                        }
                        //Verifie colonne
                        else if (jeu[j, i] == jeu[y, i] && jeu[j, i] != index && jeu[z, i] == "")
                        {
                            jeu[z, i] = "O";
                            resul = true;
                        }
                        //Verifie diagonale de gauche a droite
                        else if (jeu[j, j] == jeu[y, y] && jeu[j, j] != index && jeu[z, z] == "")
                        {
                            jeu[z, z] = "O";
                            resul = true;
                        }
                        //Verfifie diagonale de droite a gauche
                        else if (jeu[x, j] == jeu[c, y] && jeu[x, j] != index && jeu[v, z] == "")
                        {
                            jeu[v, z] = "O";
                            resul = true;
                        }
                    }
                    if (resul) j = 10;
                }
                if(resul) i = 10;
            }

            if (resul) affichage();
            else robotLev1(caseLibre());
        }
        public void robotLev3(int[] plateau)
        {

        }
        public void remplireChoixRobot(int a)
        {
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a == count) jeu[i, j] = "O";
                    count++;
                }
            }
        }
        public int[] caseLibre()
        {
            int[] tab = new int[9];

            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jeu[i, j] == "")
                    {
                        tab[count] = (i * 3) + j + 1;
                        count++;
                    }
                }
            }

            int[] b = new int[count];
            for (int k = 0; k < count; k++)
            {
                b[k] = tab[k];
            }

            return b;
        }
        public void affichage()
        {
            case00.Text = jeu[0, 0];
            case01.Text = jeu[0, 1];
            case02.Text = jeu[0, 2];
            case10.Text = jeu[1, 0];
            case11.Text = jeu[1, 1];
            case12.Text = jeu[1, 2];
            case20.Text = jeu[2, 0];
            case21.Text = jeu[2, 1];
            case22.Text = jeu[2, 2];
        }
        public void finpartie(int player)
        {
            if (player == 0)
            {
                label_phrasefin.Text = "Fin de la partie, le joueur 2 à gagner !";
                score2++;
            }
            else if (player == 1)
            {
                label_phrasefin.Text = "Fin de la partie, le joueur 1 à gagner !";
                score1++;
            }
            else if (player == 2)
            {
                label_phrasefin.Text = "Fin de la partie, matche nul";
            }

            label_score.Text = "Score :\nJoueur 1 = " + score1 + "\nJoueur 2 = " + score2;
            counter = 2;
            nbManche++;

        }
        public void surveillance()
        {
            affichage();
            if (case00.Text == case01.Text && case01.Text == case02.Text && case00.Text != "")
            {
                case00.BackColor = Color.Red;
                case01.BackColor = Color.Red;
                case02.BackColor = Color.Red;
                finpartie(counter);
            }

            if (case10.Text == case11.Text && case11.Text == case12.Text && case10.Text != "")
            {
                case10.BackColor = Color.Red;
                case11.BackColor = Color.Red;
                case12.BackColor = Color.Red;
                finpartie(counter);
            }

            if (case20.Text == case21.Text && case21.Text == case22.Text && case20.Text != "")
            {
                case20.BackColor = Color.Red;
                case21.BackColor = Color.Red;
                case22.BackColor = Color.Red;
                finpartie(counter); 
            }

            if (case00.Text == case10.Text && case10.Text == case20.Text && case00.Text != "")
            {
                case00.BackColor = Color.Red;
                case10.BackColor = Color.Red;
                case20.BackColor = Color.Red;
                finpartie(counter);
            }

            if (case01.Text == case11.Text && case11.Text == case21.Text && case01.Text != "")
            {
                case01.BackColor = Color.Red;
                case11.BackColor = Color.Red;
                case21.BackColor = Color.Red;
                finpartie(counter);
            }

            if (case02.Text == case12.Text && case12.Text == case22.Text && case02.Text != "")
            {
                case02.BackColor = Color.Red;
                case12.BackColor = Color.Red;
                case22.BackColor = Color.Red;
                finpartie(counter);
            }

            if (case00.Text == case11.Text && case11.Text == case22.Text && case00.Text != "")
            {
                case00.BackColor = Color.Red;
                case11.BackColor = Color.Red;
                case22.BackColor = Color.Red;
                finpartie(counter);
            }

            if (case02.Text == case11.Text && case11.Text == case20.Text && case02.Text != "")
            {
                case02.BackColor = Color.Red;
                case11.BackColor = Color.Red;
                case20.BackColor = Color.Red;
                finpartie(counter);
            }
        }

        #region surveillance des cases
        private void case00_Click(object sender, EventArgs e)
        {
            tour(0,0);
        }

        private void case01_Click(object sender, EventArgs e)
        {
            tour(0,1);
        }

        private void case02_Click(object sender, EventArgs e)
        {
            tour(0,2);
        }

        private void case10_Click(object sender, EventArgs e)
        {
            tour(1,0);
        }

        private void case11_Click(object sender, EventArgs e)
        {
            tour(1,1);
        }

        private void case12_Click(object sender, EventArgs e)
        {
            tour(1,2);
        }

        private void case20_Click(object sender, EventArgs e)
        {
            tour(2,0);
        }

        private void case21_Click(object sender, EventArgs e)
        {
            tour(2,1);
        }

        private void case22_Click(object sender, EventArgs e)
        {
            tour(2,2);
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            initNewManche();
        } 
        public void initNewGame()
        {
            initNewManche();
            counter = 0;
            nbManche = 0;
            score1 = 0;
            score2 = 0;
            label_score.Text = "Score :\nJoueur 1 = " + score1 + "\nJoueur 2 = " + score2;
            
        }
        public void initNewManche()
        {
            #region case remis a blanc
            case00.BackColor = Color.White;
            case01.BackColor = Color.White;
            case02.BackColor = Color.White;
            case10.BackColor = Color.White;
            case11.BackColor = Color.White;
            case12.BackColor = Color.White;
            case20.BackColor = Color.White;
            case21.BackColor = Color.White;
            case22.BackColor = Color.White;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    jeu[i, j] = "";
                }
            }
            affichage();
            #endregion

            if (nbManche % 2 == 0) counter = 0;
            else counter = 1;

            if (counter == 0) label_phrasefin.Text = "C'est au joueur 1 de jouer";
            else label_phrasefin.Text = "C'est au joueur 2 de jouer";

            nbTour = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var acc = new Menu();
            acc.ShowDialog();
            this.Hide();
        }
        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeDeJeu = 1;
            initNewGame();
        }
        private void contreMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeDeJeu = 2;
            initNewGame();
        }
        private void joueurMoyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeDeJeu = 3;
            initNewGame();
        }
        private void joueurHardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeDeJeu = 4;
            initNewGame();
        }
    }
}
