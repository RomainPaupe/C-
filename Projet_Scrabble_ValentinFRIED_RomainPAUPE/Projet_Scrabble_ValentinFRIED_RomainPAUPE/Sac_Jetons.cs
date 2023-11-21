using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Projet_Scrabble_ValentinFRIED_RomainPAUPE
{
    public class Sac_Jetons
    {
        List<Jeton> list_Jeton = new List<Jeton>();

        public List<Jeton> List_Jeton
        {
            get { return list_Jeton; }
        }

     

        public Sac_Jetons(string fichier)
        {
            try
            {
                foreach (string ligne in File.ReadAllLines(fichier))
                {
                    string[] jeton = ligne.Split(";");
                    Jeton monJeton = new Jeton(Convert.ToChar(jeton[0]), Convert.ToInt32(jeton[1]));
                    for (int i = 0; i < Convert.ToInt32(jeton[2]); i++)
                    {
                        this.list_Jeton.Add(monJeton);
                    }
                }
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine("Le fichier n'existe pas");
                Console.WriteLine(f.Message);
            }
        }

        Random r = new Random();
        

        public Jeton Pioche_Jeton() // pioche jeton dans le sac de jeton (Retire_Jeton dans l'enoncé)
        {
            int numero_Jeton_ARetirer = 0;
            numero_Jeton_ARetirer = r.Next(0, list_Jeton.Count);
            Jeton resul = this.list_Jeton[numero_Jeton_ARetirer];
            this.list_Jeton.RemoveAt(numero_Jeton_ARetirer);
            return resul;
        }




        /*public string toString()
        {

            string resul = "Jetons restants : Lettre  |  Quantité restante\n                 ";
            foreach(Jeton j in this.List_Jeton)
            {
                if (j.NombreJ != 0)
                {
                    resul += "    " + j.Lettre.ToString() + "    |    " + j.NombreJ.ToString() + "\n" + "                 ";
                }
            } 
            return resul;
        }*/
    }
}
