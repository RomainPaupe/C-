using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    public class Dictionnaire
    {
        #region Attributs de classe
        static List<List<string>> motsDictionnaireParTaille = new List<List<string>>();

        static List<string> taille2 = new List<string>();
        static List<string> taille3 = new List<string>();
        static List<string> taille4 = new List<string>();
        static List<string> taille5 = new List<string>();
        static List<string> taille6 = new List<string>();
        static List<string> taille7 = new List<string>();
        static List<string> taille8 = new List<string>();
        static List<string> taille9 = new List<string>();
        static List<string> taille10 = new List<string>();
        static List<string> taille11 = new List<string>();
        static List<string> taille12 = new List<string>();
        static List<string> taille13 = new List<string>();
        static List<string> taille14 = new List<string>();
        static List<string> taille15 = new List<string>();
        #endregion

        public List<List<string>> MotsDictionnaireParTaille
        {
            get { return motsDictionnaireParTaille; }
        }


        public Dictionnaire(string fichier)
        {
            #region Remplissage du dictionnaire trié par taille (List motsParTaille)
            motsDictionnaireParTaille.Add(taille2);
            motsDictionnaireParTaille.Add(taille3);
            motsDictionnaireParTaille.Add(taille4);
            motsDictionnaireParTaille.Add(taille5);
            motsDictionnaireParTaille.Add(taille6);
            motsDictionnaireParTaille.Add(taille7);
            motsDictionnaireParTaille.Add(taille8);
            motsDictionnaireParTaille.Add(taille9);
            motsDictionnaireParTaille.Add(taille10);
            motsDictionnaireParTaille.Add(taille11);
            motsDictionnaireParTaille.Add(taille12);
            motsDictionnaireParTaille.Add(taille13);
            motsDictionnaireParTaille.Add(taille14);
            motsDictionnaireParTaille.Add(taille15);
            #endregion

            int numero_ligne = 1; // les i servent à définir dans quelles listes vont être ajoutés les différents mots. exemple : si i = 4 tous les qui suivent  
            int j = 0;

            foreach (string ligne in File.ReadAllLines(fichier))
            {
                string mot_string = "";

                switch (numero_ligne)
                {

                    case 2:  // taille des mots == 2
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille2.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 4:  // taille des mots == 3
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille3.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 6:  // taille des mots == 4
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille4.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 8:  // taille des mots == 5
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille5.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 10:  // taille des mots == 6
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille6.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 12:  // taille des mots == 7
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille7.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 14:  // taille des mots == 8
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille8.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 16:  // taille des mots == 9
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille9.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 18:  // taille des mots == 10
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille10.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 20:  // taille des mots == 11
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille11.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 22:  // taille des mots == 12
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille12.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 24:  // taille des mots == 13
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille13.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 26:  // taille des mots == 14
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille14.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    case 28:  // taille des mots == 15
                        j = 0; // indice qui se ballade sur la ligne
                        while (j < ligne.Length) // tant que l'indice n'est pas arrivé au bout de la ligne :
                        {
                            if (ligne[j] != ' ') // si le caractere associé à l'indice est different d'un espace alors 
                            {
                                mot_string += ligne[j].ToString(); // on ajoute ce caractère à mot_string
                            }
                            else // autrement 
                            {
                                taille15.Add(mot_string); // on ajoute le mot_string à la liste des mots de taille i
                                mot_string = ""; // on reinitialise notre mot_string
                            }
                            j++; // on avance d'une lettre 
                        }
                        numero_ligne++;
                        break;

                    default:
                        numero_ligne++;
                        break;
                } // Remplissage des listes de mots par taille
            }
        }

        public static List<string> Numero_list(string mot)
        {
            List<string> resul = new List<string>();
            if (mot.Length == 2) resul = taille2;
            else if (mot.Length == 3) resul = taille3;
            else if (mot.Length == 4) resul = taille4;
            else if (mot.Length == 5) resul = taille5;
            else if (mot.Length == 6) resul = taille6;
            else if (mot.Length == 7) resul = taille7;
            else if (mot.Length == 8) resul = taille8;
            else if (mot.Length == 9) resul = taille9;
            else if (mot.Length == 10) resul = taille10;
            else if (mot.Length == 11) resul = taille11;
            else if (mot.Length == 12) resul = taille12;
            else if (mot.Length == 13) resul = taille13;
            else if (mot.Length == 14) resul = taille14;
            else if (mot.Length == 15) resul = taille15;
            return resul;
        }

        public static bool RechercheDichoRecursif(List<string> list, int min, int max, string mot)
        {
            bool condition = false;
            int milieu;
            if (min + max % 2 != 0) milieu = (min + max - 1) / 2;
            else milieu = (min + max + 1) / 2;
            string motMaximum = list[list.Count - 1];

            if (list[max -1] == list[min] && list[max - 1] != mot) return condition;
            if (max < min) return condition; // Le mot n'existe pas

            if (String.Compare(mot, list[milieu]) < 0)
            {
                if (min + max % 2 != 0) milieu = (min + max -1) / 2;
                else milieu = (min + max) / 2;
                return RechercheDichoRecursif(list, min, milieu, mot);
            }
            else if (String.Compare(mot, list[milieu]) > 0)
            {
                if (min + max % 2 != 0) milieu = (min + max + 1) / 2;
                else milieu = (min + max) / 2;
                return RechercheDichoRecursif(list, milieu, max, mot);
            }
            else if (String.Compare(mot, list[milieu]) == 0)
            {
                condition = true; // Le mot existe
            }
            return condition;
        }
    }
}
