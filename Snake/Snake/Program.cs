using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static public void Affichage(char[,] tab)
        {
            Console.Clear();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("|" + tab[i, j]);
                }
                Console.WriteLine("|");
            }
        }

        static public int[] nouvelleEtoile(Snake monSnake)
        {
            Random random = new Random();

            bool test = true;
            int x;
            int y;

            do
            {
                x = random.Next(0, 10);
                y = random.Next(0, 10);

                for (int i = 0; i < monSnake.Taille; i++)
                {
                    if (monSnake.X[i] == x && monSnake.Y[i] == y) test = false;
                }
            }
            while (test == false);

            return new int[] { x, y };
        }
        static public void Start()
        {
            Snake monSnake = new Snake();
            monSnake.X[0] = 5;
            monSnake.Y[0] = 5;
            char[,] tab = new char[11, 11];
            bool resul = true;

            Random random = new Random();
            while (resul)
            {
                int[] etoile = nouvelleEtoile(monSnake);
                bool etoileManger = false;

                while (etoileManger == false)
                {
                    for (int i = 0; i < tab.GetLength(0); i++)
                    {
                        for (int j = 0; j < tab.GetLength(1); j++)
                        {
                            tab[i, j] = ' ';
                        }
                    }

                    tab[etoile[0], etoile[1]] = '*';
                    tab[monSnake.X[0], monSnake.Y[0]] = 'O';
                    for (int i = 1; i < monSnake.Taille; i++)
                    {
                        tab[monSnake.X[i], monSnake.Y[i]] = 'o';
                    }

                    Affichage(tab);

                    for (int i = 0; i < monSnake.Taille; i++)
                    {
                        monSnake.X2[i] = monSnake.X[i];
                        monSnake.Y2[i] = monSnake.Y[i];
                    }

                    int[] position = deplacement();
                    monSnake.X[0] += position[0];
                    monSnake.Y[0] += position[1];

                    if (monSnake.X[0] == etoile[0] && monSnake.Y[0] == etoile[1])
                    {
                        monSnake.Taille++;  
                        etoileManger = true;
                    }

                    for (int i = 1; i < monSnake.Taille; i++)
                    {
                        monSnake.X[i] = monSnake.X2[i - 1];
                        monSnake.Y[i] = monSnake.Y2[i - 1];
                    }

                }
            }
        }

        static public int[] deplacement()
        {
            int[] position = new int[2];
            var touche = ' ';
            while (touche != 'z' && touche != 'q' && touche != 's' && touche != 'd')
            {
                touche = Convert.ToChar(Console.ReadLine());
            }

            switch(touche)
            {
                case 'z':
                    position[0] = -1;
                    position[1] = 0;
                    break;
                case 'q':
                    position[0] = 0;
                    position[1] = -1;
                    break;
                case 's':
                    position[0] = 1;
                    position[1] = 0;
                    break;
                case 'd':
                    position[0] = 0;
                    position[1] = 1;
                    break;
            }

            return position;
        }

        static void Main(string[] args)
        {        
            Start();
            Console.ReadKey();
        }
    }
}
