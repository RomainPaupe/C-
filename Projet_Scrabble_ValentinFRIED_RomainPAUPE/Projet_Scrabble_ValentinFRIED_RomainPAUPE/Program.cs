using System;
using System.Timers;

namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            
            Jeu mapartie = new Jeu();

            Joueur J_en_cours = mapartie.Joueur_en_cours;


            while (mapartie.Monsac_jetons.List_Jeton != null) // 1 TOUR
            {
                int temps_debut_seconde = DateTime.Now.Second;
                int temps_debut_minute = DateTime.Now.Minute;
                int temps_debut_heure = DateTime.Now.Hour;
                
                bool jeton_main = false;
                bool mot_valide = false;
                int ligne = 0;
                int colonne = 0;
                char direction = ' ';
                string mot = "";
                
                Console.Clear();
                
                Console.WriteLine("C'est à " + J_en_cours.Nom + " de jouer, vous avez deux minutes pour jouer, si vous dépasser le temps votre tour ne sera pas pris en compte :\n");

                mapartie.Monplateau.Affichage(mapartie.Nombre_joueurs, mapartie);
                Console.WriteLine("\n");

                while (mot_valide == false)
                {int nombre_joker = J_en_cours.Nombre_de_joker();
                int indice_joker = -1;
                
                    while (jeton_main == false)
                    {
                        Console.Write("Saisir un mot : ");
                        mot = Convert.ToString(Console.ReadLine()).ToUpper();

                        while (Dictionnaire.RechercheDichoRecursif(Dictionnaire.Numero_list(mot), 0, Dictionnaire.Numero_list(mot).Count, mot) == false)
                        {
                            Console.Write("Le mot n'existe pas dans le dictionnaire, veuillez réesayer : ");
                            mot = Convert.ToString(Console.ReadLine()).ToUpper();
                        }
                        if (nombre_joker > 0)
                        {
                            indice_joker = J_en_cours.Indice_joker_mot(mot);
                        }

                        if (mapartie.J1.Score == 0)
                        {

                            ligne = 7;
                            colonne = 7;
                            Console.WriteLine("ligne : 7 \nColonne : 7");
                        }

                        else
                        {
                            Console.Write("Ligne : ");
                            ligne = mapartie.Entrer_un_entier();
                            while (ligne > 14 || ligne < 1)
                            {
                                Console.Write("ERREUR !\nCoordonée invalide, réesayer : ");
                                ligne = mapartie.Entrer_un_entier();
                            }

                            Console.Write("Colonne : ");
                            colonne = mapartie.Entrer_un_entier();
                            while (colonne > 14 || colonne < 1)
                            {
                                Console.Write("ERREUR !\nCoordonée invalide, réesayer : ");
                                colonne = mapartie.Entrer_un_entier();
                            }
                        }

                        Console.Write("Direction (H pour horizontale, V pour vertical) : ");
                        direction = Convert.ToChar(Console.ReadLine().ToUpper());
                        while (direction != 'H' && direction != 'V')
                        {
                            Console.Write("ERREUR !\nTapez 'H' pour hoizontale et 'V' pour verticale : ");
                            direction = Convert.ToChar(Console.ReadLine().ToUpper());
                        }
                        
                        
                        if (J_en_cours.Test_Jetons_Requis(mapartie.Monplateau.Jeton_Pose(mot, ligne, colonne, direction),J_en_cours.Nombre_de_joker()))
                        {
                            jeton_main = true;
                        }
                        else Console.WriteLine("\nVous n'avez pas les jetons nécéssaire pour ce mot ou bien le mot est mal placé");
                        
                    }
                    if (mapartie.Monplateau.Test_Plateau(mot, ligne, colonne, direction))
                    {
                        int temps_ecoule = (DateTime.Now.Hour - temps_debut_heure) *3600 + (DateTime.Now.Minute - temps_debut_minute) * 60 + DateTime.Now.Second - temps_debut_seconde;
                        if (temps_ecoule <= 120)
                        {
                            J_en_cours.Retire_jetons_main_courante(mapartie.Monplateau.Jeton_Pose(mot, ligne, colonne, direction), J_en_cours.Nombre_de_joker());
                            J_en_cours.Calcul_Score(mot, ligne, colonne, direction, mapartie.Monplateau, indice_joker);
                            mapartie.Monplateau.Saisie_Mot(direction, mot, ligne, colonne);
                            Console.WriteLine("Votre tour a bien été pris en compte car vous avez mis " + temps_ecoule + " secondes à jouer, soit moins de deux minutes.");
                            Console.Write("\nAppuyez sur une touche pour passer au tour suivante");
                            Console.ReadKey();
                            mot_valide = true;
                            mapartie.Piocher();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Votre tour n'a pas été pris en compte car vous avez mis " + temps_ecoule + " secondes à jouer, soit plus de deux minutes.");
                            Console.Write("\nAppuyez sur une touche pour passer au tour suivante");
                            Console.ReadKey();
                        }
                        J_en_cours = mapartie.Changement_de_joueurs();
                    }
                         
                    
                    else jeton_main = false;
                }
            }
        }  

    }
}
