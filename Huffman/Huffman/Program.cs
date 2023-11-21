using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "araa rogee gorille";
            Dictionary<char, int> pixelFreq = new Dictionary<char, int>();
            for (int i  = 0; i < phrase.Length; i++)
            {
                if(pixelFreq.ContainsKey(phrase[i])) pixelFreq[phrase[i]]++;
                    else pixelFreq[phrase[i]] = 1;
            }
            Huffman(pixelFreq);
            Console.ReadKey();
        }

        public static void Huffman(Dictionary<char, int> pixelFreq)
        {

            var pixelFreqCroissant = pixelFreq.OrderBy(a => a.Value);

            List<Noeud> noeuds = new List<Noeud>();

            foreach (var item in pixelFreqCroissant)
            {
                noeuds.Add(new Noeud(item.Key, item.Value));
            }

            int x = 0;
            while (x < noeuds.Count - 1)
            {
                Noeud noeudToAdd = new Noeud(noeuds[x].FrequenceDansImg + noeuds[x + 1].FrequenceDansImg, noeuds[x], noeuds[x + 1]);
                noeuds.Remove(noeuds[x + 1]);
                noeuds.Remove(noeuds[x]);

                if (noeuds.Count == 0)
                {
                    noeuds.Add(noeudToAdd);
                }
                else
                {
                    int y = 0;
                    while (noeuds[y].FrequenceDansImg < noeudToAdd.FrequenceDansImg && y < noeuds.Count - 1) y++;
                    noeuds.Insert(y, noeudToAdd);
                }
                x = 0;
            }

            Noeud n = noeuds[0];
            List<stringHuff> strHuffmanPix = new List<stringHuff>();
            string str = "";
            int d = 0;
            bool breaking = true;
            bool firstTop = false;

            while (breaking)
            {
                bool first = true;
                n = noeuds[0];
                int index = 0;
                while (n.Pix == '\0')
                {
                    if (str.Length == index)
                    {
                        switch (d)
                        {
                            case 0:
                                n = n.Gauche;
                                str += "0";
                                index++;
                                break;
                            case 1:
                                if (first)
                                {
                                    n = n.Droit;
                                    str += "1";
                                    first = false;
                                }
                                else
                                {
                                    n = n.Gauche;
                                    str += "0";
                                }
                                index++;
                                break;
                        }
                    }
                    else if (str[index] == '0') { n = n.Gauche; index++; }
                    else { n = n.Droit; index++; }
                }


                strHuffmanPix.Add(new stringHuff(n.Pix, str));
                int s = 1;
                if (d == 0) d = 1;
                else
                {
                    while (breaking && str[str.Length - s] == '1') 
                    { 
                        s++;
                        if (str.Length < s) breaking = false;
                    }
                }
                if(breaking) { str = str.Substring(0, str.Length - s); }
                
                //if (str.Length == 0 && d == 1) breaking = false;
            }

            foreach (var item in strHuffmanPix)
            {
                Console.WriteLine($"{item.Str} : {item.Code}");
            }
            Console.WriteLine(strHuffmanPix[strHuffmanPix.Count - 1].Code);
        }
    }
}
