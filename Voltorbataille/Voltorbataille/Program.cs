using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltorbataille
{
    internal class Program
    {        
        public static void Main(string[] args)
        {
            int level = 1;
            Grid grid = new Grid(level);
            Player player = new Player();
            bool gameOn = true;
            while(gameOn)
            {
                bool playerMoving = true;
                //Player moving on the grid
                while (playerMoving)
                {
                    Console.Clear();
                    grid.DisplayGrid(player);
                    Console.WriteLine("Move with ZQSD, press ENTER to select, press ESPACE to leave");

                    ConsoleKeyInfo cki;
                    string c;
                    do
                    {
                        cki = Console.ReadKey();
                        c = Convert.ToString(cki.KeyChar).ToUpper();
                    } while (c != "Z" && c != "Q" && c != "S" && c != "D" && c != "\r");

                    switch (c)
                    {
                        case "Z":
                            player.Move(player.X - 1, player.Y);
                            break;
                        case "Q":
                            player.Move(player.X, player.Y - 1);
                            break;
                        case "S":
                            player.Move(player.X + 1, player.Y);
                            break;
                        case "D":
                            player.Move(player.X, player.Y + 1);
                            break;
                        case "\r":
                            playerMoving = false;
                            break;
                    }
                }

                int resul = grid.ReturnToken(player);
                if (resul == -1)
                {
                    player.Score = 0;
                    if(player.NbMove <= level)
                    {
                        if (player.NbMove == 0) grid.Level = 1;
                        else grid.Level = player.NbMove;
                    }
                    Console.Clear();
                    grid.DisplayGrid(player);
                    Console.WriteLine("Dommage ! Vous avez 0 jetons.");
                    Console.WriteLine("Le jeu est redessendu au niveau " + grid.Level);
                    Console.ReadKey();
                    player.X = 0;
                    player.Y = 0;
                    grid.loadGrid();
                }
                else
                {
                    int ptGagne = player.AddScore(resul);
                    player.NbMove++;
                    if(ptGagne != 0)
                    {
                        Console.Clear();
                        grid.DisplayGrid(player);
                        Console.WriteLine("x" + resul + "   " + ptGagne + " jetons obtenus !");
                        Console.ReadKey();
                    }
                }
                
                if(grid.endOfLvl())
                {
                    grid.ReturnAllToken();
                    grid.Level++;
                    Console.Clear();
                    grid.DisplayGrid(player);
                    Console.WriteLine("Gagné !");
                    Console.WriteLine("Le jeu est monte au niveau " + grid.Level);
                    Console.ReadKey();
                    player.X = 0;
                    player.Y = 0;
                    grid.loadGrid();

                }
                Console.Clear();
                grid.DisplayGrid(player);
            }
            Console.WriteLine("You lose son of a bitch");
            Console.ReadKey();
        }
    }
}
