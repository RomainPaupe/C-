using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;

namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    public class Jeu
    {
        Timer aTimer;
        Joueur j1 = new Joueur("");
        Joueur j2 = new Joueur("");
        Joueur j3 = new Joueur("");
        Joueur j4 = new Joueur("");
        Joueur j_en_cours = new Joueur("");
        Joueur Sauvegarde = new Joueur("");
        int nombre_joueurs = 0;
        int joueur_en_cours = 1;
        Dictionnaire mondico = new Dictionnaire("Francais.txt");
        Plateau monplateau = new Plateau("Plateaux.txt");
        Sac_Jetons monsac_jetons = new Sac_Jetons("Jetons.txt");

        public Sac_Jetons Monsac_jetons
        {
            get { return monsac_jetons; }
        }

        public Plateau Monplateau
        {
            get { return monplateau; }
        }

        public Dictionnaire Mondico
        {
            get { return mondico; }
        }
        public int Nombre_joueurs
        {
            get { return nombre_joueurs; }
        }

        public Joueur Joueur_en_cours
        {
            get { return j_en_cours; }
        }
        public Joueur J1
        {
            get { return j1; }
        }

        public Joueur J2
        {
            get { return j2; }
        }

        public Joueur J3
        {
            get { return j3; }
        }

        public Joueur J4
        {
            get { return j4; }
        }

        public Jeu() // Partie
        {
            Console.WriteLine("Bienvenue dans notre Scrabble, bon jeu ! \n\nLes mains courantes sont actualisés à chaques fois que vous posez des lettres.\nVous avez deux minutes par tour pour poser un mot, si vous n'y parvenez pas vous pouvez changer votre main courante, ou passer votre tour.");
            Console.Write("\nSouhaitez-vous reprendre une partie en cours : Oui/Non : "); 
            string reponse = Console.ReadLine().ToUpper();
            while (reponse != "OUI" && reponse != "NON")
            {
                Console.Write("ERREUR\nSouhaitez-vous reprendre une partie en cours, répondre par Oui ou par Non : ");
                reponse = Console.ReadLine().ToUpper();
            }

            Console.WriteLine();
            string fichierplateau = "";
            string fichiersac = "";
            switch (reponse)
            {
                case ("NON"):
                    fichierplateau = "Plateaux.txt";
                    fichiersac = "Jetons.txt";
                    break;

                case ("OUI"):
                    Console.WriteLine("Assurez-vous de bien avoir déposer les fichiers permettant de lire un plateau, un sac de jetons et veuillez saisir leur nom :");
                    Console.Write("Nom du plateau : ");
                    fichierplateau = Console.ReadLine();
                    Console.Write("\nNom du sac de jetons : ");
                    fichiersac = Console.ReadLine();
                    break;

                default:
                    break;
            }

            Dictionnaire mondico = new Dictionnaire("Francais.txt");
            Plateau monplateau = new Plateau(fichierplateau);
            Sac_Jetons monsac_jetons = new Sac_Jetons(fichiersac);

            Création_des_joueurs();




        }

        public int Entrer_un_entier()
        {
            int entier;
            string test_entier = Console.ReadLine();
            while (!int.TryParse(test_entier, out entier))
            {
                Console.Write("ERREUR, veuillez entrer un entier : ");
                test_entier = Console.ReadLine();
            }
            return entier;
        }


        public void Création_des_joueurs()
        {
            Console.Write("Nombre de joueur (entre 2 et 4) : ");
            nombre_joueurs = Entrer_un_entier();
            while (nombre_joueurs > 4 || nombre_joueurs < 2)
            {
                Console.WriteLine("ERREUR\nChoisissez entre 2 et 4 joueurs maximum : ");
                nombre_joueurs = Entrer_un_entier();
            }

                        for (int i = 0; i < nombre_joueurs; i++)
            {
                Piocher();
                Changement_de_joueurs();
            }

            for (int i = 1; i < nombre_joueurs + 1; i++) // Attribution des noms
            {
                if (i == 1)
                {
                    Console.Write("\nNom du joueur " + i.ToString() + " : ");
                    string nom = Console.ReadLine();
                    j1.Nom = nom;
                }
                if (i == 2)
                {
                    Console.Write("Nom du joueur " + i.ToString() + " : ");
                    string nom = Console.ReadLine();
                    j2.Nom = nom;
                }
                if (i == 3)
                {
                    Console.Write("Nom du joueur " + i.ToString() + " : ");
                    string nom = Console.ReadLine();
                    j3.Nom = nom;
                }
                if (i == 4)
                {
                    Console.Write("Nom du joueur " + i.ToString() + " : ");
                    string nom = Console.ReadLine();
                    j4.Nom = nom;
                }
            }
        }
        public void Piocher()
        {
            while(j_en_cours.MainCourante.Count < 7)
            {
                j_en_cours.Add_Main_Courante(Monsac_jetons.Pioche_Jeton());
            }
        }

        public Joueur Changement_de_joueurs()
        {
            joueur_en_cours++;
            switch (joueur_en_cours)
            {
                case (1):
                    switch (nombre_joueurs)
                    {
                        case (2):
                            j2 = j_en_cours;
                            j_en_cours = j1;
                            break;
                        case (3):
                            j3= j_en_cours;
                            j_en_cours = j1;
                            break;
                        case (4):
                            j4 = j_en_cours;
                            j_en_cours = j1;
                            break;
                    }
                    break;

                case (2):
                    j1 = j_en_cours;
                    j_en_cours= j2;
                    break;

                case (3):
                    j2 = j_en_cours;
                    j_en_cours = j3;
                    break;

                case (4):
                    j3 = j_en_cours;
                    j_en_cours = j4;
                    break;
            }

            if (joueur_en_cours == nombre_joueurs)
            {
                joueur_en_cours = 0;
            }
            return j_en_cours;
        }

        /*public void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(120000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }*/


    }
}
