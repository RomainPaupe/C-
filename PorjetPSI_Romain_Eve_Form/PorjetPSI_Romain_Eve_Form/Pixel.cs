using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorjetPSI_Romain_Eve_Form
{
    public class Pixel
    {
        byte r;
        byte g;
        byte b;

        public Pixel()
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
        }
        public Pixel(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public override bool Equals(object p1)
        {
            Pixel p = (Pixel)p1;
            return (p.R == this.R && p.G == this.G && p.B == this.B);
        }
        public override int GetHashCode()
        {
            return (r + b + g).GetHashCode();
        }


        public byte R
        {
            get { return r; }
            set { r = value; }
        }
        public byte G
        {
            get { return g; }
            set { g = value; }
        }
        public byte B
        {
            get { return b; }
            set { b = value; }
        }

        public string stringPix()
        {
            return $"{r},{g},{b}";
        }
    }
}
