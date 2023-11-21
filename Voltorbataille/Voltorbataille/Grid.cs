using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltorbataille
{
    internal class Grid
    {
        Random r = new Random();
        Token[,] grid = new Token[5, 5];
        int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Grid(int level)
        {
            this.level = level;
            loadGrid();
        }
        public void DisplayGrid(Player player)
        {
            /* for(int i = 0; i < 5; i++)
             {
                 for(int j = 0; j < 5; j++)
                 {
                     Console.Write(grid[i,j].Name + " | ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine("\n");*/
            Console.WriteLine("Jetons : " + player.Score);

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                int sum = 0;
                int volt = 0;
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if(player.X == i && player.Y == j) Console.ForegroundColor = ConsoleColor.Blue;
                    if (grid[i, j].Status == 1) Console.Write(grid[i, j].Name);
                    else Console.Write("X");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" | ");
                    sum += grid[i, j].Score;
                    if (grid[i, j].Name == 'V') volt++;
                }
                Console.WriteLine(sum + "/" + volt);
            }

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                int sum = 0;
                int volt = 0;
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    sum += grid[j, i].Score;
                    if (grid[j, i].Name == 'V') volt++;
                }
                Console.Write(sum + "/" + volt + " | ");
            }
            Console.WriteLine("X");

        }

        public void loadGrid()
        {
            int minVoltorb = 5 + level;
            int maxVoltorb = 7 + level;
            int minScore = 12 * (int)Math.Pow(2, level);
            int maxScore = 24 * (int)Math.Pow(2, level);
            List<Token> tokenList = new List<Token>();

            int levelScore = 1;

            //Init of number of 2 and 3 tokens
            while (levelScore < minScore)
            {
                Token tokenToAdd = new Token(r.Next(2, 4));
                if (tokenToAdd.Score * levelScore < maxScore)
                {
                    tokenList.Add(tokenToAdd);
                    levelScore *= tokenToAdd.Score;
                }
            }

            //Init of the number of voltorb tokens
            int nbVoltorb = minVoltorb + r.Next(0, maxVoltorb - minVoltorb + 1);

            //Init of the grid
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Token(1);
                }
            }

            //2 and 3 token are placed on the grid
            while (tokenList.Count > 0)
            {
                int i, j;
                do
                {
                    i = r.Next(grid.GetLength(0));
                    j = r.Next(grid.GetLength(1));
                } while (grid[i, j].Score != 1);
                grid[i, j] = tokenList[0];
                tokenList.RemoveAt(0);
            }

            //Voltorb token are placed on the grid
            for (int v = 0; v < nbVoltorb; v++)
            {
                int i, j;
                do
                {
                    i = r.Next(grid.GetLength(0));
                    j = r.Next(grid.GetLength(1));
                } while (grid[i, j].Score != 1);
                grid[i, j] = new Token(0);
            }

        }

        public int ReturnToken(Player player)
        {
            int resul;
            if (grid[player.X, player.Y].Status == 1) resul = 1;
            else if (grid[player.X, player.Y].Score == 0)
            {
                grid[player.X, player.Y].Status = 1;
                resul =  -1;
            }
            else
            {
                grid[player.X, player.Y].Status = 1;
                resul = grid[player.X, player.Y].Score;
            }
            return resul;
        }

        public bool endOfLvl()
        {
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].Status != 1 && (grid[i, j].Score == 2 || grid[i, j].Score == 3)) return false;
                }
            }
            return true;
        }

        public void ReturnAllToken()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].Status = 1;
                }
            }
        }
    }
}
