using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau;
            int nbTentative = 0;
            int[,] sudoku = new int[9, 9] { { 5, 3, 0, 0, 7, 0, 0, 0, 0 }, { 6, 0, 0, 1, 9, 5, 0, 0, 0 }, { 0, 9, 8, 0, 0, 0, 0, 6, 0 }, { 8, 0, 0, 0, 6, 0, 0, 0, 3 }, { 4, 0, 0, 8, 0, 3, 0, 0, 1 }, { 7, 0, 0, 0, 2, 0, 0, 0, 6 }, { 0, 6, 0, 0, 0, 0, 2, 8, 0 }, { 0, 0, 0, 4, 1, 9, 0, 0, 5 }, { 0, 0, 0, 0, 8, 0, 0, 7, 9 } };
            do
            {
                nbTentative++;
                Console.Clear();
                plateau = new Plateau();
                Console.WriteLine(nbTentative);
                Console.WriteLine(plateau.toString());
            } while (!plateau.Resolution());
            Console.WriteLine("\n\n" + plateau.toString());
            Console.ReadKey();
        }

        public static int[,] GenererGrilleRand()
        {
            Random r = new Random();
            int[,] resul = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    resul[i, j] = 0;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                resul[r.Next(9), r.Next(9)] = r.Next(10);
            }
            return resul;
        }
    }
}
