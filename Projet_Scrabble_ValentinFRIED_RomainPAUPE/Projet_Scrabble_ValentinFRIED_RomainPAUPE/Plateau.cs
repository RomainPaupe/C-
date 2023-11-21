using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    public class Plateau
    {
        string[,] plateau = new string[15, 15]; // saisie des lettres
        int[,] plateauScore = new int[15, 15]; // poids et couleurs

        public string[,] Plateauprop
        {
            get { return plateau; }
        }
        public int[,] PlateauScoreprop
        {
            get { return plateauScore; }
        }

        public Plateau(string fichier)
        {
            try
            {
                string[] lecture_fichier = File.ReadAllLines(fichier);
                for (int i = 0; i < plateauScore.GetLength(0); i++)
                {
                    string lecture_ligne = lecture_fichier[i];
                    for (int j = 0; j < plateauScore.GetLength(1); j++)
                    {
                        plateauScore[i, j] = Convert.ToInt32(lecture_ligne[j]);
                        plateau[i, j] = " _ ";
                    }
                }
                plateau[7, 7] = " . ";
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine("Le fichier n'existe pas");
                Console.WriteLine(f.Message);
            }
        }

        public void Affichage(int nombre_de_joueur, Jeu partie)
        {
            Console.WriteLine("   0  1  2  3  4  5  6  7  8  9 10 11 12 13 14", Console.BackgroundColor = ConsoleColor.Black);
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                if (i < 10) Console.Write(i.ToString() + " ", Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.White);
                else Console.Write(i.ToString(), Console.BackgroundColor = ConsoleColor.Black);
                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    int a = plateauScore[i, j];
                    switch (a)
                    {
                        case (48):
                            Console.Write(plateau[i, j].ToString(), Console.BackgroundColor = ConsoleColor.Green, Console.ForegroundColor = ConsoleColor.Black);
                            break;
                        case (49):
                            Console.Write(plateau[i, j].ToString(), Console.BackgroundColor = ConsoleColor.Blue, Console.ForegroundColor = ConsoleColor.Black);
                            break;
                        case (50):
                            Console.Write(plateau[i, j].ToString(), Console.BackgroundColor = ConsoleColor.DarkBlue, Console.ForegroundColor = ConsoleColor.Black);
                            break;
                        case (51):
                            Console.Write(plateau[i, j].ToString(), Console.BackgroundColor = ConsoleColor.Yellow, Console.ForegroundColor = ConsoleColor.Black);
                            break;
                        case (52):
                            Console.Write(plateau[i, j].ToString(), Console.BackgroundColor = ConsoleColor.Red, Console.ForegroundColor = ConsoleColor.Black);
                            break;
                        case (53):
                            Console.Write(plateau[i, j].ToString(), Console.BackgroundColor = ConsoleColor.White, Console.ForegroundColor = ConsoleColor.Black);
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    if (j == 14) Console.Write(i.ToString(), Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.White);
                }
                Console.Write("", Console.BackgroundColor = ConsoleColor.Black);
                //if (i <= nombre_de_joueur)
                //{
                    switch(i)
                    {
                        case 1:
                            Console.Write("               Score " + partie.J1.Nom + " : " + partie.J1.Score + "  Main courante : " + partie.J1.Affichage_Main_Courante()); // main courante affichage
                            break;

                        case 2:
                            Console.Write("               Score " + partie.J2.Nom + " : " + partie.J2.Score + "  Main courante : " + partie.J2.Affichage_Main_Courante());
                            break;

                        case 3:
                        if (i <= nombre_de_joueur)
                        {
                            Console.Write("               Score " + partie.J3.Nom + " : " + partie.J3.Score + "  Main courante : " + partie.J3.Affichage_Main_Courante());
                        }
                        break;
                            
                        case 4:
                        if (i <= nombre_de_joueur)
                        {
                            Console.Write("               Score " + partie.J4.Nom + " : " + partie.J4.Score + "  Main courante : " + partie.J4.Affichage_Main_Courante());
                        }
                        break;

                        case 6:
                            Console.Write("               Code couleur :  " ); // main courante affichage
                            break;

                        case 7:
                            Console.Write("               "); Console.Write("   " , Console.BackgroundColor = ConsoleColor.Green); Console.Write(" : Pas de multiplicateur",Console.BackgroundColor = ConsoleColor.Black);
                            break;

                        case 8:
                            Console.Write("               "); Console.Write("   ", Console.BackgroundColor = ConsoleColor.Yellow); Console.Write(" : Mot compte double", Console.BackgroundColor = ConsoleColor.Black);
                            break;

                        case 9:
                            Console.Write("               "); Console.Write("   ", Console.BackgroundColor = ConsoleColor.Red); Console.Write(" : Mot comtpe triple", Console.BackgroundColor = ConsoleColor.Black);
                            break;

                        case 10:
                            Console.Write("              "); Console.Write("   ", Console.BackgroundColor = ConsoleColor.Blue); Console.Write(" : Lettre comtpe double", Console.BackgroundColor = ConsoleColor.Black);
                            break;

                        case 11:
                            Console.Write("              "); Console.Write("   ", Console.BackgroundColor = ConsoleColor.DarkBlue); Console.Write(" : Lettre comtpe triple", Console.BackgroundColor = ConsoleColor.Black);
                            break;

                    default:
                            break;
                    }
                //}


                Console.Write("\n", Console.BackgroundColor = ConsoleColor.Black);
                if (i == 14) Console.Write("   0  1  2  3  4  5  6  7  8  9 10 11 12 13 14", Console.ForegroundColor = ConsoleColor.White);
            }
        }

        public void Saisie_Mot(char direction, string mot, int ligne, int colonne)
        {
            if (direction == 'V')
            {
                int compteur = 0;
                for (int i = ligne; i < mot.Length + ligne; i++)
                {
                    string remplacement = " " + mot[compteur] + " ";
                    this.plateau[i, colonne] = remplacement;
                    compteur++;
                }
            }
            else if (direction == 'H')
            {
                int compteur = 0;
                for (int j = colonne; j < mot.Length + colonne; j++)
                {
                    string remplacement = " " + mot[compteur] + " ";
                    this.plateau[ligne, j] = remplacement;
                    compteur++;
                }
            }
        }

        public bool Test_Plateau(string mot, int ligne, int colonne, char direction)
        {
            bool resul = false;
            if (this.Test_Longueur(mot, ligne, colonne, direction) == false)
            {
                Console.WriteLine(mot +" dépasse du plateau, veuillez réessayer\n");
                return resul;
            }
            else if (this.Test_Coherence_Lettre(mot, ligne, colonne, direction) == false)
            {
                Console.WriteLine(mot + " ne peut être placé ici, veuillez reesayer\n");
                return resul;
            }
            else if (this.Test_Nouveau_Mot_Cree(mot, ligne, colonne, direction) == false)
            {
                Console.WriteLine("\nLe(s) nouveau(x) créé(s) n'existe(nt) pas dans le dictionnaire, veuillez reesayer\n");
                return resul;
            }
            else if (this.Test_Mot_Croise(mot, ligne, colonne, direction) == false)
            {
                Console.WriteLine(mot + " n'est pas collé à un mot déjà existant sur le plateau, veuillez reesayer\n");
                return resul;
            }
            resul = true;
            return resul;
        }

        public bool Test_Longueur(string mot, int ligne, int colonne, char direction)
        {
            bool condition = false;
            int longueur = mot.Length;
            if(direction == 'H')
            {
                if (colonne + longueur > 15)
                {
                    condition = false;
                }
                else condition = true;
            }
            else if (direction == 'V')
            {
                if (ligne + longueur > 15)
                {
                    condition = false;
                }
                else condition = true;
            }
            return condition;
            
        }
        public bool Test_Coherence_Lettre(string mot, int ligne, int colonne, char direction)
        {
            int counter = 0;
            bool condition = false;
            int longeur = mot.Length;
            if (direction == 'H')
            {
                for (int i = colonne; i < colonne + longeur; i++)
                {
                    if (mot[counter] == (this.plateau[ligne, i])[1] || (this.plateau[ligne, i])[1] == '_' || (this.plateau[ligne, i])[1] == '.') condition = true;
                    else return false;
                    counter++;
                }
            }
            else if (direction == 'V')
            {
                for (int i = ligne; i < ligne + longeur; i++)
                {
                    if (mot[counter] == (this.plateau[i, colonne])[1] || (this.plateau[i, colonne])[1] == '_' || (this.plateau[i, colonne])[1] == '.') condition = true;
                    else return false;
                    counter++;
                }
            }
            return condition;
        }

        public bool Test_Mot_Croise(string mot, int ligne, int colonne, char direction)
        {
            int counter = 0;
            bool condition = false;

            if (direction == 'H')
            {
                for (int i = colonne; i < colonne + mot.Length; i++)
                {
                    if (mot[counter] == (this.plateau[ligne, i])[1] || (this.plateau[i, colonne])[1] == '.')
                    {
                        condition = true;
                        return condition;
                    }
                    counter++;
                }
            }

            else if (direction == 'V')
            {
                for (int i = ligne; i < ligne + mot.Length; i++)
                {
                    if (mot[counter] == (this.plateau[i, colonne])[1] || (this.plateau[i, colonne])[1] == '.')
                    {
                        condition = true;
                        return condition;
                    }
                    counter++;
                }
            }
            return condition;
        }
        public bool Test_Nouveau_Mot_Cree(string mot, int ligne, int colonne, char direction)
        {
            int counter = 0;
            bool condition = false;
            int longeur = mot.Length;
            if (direction == 'H')
            {
                if (Verif_ligne(mot, ligne, colonne, direction, counter))
                {
                    for (int i = colonne; i < colonne + longeur; i++)
                    {
                        if (mot[counter] != (this.plateau[ligne, i])[1])
                        {
                            if (Verif_colonne(mot, ligne, colonne, direction, counter) == false) return condition;
                        }
                        counter++;
                    }
                    condition = true;
                }
            }

            else if (direction == 'V')
            {
                if (Verif_colonne(mot, ligne, colonne, direction, counter))
                {
                    for (int i = ligne; i < ligne + longeur; i++)
                    {
                        if (mot[counter] != plateau[i, colonne][1])
                        {
                            if (Verif_ligne(mot, ligne, colonne, direction, counter) == false) return condition;
                        }
                        counter++;
                    }
                    condition = true;
                }
            }
            return condition;
        }

        public bool Verif_ligne(string mot, int ligne, int colonne, char direction, int counter)
        {
            bool condition = false;
            if (direction == 'H')
            {
                string mot_a_tester = "";
                if (plateau[ligne, colonne - 1][1] != '_' || plateau[ligne, colonne + mot.Length][1] != '_')
                {
                    int colonne_left = colonne - 1;
                    int colonne_right = colonne + mot.Length;
                    int debut_mot_a_tester = 0;
                    while (plateau[ligne, colonne_left][1] != '_')
                    {
                        debut_mot_a_tester++;
                        colonne_left--;
                    }
                    for (int i = 0; i < debut_mot_a_tester; i++)
                    {
                        mot_a_tester += plateau[ligne, colonne_left + i + 1][1];
                    }
                    mot_a_tester += mot;
                    while (plateau[ligne, colonne_right][1] != '_')
                    {
                        mot_a_tester += plateau[ligne, colonne_right][1];
                        colonne_right++;
                    }

                    if (Dictionnaire.RechercheDichoRecursif(Dictionnaire.Numero_list(mot_a_tester), 0, Dictionnaire.Numero_list(mot_a_tester).Count, mot_a_tester)) condition = true;
                }
                else
                {
                    condition = true;
                    Console.Write(mot_a_tester.ToUpper());
                }
            }

            if (direction == 'V')
            {
                ligne = ligne + counter;
                string mot_a_tester = "";
                if (plateau[ligne, colonne - 1][1] != '_' || plateau[ligne, colonne + 1][1] != '_')
                {
                    int colonne_left = colonne - 1;
                    int colonne_right = colonne + 1;
                    int debut_mot_a_tester = 0;
                    while (plateau[ligne, colonne_left][1] != '_')
                    {
                        debut_mot_a_tester++;
                        colonne_left--;
                    }
                    for (int i = 0; i < debut_mot_a_tester; i++)
                    {
                        mot_a_tester += plateau[ligne, colonne_left + i + 1][1];
                    }
                    mot_a_tester += mot[counter];
                    while (plateau[ligne, colonne_right][1] != '_')
                    {
                        mot_a_tester += plateau[ligne, colonne_right][1];
                        colonne_right++;
                    }

                    if (Dictionnaire.RechercheDichoRecursif(Dictionnaire.Numero_list(mot_a_tester), 0, Dictionnaire.Numero_list(mot_a_tester).Count, mot_a_tester)) condition = true;
                }

                else
                {
                    condition = true;
                    Console.Write(mot_a_tester.ToUpper());
                }
            }
            return condition;
        }

        public bool Verif_colonne(string mot, int ligne, int colonne, char direction, int counter)
        {
            bool condition = false;
            if (direction == 'H')
            {
                colonne = colonne + counter;
                string mot_a_tester = "";
                if (plateau[ligne - 1, colonne][1] != '_' || plateau[ligne + 1, colonne][1] != '_')
                {
                    int ligne_up = ligne - 1;
                    int ligne_down = ligne + 1;
                    int debut_mot_a_tester = 0;
                    while (plateau[ligne_up, colonne][1] != '_')
                    {
                        debut_mot_a_tester++;
                        ligne_up--;
                    }
                    for (int i = 0; i < debut_mot_a_tester; i++)
                    {
                        mot_a_tester += this.plateau[ligne_up + i + 1, colonne][1];
                    }
                    mot_a_tester += mot[counter];
                    while (this.plateau[ligne_down, colonne][1] != '_')
                    {
                        mot_a_tester += this.plateau[ligne_down, colonne][1];
                        ligne_down++;
                    }

                    if (Dictionnaire.RechercheDichoRecursif(Dictionnaire.Numero_list(mot_a_tester), 0, Dictionnaire.Numero_list(mot_a_tester).Count, mot_a_tester)) condition = true;
                }

                else
                {
                    condition = true;
                    Console.Write(mot_a_tester.ToUpper());
                }
            }

            if (direction == 'V')
            {
                string mot_a_tester = "";
                if (this.plateau[ligne - 1, colonne][1] != '_' || this.plateau[ligne + mot.Length, colonne][1] != '_')
                {
                    int ligne_up = colonne - 1;
                    int ligne_down = colonne + mot.Length;
                    int debut_mot_a_tester = 0;
                    while (this.plateau[ligne_up, colonne][1] != '_')
                    {
                        debut_mot_a_tester++;
                        ligne_up--;
                    }
                    for (int i = 0; i < debut_mot_a_tester; i++)
                    {
                        mot_a_tester += this.plateau[ligne_up + i + 1, colonne][1];
                    }
                    mot_a_tester += mot;
                    while (this.plateau[ligne_down, colonne][1] != '_')
                    {
                        mot_a_tester += this.plateau[ligne_down, colonne][1];
                        ligne_down++;
                    }

                    if (Dictionnaire.RechercheDichoRecursif(Dictionnaire.Numero_list(mot_a_tester), 0, Dictionnaire.Numero_list(mot_a_tester).Count, mot_a_tester)) condition = true;
                }

                else
                {
                    condition = true;
                    Console.Write(mot_a_tester.ToUpper());
                }
            }
            return condition;
        }


        public List<char> Jeton_Pose(string mot, int ligne, int colonne, char direction) // on regarde quels caracter vont etre nécessaire à poser pour former le mot
        {

            int counter = 0;
            List<char> list_lettre = new List<char>();

            if (direction == 'H')
            {
                for (int i = colonne; i < colonne + mot.Length; i++)
                {
                    if ('_' == this.Plateauprop[ligne, i][1] || '.' == this.Plateauprop[ligne, i][1])
                    {
                        list_lettre.Add(mot[counter]);
                    }
                    counter++;
                }
            }
            else if (direction == 'V')
            {
                for (int i = ligne; i < ligne + mot.Length; i++)
                {
                    if ('_' == this.Plateauprop[i, colonne][1] || '.' == this.Plateauprop[i, colonne][1])
                    {
                        list_lettre.Add(mot[counter]);
                    }
                    counter++;
                }
            }
            return list_lettre;
        }
    }

}
