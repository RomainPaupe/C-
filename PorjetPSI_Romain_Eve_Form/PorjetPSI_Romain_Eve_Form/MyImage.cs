using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Math;
using static System.Net.Mime.MediaTypeNames;

namespace PorjetPSI_Romain_Eve_Form
{
    public class MyImage
    {
        #region Attributs

        byte[] imageByte;
        Pixel[,] imagePixels;
        int height;
        int width;
        string typeImage;
        int fileSize;
        int offsetSize;
        int imageSize;

        #endregion

        #region Propriétés

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }

        public string TypeImage
        {
            get { return typeImage; }
            set { typeImage = value; }
        }

        public int OffsetSize
        {
            get { return offsetSize; }
            set { offsetSize = value; }
        }

        public int ImageSize
        {
            get { return imageSize; }
            set { imageSize = value; }
        }

        public Pixel[,] ImagePixels
        {
            get { return imagePixels; }
            set { imagePixels = value; }
        }

        #endregion

        #region Methodes

        #region TD 1

        public MyImage()
        {
            typeImage = "Bitmap";
        }
        public MyImage(Pixel[,] matricePixel)
        {
            imagePixels = matricePixel;
            height = matricePixel.GetLength(0);
            width = matricePixel.GetLength(1);
            imageSize = (height * width * 3);
            offsetSize = 54;
            typeImage = "Bitmap";
            fileSize = imageSize + 54;
        }

        public MyImage(string myfile)
        {
            imageByte = File.ReadAllBytes(myfile);
            if (imageByte[0] == 66 && imageByte[1] == 77) typeImage = "Bitmap";
            fileSize = Convert_Endian_To_Int(ReductionTab(imageByte, 2, 5));
            offsetSize = Convert_Endian_To_Int(ReductionTab(imageByte, 10, 13));
            width = Convert_Endian_To_Int(ReductionTab(imageByte, 18, 21));
            height = Convert_Endian_To_Int(ReductionTab(imageByte, 22, 25));
            imageSize = Convert_Endian_To_Int(ReductionTab(imageByte, 34, 37));

            int indice = 54;
            imagePixels = new Pixel[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    imagePixels[i, j] = new Pixel();
                    imagePixels[i, j].R = imageByte[indice];
                    imagePixels[i, j].G = imageByte[indice + 1];
                    imagePixels[i, j].B = imageByte[indice + 2];
                    indice = indice + 3;
                }
            }
        }

        public void From_Image_To_File(string pathfile)
        {
            byte[] result = new byte[(height * width * 3) + 54];
            for (int i = 0; i < 54; i++)
            {
                result[i] = 0;
            }

            result[0] = 66;
            result[1] = 77;
            result = InsertTab(result, Convert_Int_To_Endian(fileSize, 4), 2);
            result = InsertTab(result, Convert_Int_To_Endian(offsetSize, 4), 10);
            result[14] = 40;
            result = InsertTab(result, Convert_Int_To_Endian(width, 4), 18);
            result = InsertTab(result, Convert_Int_To_Endian(height, 4), 22);
            result[26] = 1;
            result[28] = 24;
            result = InsertTab(result, Convert_Int_To_Endian(imageSize, 4), 34);

            int indice = 54;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    result[indice] = imagePixels[i, j].R;
                    result[indice + 1] = imagePixels[i, j].G;
                    result[indice + 2] = imagePixels[i, j].B;
                    indice = indice + 3;
                }
            }
            File.WriteAllBytes(pathfile, result);
        }

        public byte[] InsertTab(byte[] tabToReturn, byte[] tabToInsert, int indice)
        {
            for (int i = 0; i < tabToInsert.Length; i++)
            {
                tabToReturn[indice + i] = tabToInsert[i];
            }
            return tabToReturn;
        }

        public byte[] ReductionTab(byte[] tab, int iStart, int iStop)
        {
            int sizeTab = iStop - iStart + 1;
            byte[] result = new byte[sizeTab];
            for (int i = 0; i < sizeTab; i++)
            {
                result[i] = tab[iStart + i];
            }
            return result;
        }

        public MyImage testBug()
        {
            return new MyImage(ImagePixels);
        }

        public int Convert_Endian_To_Int(byte[] tab)
        {
            int result = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                result += tab[i] * (int)Math.Pow(256, i);
            }
            return result;
        }

        public byte[] Convert_Int_To_Endian(int val, int nbrbyte)
        {
            byte[] result = new byte[nbrbyte];

            for (int i = nbrbyte - 1; i > -1; i--)
            {
                result[i] = Convert.ToByte(val / Convert.ToInt32(Math.Pow(256, i)));
                val = val % Convert.ToInt32(Math.Pow(256, i));
            }

            return result;
        }

        #endregion

        #region TD 2

        public MyImage NuanceDeGris()
        {
            Pixel[,] resul = new Pixel[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    resul[i, j] = new Pixel();
                    byte moyenne = Convert.ToByte((imagePixels[i, j].R + imagePixels[i, j].G + imagePixels[i, j].B) / 3);
                    resul[i, j].R = moyenne;
                    resul[i, j].G = moyenne;
                    resul[i, j].B = moyenne;
                }
            }
            return new MyImage(resul);
        }

        public MyImage NoirBlanc()
        {
            Pixel[,] resul = new Pixel[height,width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    resul[i, j] = new Pixel();
                    byte moyenne = Convert.ToByte((imagePixels[i, j].R + imagePixels[i, j].G + imagePixels[i, j].B) / 3);

                    if (moyenne > 127)
                    {
                        resul[i, j].R = 255;
                        resul[i, j].B = 255;
                        resul[i, j].G = 255;
                    }
                    else
                    {
                        resul[i, j].R = 0;
                        resul[i, j].B = 0;
                        resul[i, j].G = 0;
                    }
                }
            }
            return new MyImage(resul);
        }

        #endregion

        #region TD 3

        public MyImage Agrandissement(int n)
        {
            Pixel[,] big = new Pixel[height * n, width * n];

            for (int i = 0; i < height * n; i++)
            {
                for (int j = 0; j < width * n; j++)
                {
                    for (int k = i; k < n; k++)
                    {
                        for (int l = j; l < n; l++)
                        {
                            big[k, l] = new Pixel();
                            big[k, l].R = imagePixels[i, j].R;
                            big[k, l].G = imagePixels[i, j].G;
                            big[k, l].B = imagePixels[i, j].B;
                        }
                    }
                }
            }
            return new MyImage(big);
        }

        public MyImage AgrandirRetrecir(int n)
        {
            Pixel[,] bigsmall;
            if (n < 0)
            {
                n = n * (-1);

                bigsmall = new Pixel[height / n, width / n];

                for (int i = 0; i < height; i = i + n)
                {
                    for (int j = 0; j < width; j = j + n)
                    {
                        bigsmall[i / n, j / n] = new Pixel();
                        bigsmall[i / n, j / n].R = imagePixels[i, j].R;
                        bigsmall[i / n, j / n].G = imagePixels[i, j].G;
                        bigsmall[i / n, j / n].B = imagePixels[i, j].B;
                    }
                }
            }
            else
            {
                bigsmall = new Pixel[height * n, width * n];

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        for (int k = i * n; k < (i + 1) * n; k++)
                        {
                            for (int l = j * n; l < (j + 1) * n; l++)
                            {
                                bigsmall[k, l] = new Pixel();
                                bigsmall[k, l].R = imagePixels[i, j].R;
                                bigsmall[k, l].G = imagePixels[i, j].G;
                                bigsmall[k, l].B = imagePixels[i, j].B;
                            }
                        }
                    }
                }
            }

            return new MyImage(bigsmall);
        }

        public MyImage Rotation(int degre)
        {
            degre %= 360;

            double degRad = PI / 180 * degre; // En radian

            int w = (int)(width * Abs(Cos(degRad)) + height * Abs(Sin(degRad)));
            int h = (int)(height * Abs(Cos(degRad)) + width * Abs(Sin(degRad)));

            while (w % 4 != 0) w++;
            while (h % 4 != 0) h++;
            Pixel[,] result = new Pixel[h, w];

            int newX = 0;
            int newY = 0;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    result[i, j] = new Pixel(240, 240, 240);
                }
            }

            if (degre == 90 || degre == 180 || degre == 270) //Cas simples
            {
                switch (degre)
                {
                    case 90:
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                result[width - j - 1, i] = imagePixels[i, j];
                            }
                        }
                        break;

                    case 180:
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                result[height - i - 1, width - 1 - j] = imagePixels[i, j];
                            }
                        }
                        break;
                    case 270:
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                result[j, height - 1 - i] = imagePixels[i, j];
                            }
                        }
                        break;
                }
            }

            else
            {
                if (degre > 0 && degre < 90)
                {
                    newX = (int)((width - 1) * Abs((Sin(degRad))));
                    newY = 0;
                }
                if (degre > 90 && degre < 180)
                {
                    newX = h - 1;
                    newY = (int)((width - 1) * (-Cos(degRad)));
                }
                if (degre > 180 && degre < 270)
                {
                    newX = (int)((height - 1) * Abs(Cos(degRad - PI)));
                    newY = w - 1;
                }
                if (degre > 270)
                {
                    newX = 0;
                    newY = (int)((height - 1) * Abs(Cos(degRad - (3 * PI / 2))));
                }

                // Remplissage

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        result[newX + (int)(Cos(degRad) * i - Sin(degRad) * j), newY + (int)(Sin(degRad) * i + Cos(degRad) * j)] = imagePixels[i, j];
                    }
                }

            }
            return new MyImage(result);
        }

        /*public MyImage Rotation2()
        {
            int degre = 0;
            bool entier = true;

            do
            {
                Console.WriteLine("Saisir l'angle voulu \n");
                try
                {
                    degre = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Saisir un entier");
                    entier = false;
                }

            } while (entier == false);

            degre %= 360;
            double degRad = PI / 180 * degre;
            int w = (int)(height * Abs(Sin(degRad)) + width * Abs(Cos(degRad)));
            int hauteurTemp = (int)(height * Abs(Cos(degRad)) + width * Abs(Sin(degRad)));

            int x = imagePixels.GetLength(0)/2;
            int y = imagePixels.GetLength(1)/2;

            Pixel[,] newImagePixel = new Pixel[hauteurTemp, w];

            for(int i = 0; i < hauteurTemp; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    newImagePixel[i, j] = new Pixel();
                }
            }

            for(int i = 0; i < imagePixels.GetLength(0); i++)
            {
                for(int j = 0; j < imagePixels.GetLength(1); j++)
                {
                    int newX = (int)Cos(degRad) * (i - x) - (int)Sin(degRad) * (j - y) + x;
                    int newY = (int)Sin(degRad) * (i - x) + (int)Cos(degRad) * (j - y) + y;
                    newImagePixel[newX, newY] = imagePixels[i, j];  
                }
            }

            return new MyImage(newImagePixel);
        }*/

        #endregion

        #region TD 4

        public MyImage MatriceConvolution(int[,] matriceonv, string nomMatriceConv)
        {
            Pixel[,] result = new Pixel[height, width];
            //On vérifie que la matrice de voncolution est bien une matrice carré
            if (matriceonv.GetLength(0) == matriceonv.GetLength(1) && matriceonv.GetLength(0) % 2 != 0)
            {
                //n calcule la hauteur au dessus du mileu de la matrice de convolution
                int n = (matriceonv.GetLength(0) - 1) / 2;

                //Parcourir l'image
                for (int h = 0; h < height; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        //on initialise r, g et b a 0
                        int r = 0, g = 0, b = 0;


                        for (int i = 0; i < matriceonv.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriceonv.GetLength(1); j++)
                            {
                                //Calcule les indice a traiter sur la matrice de pixel a chaque tour de la matrice de convolution
                                int x = h - n + i;
                                int y = w - n + j;
                                /*if (h - n + i < 0) x = height - n + i;
                                else if (h - n + i > height - 1) x = i - n - 1;
                                else x = (h - n + i);

                                if (w - n + j < 0) y = width - n + j;
                                else if (w - n + j > width - 1) y = j - n - 1;
                                else y = (w - n + j);*/

                                if (!(x < 0 || y < 0 || x > height - 1 || y > width - 1))
                                {
                                    r += imagePixels[x, y].R * matriceonv[i, j];
                                    g += imagePixels[x, y].G * matriceonv[i, j];
                                    b += imagePixels[x, y].B * matriceonv[i, j];
                                }
                            }
                        }
                        if (nomMatriceConv == "Flou")
                        {
                            r = r / 9;
                            g = g / 9;
                            b = b / 9;
                        }
                        while (r > 255) r = 255;
                        while (g > 255) g = 255;
                        while (b > 255) b = 255;
                        while (r < 0) r = 0;
                        while (g < 0) g = 0;
                        while (b < 0) b = 0;

                        result[h, w] = new Pixel((byte)r, (byte)g, (byte)b);
                    }
                }
            }
            return new MyImage(result);
        }
        #endregion

        #region TD 5

        public MyImage Fractale()
        {
            int MaxIte = 50;
            double xMin = -2;
            double xMax = 0.5;
            double yMin = -1.25;
            double yMax = 1.25;
            int height = 800;
            int width = 800;
            Pixel[,] fractale = new Pixel[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double CR = (x * (xMax - xMin) / width + xMin);
                    double CI = (y * (yMin - yMax) / height + yMax);
                    double ZR = 0;
                    double ZI = 0;
                    int n = 0;

                    while (ZR * ZR + ZI * ZI < 4 && n < MaxIte)
                    {
                        double i = ZR;
                        double j = ZI;
                        ZR = i * i - j * j + CR;
                        ZI = 2 * i * j + CI;
                        n++;

                        if (n == MaxIte)
                        {
                            fractale[x, y] = new Pixel(0, 0, 0);
                        }
                        else
                        {
                            fractale[x, y] = new Pixel(255, Convert.ToByte(255 * n / MaxIte), Convert.ToByte(255 * n / MaxIte));
                        }
                    }
                }
            }
            return new MyImage(fractale);
        }

        public MyImage ImgDansImg(MyImage image1, MyImage image2)
        {
            Pixel[,] image1B = new Pixel[image1.ImagePixels.GetLength(0), image1.ImagePixels.GetLength(1)];
            Pixel[,] image2B = new Pixel[image2.ImagePixels.GetLength(0), image2.ImagePixels.GetLength(1)];
            MyImage result;

            if (image1.ImagePixels.GetLength(0) != image2.ImagePixels.GetLength(0) || image1.ImagePixels.GetLength(1) != image2.imagePixels.GetLength(1)) return null;
            else
            {
                result = new MyImage(new Pixel[image1.imagePixels.GetLength(0), image1.ImagePixels.GetLength(1)]);
                for (int i = 0; i < image1.ImagePixels.GetLength(0); i++)
                {
                    for (int j = 0; j < image1.ImagePixels.GetLength(1); j++)
                    {
                        image1B[i, j] = new Pixel();
                        image1B[i, j].R = (byte)(image1.ImagePixels[i, j].R - (image1.imagePixels[i, j].R % 16));
                        image1B[i, j].G = (byte)(image1.ImagePixels[i, j].G - (image1.imagePixels[i, j].G % 16));
                        image1B[i, j].B = (byte)(image1.ImagePixels[i, j].B - (image1.imagePixels[i, j].B % 16));

                        image2B[i, j] = new Pixel();
                        image2B[i, j].R = (byte)(image2.ImagePixels[i, j].R - (image2.imagePixels[i, j].R % 16));
                        image2B[i, j].G = (byte)(image2.ImagePixels[i, j].G - (image2.imagePixels[i, j].G % 16));
                        image2B[i, j].B = (byte)(image2.ImagePixels[i, j].B - (image2.imagePixels[i, j].B % 16));
                    }
                }
            }
            result.imagePixels = Coder(image1B, image2B);
            return result;
        }

        public Pixel[,] Coder(Pixel[,] img1, Pixel[,] img2)
        {
            Pixel[,] result = new Pixel[img1.GetLength(0), img2.GetLength(1)];
            for (int i = 0; i < img1.GetLength(0); i++)
            {
                for (int j = 0; j < img2.GetLength(1); j++)
                {
                    result[i, j] = new Pixel();
                    result[i, j].R = (byte)(img1[i, j].R + (img2[i, j].R / 16));
                    result[i, j].G = (byte)(img1[i, j].G + (img2[i, j].G / 16));
                    result[i, j].B = (byte)(img1[i, j].B + (img2[i, j].B / 16));

                }
            }
            return result;
        }

        public MyImage DecoderImgDansImg()
        {
            Pixel[,] result = new Pixel[imagePixels.GetLength(0), imagePixels.GetLength(1)];
            for(int i = 0; i < imagePixels.GetLength(0); i++)
            {
                for(int j = 0; j < imagePixels.GetLength(1);j++)
                {
                    result[i, j] = new Pixel();
                    result[i, j].R = (byte)((imagePixels[i, j].R % 16) * 16);
                    result[i, j].G = (byte)((imagePixels[i, j].G % 16) * 16);
                    result[i, j].B = (byte)((imagePixels[i, j].B % 16) * 16);
                }
            }
            return new MyImage(result);
        }


        #endregion

        #region TD 6-7

        public void Huffman()
        {
            Dictionary<Pixel, int> pixelFreq = new Dictionary<Pixel, int>();
            for (int i = 0; i < ImagePixels.GetLength(0); i++)
            {
                for (int j = 0; j < ImagePixels.GetLength(1); j++)
                {
                    if (pixelFreq.ContainsKey(ImagePixels[i, j])) pixelFreq[ImagePixels[i, j]]++;
                    else pixelFreq[ImagePixels[i, j]] = 1;
                }
            }

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
            Dictionary<Pixel, string> pixelHuffman = new Dictionary<Pixel, string>();
            string str = "";
            int d = 0;
            bool breaking = true;

            while (breaking)
            {
                bool first = true;
                n = noeuds[0];
                int index = 0;
                while (n.Pix == null)
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

                pixelHuffman[n.Pix] = str;
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

                if (breaking) str = str.Substring(0, str.Length - s);
            }

            File.Delete("Huffman.txt");
            using (StreamWriter fs = new StreamWriter("Huffman.txt", true))
            {
                for (int i = 0; i < imagePixels.GetLength(0); i++)
                {
                    for (int j = 0; j < imagePixels.GetLength(1); j++)
                    {
                        fs.Write(pixelHuffman[imagePixels[i, j]] + " ");
                    }
                }
            }


            Pixel[,] huffmanPixelMatrice = new Pixel[height, width];
            string[] huffmanStringTab = File.ReadAllText("Huffman.txt").Split(' ');
            int index2 = 0;
            for (int i = 0; i < huffmanPixelMatrice.GetLength(0); i++)
            {
                for (int j = 0; j < huffmanPixelMatrice.GetLength(1); j++)
                {
                    huffmanPixelMatrice[i, j] = getPixelInDico(pixelHuffman, huffmanStringTab[index2]);
                    index2++;
                }
            }


            new MyImage(huffmanPixelMatrice).From_Image_To_File("Images/NewImages/Huffman.bmp");
        }

        public Pixel getPixelInDico(Dictionary<Pixel, string> pixelDictionary, string pixelStr)
        {
            Pixel resul = new Pixel();
            foreach (var pixel in pixelDictionary)
            {
                if (pixel.Value == pixelStr)
                {
                    resul = pixel.Key;
                    break;
                }
            }
            return resul;
        }

        #endregion
        #endregion

    }
}
