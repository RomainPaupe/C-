using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltorbataille
{
    internal class Token
    {
        int score;
        char name;
        int status;

        public int Score
        {
            get { return score; }
        }

        public char Name
        {
            get { return name; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public Token(int score)
        {
            this.score = score;
            if (score == 0) name = 'V';
            switch (score)
            {
                case 1:
                    name = '1';
                    break;
                case 2:
                    name = '2';
                    break;
                case 3:
                    name = '3';
                    break;
            }
            status = 0;
        }
    }
}
