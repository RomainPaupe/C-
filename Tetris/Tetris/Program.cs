namespace Tetris
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void StartGame()
        {
            int score = 0;
            int lines = 0;
            int level = 0;
            int time = 0;
            DateTime timeStart = DateTime.Now;
            DateTime timeCheckPoint = DateTime.Now;
            Color[,] plate = new Color[10, 22];
            for(int i = 0; i < plate.GetLength(0); i++)
            {
                for(int j = 0; j < plate.GetLength(1); j++)
                {
                    plate[i, j] = Color.White;
                }
            }

            Tetriminos[] pawns = new Tetriminos[2];
            pawns[0] = NewTetriminos();
            pawns[1] = NewTetriminos();

            bool gameOK = true;
            while(gameOK)
            {
                if(TimePass(timeCheckPoint, level))
                {
                    if (DownOk(pawns[0], plate))
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            pawns[0].CaseX[i]++;
                        }
                    }
                    else
                    {
                        plate = PlacePawn(pawns[0], plate);
                        pawns[0] = pawns[1];
                        pawns[1] = NewTetriminos();
                    }
                }
            }

        }
        public static int[] CheckLines(Color[,] plate)
        {
            int[] lineFull = {-1, -1, -1, -1};
            int count = 0;
            for (int i = 0; i < plate.GetLength(0); i++)
            {
                bool isLineFull = true;
                for(int j = 0; j < plate.GetLength(1); j++)
                {
                    if (plate[i, j] == Color.White)
                    {
                        isLineFull = false;
                        break;
                    }
                }
                if (isLineFull) 
                { 
                    lineFull[count] = i; 
                    count++; 
                }
            }
            return lineFull;
        }
        public static Color[,] PlacePawn(Tetriminos pawn, Color[,] plate)
        {
            Color[,] resul = plate;
            for(int i = 0; i < 4; i++)
            {
                resul[pawn.CaseX[i], pawn.CaseY[i]] = pawn.Paint;
            }
            return resul;
        }
        public static bool DownOk(Tetriminos pawn, Color[,] plate)
        {
            bool resul = true;

            for(int i = 0; i < 4; i++)
            {
                if(plate[pawn.CaseX[i],pawn.CaseY[i] + 1] != Color.White) resul = false;
            }
            return resul;
        }

        public static bool TimePass(DateTime timeCheckPoint, int level)
        {
            int duration = 100 - level * 3;
            bool resul = false;
            if (DateTime.Now.Millisecond- timeCheckPoint.Millisecond > duration) resul = true;
            return resul;
        }

        public static Tetriminos NewTetriminos()
        {
            Random random = new Random();
            int[] caseX = new int[4];
            int[] caseY = new int[4];
            Color paint = Color.White;

            switch(random.Next(6))
            {
                case 0:
                    for(int i = 0; i < 4; i++)
                    {
                        caseX[i] = 0;
                        caseY[i] = 3 + i;
                    }
                    paint = Color.LightBlue;
                    break;

                case 1:
                    caseX[0] = 0;
                    caseX[1] = 0;
                    caseX[2] = 1;
                    caseX[3] = 1;

                    caseY[0] = 4;
                    caseY[1] = 5;
                    caseY[2] = 4;
                    caseY[3] = 5;

                    paint = Color.Yellow;
                    break;

                case 2:
                    caseX[0] = 0;
                    caseX[1] = 0;
                    caseX[2] = 0;
                    caseX[3] = 1;

                    caseY[0] = 3;
                    caseY[1] = 4;
                    caseY[2] = 5;
                    caseY[3] = 4;
                    paint = Color.Purple;
                    break;

                case 3:
                    caseX[0] = 0;
                    caseX[1] = 0;
                    caseX[2] = 0;
                    caseX[3] = 1;

                    caseY[0] = 3;
                    caseY[1] = 4;
                    caseY[2] = 5;
                    caseY[3] = 3;
                    paint = Color.Orange;
                    break;

                case 4:
                    caseX[0] = 0;
                    caseX[1] = 0;
                    caseX[2] = 0;
                    caseX[3] = 1;

                    caseY[0] = 3;
                    caseY[1] = 4;
                    caseY[2] = 5;
                    caseY[3] = 5;
                    paint = Color.DarkBlue;
                    break;

                case 5:
                    caseX[0] = 0;
                    caseX[1] = 0;
                    caseX[2] = 1;
                    caseX[3] = 1;

                    caseY[0] = 3;
                    caseY[1] = 4;
                    caseY[2] = 4;
                    caseY[3] = 5;
                    paint = Color.Red;
                    break;

                case 6:
                    caseX[0] = 0;
                    caseX[1] = 0;
                    caseX[2] = 1;
                    caseX[3] = 1;

                    caseY[0] = 4;
                    caseY[1] = 5;
                    caseY[2] = 3;
                    caseY[3] = 4;
                    paint = Color.Green;
                    break;
            }

            return new Tetriminos(paint, caseX, caseY);
        }

        /*public static Tetriminos Rotation(Tetriminos pawn, int direction)
        {

        }*/
    }
}