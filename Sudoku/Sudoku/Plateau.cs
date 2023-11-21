using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Plateau
    {
        Random r = new Random();
        int[,] plateau = new int[9,9];
        int nbTentative = 0;

        public Plateau()
        {
            RandomInit();
        }

        public Plateau(int[,] sudoku)
        {
            plateau = sudoku;
        }
        
        public void RandomInit()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    plateau[i, j] = 0;
                }
            }
            for (int i = 0; i < 15; i++)
            {
                int x;
                int y;
                int nb;
                do
                {
                    x = r.Next(9);
                    y = r.Next(9);
                    nb = r.Next(9);
                } while (!VerifPossible(nb, x, y));
                plateau[x, y] = nb;
            }

        }
        #region generation
        public bool PlateauRandom()
        {
            for(int i = 0; i < plateau.GetLength(0); i++)
            {
                for(int j = 0; j < plateau.GetLength(1); j++)
                {
                    List<int> chiffrePossible = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9};
                    bool resul = false;
                    do
                    {
                        int chiffre = r.Next(chiffrePossible.Count);
                        if(VerifPossible(chiffrePossible[chiffre], i, j))
                        {
                            plateau[i,j] = chiffrePossible[chiffre];
                            resul = true;
                        }
                        else
                        {
                            chiffrePossible.RemoveAt(chiffre);
                        }

                    } while (!resul && chiffrePossible.Count != 0);

                    if (resul == false)
                    {
                        nbTentative++;
                        Console.Clear();
                        Console.WriteLine(nbTentative.ToString());
                        System.Threading.Thread.Sleep(5);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion
        public bool VerifPossible(int nb, int x, int y)
        {
            int factx = x / 3;
            int facty = y / 3;
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                if (i != x)
                {
                    if (plateau[i, y] == nb) return false;
                }

                if (i != y)
                {
                    if (plateau[x, i] == nb) return false;
                }
            }
            for (int i = 3 * factx; i < 3 * (factx + 1); i++)
            {
                for (int j = 3 * facty; j < 3 * (facty + 1); j++)
                {
                    if (plateau[i, j] == nb) return false;

                }
            }
            return true;
        }

        public bool Resolution()
        {
            int count = 0;
            bool poser = false;
            while(!poser)
            {
                poser = true;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (plateau[i, j] == 0)
                        {
                            int[] unAdix = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                            List<int> ok = new List<int>();
                            for (int k = 0; k < unAdix.Length; k++)
                            {
                                if (VerifPossible(unAdix[k], i, j)) ok.Add(unAdix[k]);
                            }
                            if (ok.Count == 1) plateau[i, j] = ok[0];
                            else poser = false;
                        }
                    }
                }
                count++;
                if (count == 9 * 9) return false;
            }
            return true;
        }
        
        public string toString()
        {
            string resul = "";
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                for(int j = 0; j < plateau.GetLength(1); j++)
                {
                    resul += plateau[i, j].ToString() + " ";
                }
                resul += "\n";
            }
            return resul;
        }
    }
}
