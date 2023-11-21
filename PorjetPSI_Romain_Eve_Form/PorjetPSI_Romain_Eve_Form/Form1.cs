using System.Windows.Forms;
using System.Drawing;

namespace PorjetPSI_Romain_Eve_Form
{
    public partial class Form1 : Form
    {
        string[] myImgaeList = { "coco", "lac", "cigne", "escargot", "plage", "riviere", "test" };
        MyImage currentImage;
        MyImage imageDansImage1;
        MyImage imageDansImage2;
        string action = "";
        int size = 1;
        Color paintballColor = Color.White;
        int taillePaintball = 1;
        Pixel couleurPaint = new Pixel(255, 255, 255);

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            if (currentImage == null) currentImage = new MyImage("Images/coco.bmp");
            listBoxImages.Items.Clear();
            listBoxImages.Items.AddRange(myImgaeList);
            pictureBoxImage.Show();

            labelUnderImage.Hide();
            listBoxColor.Hide();
            buttonMoins.Hide();
            buttonPlus.Hide();
            buttonRotation.Hide();
            labelRotation.Hide();
            textBoxRotation.Hide();
            labelHuffman.Hide();
            labelChoixCouleur.Hide();
            listBoxColor.Hide();
            labelTaille.Hide();
            numericUpDownPaintball.Hide();


            action = "";
        }

        private void agrandireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            buttonMoins.Show();
            buttonPlus.Show();
            action = "Agrandire Retrecire";
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (action == "Image dans image")
            {
                if (imageDansImage1 != null && imageDansImage2 != null)
                {
                    imageDansImage1 = null;
                    imageDansImage2 = null;
                }
                if (imageDansImage1 == null)
                {
                    imageDansImage1 = new MyImage($"Images/{listBoxImages.SelectedItem.ToString()}.bmp");
                    labelUnderImage.Text = $"Image 1 : {listBoxImages.SelectedItem.ToString()}        Image 2 : ";
                }
                else
                {
                    imageDansImage2 = new MyImage($"Images/{listBoxImages.SelectedItem.ToString()}.bmp");
                    labelUnderImage.Text += listBoxImages.SelectedItem.ToString();
                }
                if (imageDansImage1 != null && imageDansImage2 != null)
                {
                    currentImage = (new MyImage()).ImgDansImg(imageDansImage1, imageDansImage2);
                    currentImage.From_Image_To_File("Images/NewImages/ImgDansImg.bmp");
                    pictureBoxImage.ImageLocation = "Images/NewImages/ImgDansImg.bmp";
                    buttonRotation.Text = "Decoder";
                    buttonRotation.Show();
                }
            }
            else
            {
                currentImage = new MyImage($"Images/{listBoxImages.SelectedItem.ToString()}.bmp");
                pictureBoxImage.ImageLocation = $"Images/{listBoxImages.SelectedItem.ToString()}.bmp";

            }
        }

        private void nunaceGrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            currentImage.NuanceDeGris().From_Image_To_File("Images/NewImages/NunaceGris.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/NunaceGris.bmp";
        }

        private void noirEtBlancToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            currentImage.NoirBlanc().From_Image_To_File("Images/NewImages/NoirBlanc.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/NoirBlanc.bmp";
        }

        private void flouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            int[,] flou = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            currentImage.MatriceConvolution(flou, "Flou").From_Image_To_File("Images/NewImages/Flou.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/Flou.bmp";
        }

        private void renforcementDesBordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            int[,] renforcementDesBords = new int[,] { { 0, 0, 0 }, { -1, 1, 0 }, { 0, 0, 0 } };
            currentImage.MatriceConvolution(renforcementDesBords, "Pas Flou").From_Image_To_File("Images/NewImages/renforcementDesBords.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/renforcementDesBords.bmp";
        }

        private void repoussageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            int[,] repoussage = new int[,] { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
            currentImage.MatriceConvolution(repoussage, "Pas Flou").From_Image_To_File("Images/NewImages/repoussage.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/repoussage.bmp";
        }

        private void detectionDeContourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            int[,] detectionDeContour = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            currentImage.MatriceConvolution(detectionDeContour, "Pas Flou").From_Image_To_File("Images/NewImages/detectionDeContour.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/detectionDeContour.bmp";
        }

        private void fractaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reset();
            (new MyImage()).Fractale().From_Image_To_File("Images/NewImages/fractale.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/fractale.bmp";
        }

        private void imageDansImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            action = "Image dans image";
            string[] myImgaeCarreList = { "cigne", "escargot", "plage", "riviere" };
            listBoxImages.Items.Clear();
            listBoxImages.Items.AddRange(myImgaeCarreList);
            labelUnderImage.Show();
            labelUnderImage.Text = $"Image 1 :        Image 2 : ";
            textBoxRotation.Hide();
            buttonRotation.Hide();
            labelRotation.Hide();
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            size--;
            currentImage.AgrandirRetrecir(size).From_Image_To_File("Images/NewImages/AgrandireRetrecire.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/AgrandireRetrecire.bmp";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            size++;
            currentImage.AgrandirRetrecir(size).From_Image_To_File("Images/NewImages/AgrandireRetrecire.bmp");
            pictureBoxImage.ImageLocation = "Images/NewImages/AgrandireRetrecire.bmp";
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            action = "Rotation";
            textBoxRotation.Show();
            buttonRotation.Show();
            buttonRotation.Text = "Entrer";
            labelRotation.Show();
        }

        private void buttonRotation_Click(object sender, EventArgs e)
        {
            if (action == "Rotation")
            {
                int degre = 0;
                try
                {
                    degre = Convert.ToInt32(textBoxRotation.Text);
                    if (degre > 360) degre = 0;
                }
                catch (Exception ex) { }
                currentImage.Rotation(degre).From_Image_To_File("Images/NewImages/Rotation.bmp");
                pictureBoxImage.ImageLocation = "Images/NewImages/Rotation.bmp";
                textBoxRotation.Text = "";
            }
            else if (action == "Huffman")
            {
                Reset();
                pictureBoxImage.ImageLocation = "Images/NewImages/Huffman.bmp";
            }
            else if (action == "Image dans image")
            {
                currentImage.DecoderImgDansImg().From_Image_To_File("Images/NewImages/Decoder.bmp");
                pictureBoxImage.ImageLocation = "Images/NewImages/Decoder.bmp";
            }

        }

        private void huffmanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reset();
            action = "Huffman";
            buttonRotation.Text = "Afficher";
            labelHuffman.Show();
            pictureBoxImage.Hide();
            buttonRotation.Show();
            currentImage.Huffman();
            labelHuffman.Text = File.ReadAllText("huffman.txt");

        }

        private void paintballToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reset();
            action = "Paintball";
            string[] colors = new string[] { "Rouge", "Vert", "Bleu", "Jaune", "Blanc" };
            listBoxColor.Items.Clear();
            listBoxColor.Items.AddRange(colors);
            listBoxColor.Show();
            labelChoixCouleur.Show();
            labelTaille.Show();
            numericUpDownPaintball.Show();
        }

        private void mouseClickImage(object sender, MouseEventArgs e)
        {
            if (action == "Paintball")
            {
                int val = taillePaintball / 2;
                int x = e.X;
                int y = e.Y;
                int j = x - ((pictureBoxImage.Width - currentImage.Width) / 2) - val;
                int i = pictureBoxImage.Height - y - ((pictureBoxImage.Height - currentImage.Height) / 2) - val;
                for (int a = 0; a < taillePaintball; a++)
                {
                    for (int b = 0; b < taillePaintball; b++)
                    {
                        if (a < currentImage.Width - 1 && a > 0 && b < currentImage.Height - 1 && b > 0)
                        {
                            currentImage.ImagePixels[i + a, j + b] = couleurPaint;
                            currentImage.From_Image_To_File("Images/NewImages/Paintball.bmp");
                        }

                    }
                }
                currentImage.From_Image_To_File("Images/NewImages/Paintball.bmp");
                labelUnderImage.Text = $"X : {j}    Y : {y}";
                pictureBoxImage.ImageLocation = "Images/NewImages/Paintball.bmp";
            }
        }

        private void listBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] colors = new string[] { "Red", "Green", "Blue", "Yellow", "White" };
            switch (listBoxColor.SelectedIndex)
            {
                case 0:
                    paintballColor = Color.Red;
                    couleurPaint = new Pixel(0, 0, 255);
                    break;
                case 1:
                    paintballColor = Color.Green;
                    couleurPaint = new Pixel(0, 255, 0);
                    break;
                case 2:
                    paintballColor = Color.Blue;
                    couleurPaint = new Pixel(255, 0, 0);
                    break;
                case 3:
                    paintballColor = Color.Yellow;
                    couleurPaint = new Pixel(0, 255, 255);
                    break;
                case 4:
                    paintballColor = Color.White;
                    couleurPaint = new Pixel(255, 255, 255);
                    break;
            }
            listBoxColor.BackColor = paintballColor;
        }

        private void numericUpDownPaintball_ValueChanged(object sender, EventArgs e)
        {
            taillePaintball = (int)numericUpDownPaintball.Value;
        }
    }
}