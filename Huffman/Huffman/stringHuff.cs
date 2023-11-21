using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    internal class stringHuff
    {
        char str;
        string code = "";

        public stringHuff(char str, string code)
        {
            this.str = str;
            this.code = code;
        }
        public stringHuff(char str)
        {
            this.str = str;
        }
        public char Str { get { return str; }
        set { str = value; } }
        public string Code { get { return code; } set { code = value; } }
    }
}
