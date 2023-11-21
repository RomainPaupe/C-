using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    public class Joueur
    {
        string nom;
        int score;
        List<string> motsTrouves;
        List<Jeton> mainCourante;

        public string Nom
        {
            get { return nom; }
            set { nom = value.ToString(); }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public List<Jeton> MainCourante
        {
            get { return this.mainCourante; }
        }

        public Joueur(string nom)
        {
            this.nom = nom;
            this.score = 0;
            this.motsTrouves = new List<string>();
            this.mainCourante = new List<Jeton>(7);
        }


        public void Add_Mot(string mot)
        {
            motsTrouves.Add(mot);
        }

        public string toString() // Décris un joueur
        {
            string resul = "Joueur : " + this.nom + "\nScore : " + this.score + "\n";
            if (motsTrouves.Count >= 1)
            {
                foreach (string k in motsTrouves)
                    resul += k + " ";
                return resul;
            }
            else return resul + "Aucun mots trouvés";

        }

        public static List<char> List_MainCourante(Joueur joueur)
        {
            List<char> resul = new List<char>();
            for (int i = 0; i < joueur.MainCourante.Count; i++)
            {
                resul[i] = joueur.MainCourante[i].Lettre;
            }
            return resul;
        }

        public void Add_Score(int val)
        {
            this.score += val;
        }

        public void Calcul_Score(string mot, int ligne, int colonne, char direction,  Plateau monplateau, int indicejoker)
        {
            int multiplier_par = 1;
            int score = 0;
            int counter = 0;

            if (direction == 'H')
            {
                Add_Score(Score_Mot_ralonger(ligne, colonne, direction, monplateau));
                for (int i = colonne; i < mot.Length + colonne; i++)
                {
                    int score_lettre = Score_Jeton(mot[counter]);
                    if (mot[counter] != (monplateau.Plateauprop[ligne, i])[1])
                    {
                        Add_Score(Score_Mot_Autour(ligne, colonne, direction, monplateau, counter));
                    }

                    if (counter == indicejoker) score_lettre = 0;

                    if (monplateau.Plateauprop[ligne, i][1] != mot[counter] )
                    {
                        switch (monplateau.PlateauScoreprop[ligne, i])
                        {
                            case 49:
                                score_lettre = score_lettre * 2;
                                break;

                            case 50:
                                score_lettre = score_lettre * 3;
                                break;

                            case 51:
                                multiplier_par = multiplier_par * 2;
                                break;

                            case 52:
                                multiplier_par = multiplier_par * 3;
                                break;
                        }
                    }
                    score += score_lettre;
                    counter++;
                }
                score = score * multiplier_par;
                Add_Score(score);
            }

            else if (direction == 'V')
            {
                Add_Score(Score_Mot_ralonger(ligne, colonne, direction, monplateau));
                for (int i = ligne; i < mot.Length + ligne; i++)
                {
                    int score_lettre = Score_Jeton(mot[counter]);
                    if (mot[counter] != (monplateau.Plateauprop[i, colonne])[1])
                    {
                        Add_Score(Score_Mot_Autour(ligne, colonne, direction, monplateau, counter));
                    }

                    if (counter == indicejoker) score_lettre = 0;

                    if (monplateau.Plateauprop[i, colonne][1] != mot[counter])
                    {
                        switch (monplateau.PlateauScoreprop[i, colonne])
                        {
                            case 49:
                                score_lettre = score_lettre * 2;
                                break;

                            case 50:
                                score_lettre = score_lettre * 3;
                                break;

                            case 51:
                                multiplier_par = multiplier_par * 2;
                                break;

                            case 52:
                                multiplier_par = multiplier_par * 3;
                                break;
                        }
                    }
                    score += score_lettre;
                    counter++;
                }
                score = score * multiplier_par;
                Add_Score(score);
            }
        }

        public int Score_Mot_ralonger(int ligne, int colonne, char direction, Plateau monplateau)
        {
            int score = 0;
            if (direction == 'H')
            {
                int colonne_left = colonne - 1;
                int colonne_right = colonne + 1;
                while (monplateau.Plateauprop[ligne, colonne_left][1] != '_')
                {
                    score += Score_Jeton(monplateau.Plateauprop[ligne, colonne_left][1]);
                    colonne_left--;
                }
                while (monplateau.Plateauprop[ligne, colonne_right][1] != '_')
                {
                    score += Score_Jeton(monplateau.Plateauprop[ligne, colonne_right][1]);
                    colonne_right++;
                }
            }

            if (direction == 'v')
            {
                int ligne_up = ligne - 1;
                int ligne_down = ligne + 1;
                while (monplateau.Plateauprop[ligne_up, colonne][1] != '_')
                {
                    score += Score_Jeton(monplateau.Plateauprop[ligne_up, colonne][1]);
                    ligne_up--;
                }
                while (monplateau.Plateauprop[ligne_down, colonne][1] != '_')
                {
                    score += Score_Jeton(monplateau.Plateauprop[ligne_down, colonne][1]);
                    ligne_down++;
                }
            }
            return score;
        }

        public int Score_Mot_Autour(int ligne, int colonne, char direction, Plateau monplateau, int counter)
        {
            int score = 0;
            if (direction == 'H')
            {
                colonne = colonne + counter;
                if (monplateau.Plateauprop[ligne - 1, colonne][1] != '_' || monplateau.Plateauprop[ligne + 1, colonne][1] != '_')
                {
                    int ligne_up = ligne - 1;
                    int ligne_down = ligne + 1;
                    while (monplateau.Plateauprop[ligne_up, colonne][1] != '_')
                    {
                        score += Score_Jeton(monplateau.Plateauprop[ligne_up, colonne][1]);
                        ligne_up--;
                    }
                    while (monplateau.Plateauprop[ligne_down, colonne][1] != '_')
                    {
                        score += Score_Jeton(monplateau.Plateauprop[ligne_down, colonne][1]);
                        ligne_down++;
                    }
                }
            }
            if (direction == 'V')
            {
                ligne = ligne + counter;
                if (monplateau.Plateauprop[ligne, colonne - 1][1] != '_' || monplateau.Plateauprop[ligne, colonne + 1][1] != '_')
                {
                    int colonne_left = colonne - 1;
                    int colonne_right = ligne + 1;
                    while (monplateau.Plateauprop[ligne, colonne_left][1] != '_')
                    {
                        score += Score_Jeton(monplateau.Plateauprop[ligne, colonne_left][1]);
                        colonne_left--;
                    }
                    while (monplateau.Plateauprop[ligne, colonne_right][1] != '_')
                    {
                        score += Score_Jeton(monplateau.Plateauprop[ligne, colonne_right][1]);
                        colonne_right++;
                    }
                }
            }
            return score;
        }

        public static int Score_Jeton(char lettre)
        {
            int score_lettre = 0;
            foreach (string ligne in File.ReadAllLines("Jetons.txt"))
            {
                string[] jeton = ligne.Split(";");
                if (lettre == Convert.ToChar(jeton[0]))
                {
                    score_lettre += Convert.ToInt32(jeton[1]);
                    return score_lettre;
                }
            }
            return score_lettre;
        }

        public string Affichage_Main_Courante()
        {
            string resul = "[";
            for(int i = 0; i< mainCourante.Count - 1; i++)
            {
                resul += mainCourante[i].Lettre + ", ";
            }
            resul += mainCourante[6].Lettre;
            resul += "]";
            return resul;
        }

        public bool Test_Jetons_Requis(List<char> jetons_pose, int nombre_joker )
        {
            Jeton joker = new Jeton('*', 0);
            bool conditionglobale = true;
            bool[] condition = new bool[jetons_pose.Count];
            for(int i = 0; i < condition.Length; i++)
            {
                condition[i] = false;
            }
            List<Jeton> jetonsrequis = new List<Jeton>();
            foreach(char c in jetons_pose)
            {
                jetonsrequis.Add(Nom_Du_Jeton(c));
            }
            int counter = 0;

            
            foreach (Jeton j in jetonsrequis)
            {
                for(int i = 0; i<mainCourante.Count; i++)
                {
                    if(mainCourante[i].Lettre == j.Lettre)
                    {
                        condition[counter] = true;
                    }
                }
                counter++;

            }
            for (int i = 0; i < condition.Length; i++)
            {
                if (nombre_joker > 0 && condition[i] == false)
                {
                    condition[i] = true;
                    nombre_joker--;
                    jetonsrequis.RemoveAt(i);
                    jetonsrequis.Add(joker);
                }
            }
            for (int i = 0; i<condition.Length; i++)
            {
                if (condition[i] == false) conditionglobale = false;
            }
            return conditionglobale; ;

        }

        public void Retire_jetons_main_courante(List<char> jetons_pose, int nombre_joker)
        {
            List<Jeton> jetonsrequis = new List<Jeton>();
            foreach (char c in jetons_pose)
            {
                jetonsrequis.Add(Nom_Du_Jeton(c));
            }
            foreach (Jeton j in jetonsrequis)
            {
                Remonve_Main_Courante(j, nombre_joker);
            }
        }
        public Jeton Nom_Du_Jeton(char c)
        {
            string[] resul = { "", "" };
            foreach (string ligne in File.ReadAllLines("Jetons.txt"))
            {
                string[] jeton = ligne.Split(";");
                if (Convert.ToChar(jeton[0]) == c)
                {
                    resul = jeton;
                }
            }

            Jeton jeton_resul = new Jeton(Convert.ToChar(resul[0]), Convert.ToInt32(resul[1]));
            return jeton_resul;
        }
        public void Add_Main_Courante(Jeton monJeton)
        {

            mainCourante.Add(monJeton);
        }

        public void Remonve_Main_Courante(Jeton monjeton, int nombre_joker)
        {
            bool condition = false;
            int counter = 0;
            while (mainCourante[counter].Lettre != monjeton.Lettre && counter<mainCourante.Count -1)
            {
                
                counter++;
            }
            if (mainCourante[counter].Lettre == monjeton.Lettre)
            {
                condition = true;
                mainCourante.RemoveAt(counter);
            }
            else if (condition == false)
            {
                for(int i = 0; i< mainCourante.Count; i++)
                {
                    if(mainCourante[i].Lettre == '*' && nombre_joker>0)
                    {
                        mainCourante.RemoveAt(i);
                        //score-=
                    }
                }
            }
            
        }
        public int Nombre_de_joker()
        {
            int nombre_de_joker = 0;
            for (int i = 0; i < mainCourante.Count; i++)
            {
                if (mainCourante[i].Lettre == '*') nombre_de_joker++;
            }
            return nombre_de_joker;
        }

        public int Indice_joker_mot(string mot)
        {
            int indice = -1;
            bool[] condition = new bool[mot.Length];
            for (int i = 0; i < condition.Length; i++)
            {
                condition[i] = false;
            }
            for (int i = 0; i<mot.Length; i++)
            {
                for(int j = 0; j < mainCourante.Count; j++)
                {
                    if(mainCourante[j].Lettre == mot[i])
                    {
                        condition[i] = true;
                    }
                }
                if (condition[i] == false && Nombre_de_joker()>0)
                {
                    condition[i] = true;
                    indice = i;
                }
            }
            return indice;
        }


    }
}
