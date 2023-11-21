using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naha
{
    public partial class RapCover : Form
    {
        album resul = new album("","","","");
        album[] list = {
            new album("Nekfeu", "Cyborg", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/cyborg.bmp"),
            new album("Nekfeu", "Feu", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/feu.bmp"),
            new album("Orelsan", "Civilisation", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/civilisation.bmp"),
            new album("Ninho", "Destin", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/destin.bmp"),
            new album("Ninho", "Jefe", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/jefe.bmp"),
            new album("Ninho", "MILS 3", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/mils3.bmp"),
            new album("Damso", "Ipséité", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/ipseite.bmp"),
            new album("SCH", "Jvlivs 2", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/jvlivs2.bmp"),
            new album("Jazzy-Bazz", "Mémoria", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/memoria.bmp"),
            new album("Laylow", "L'étrange Histoire de Mr Anderson", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/mr-anderson.bmp"),
            new album("Laylow", "Trinity", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/trinity.bmp"),
            new album("Vald", "V", "Rapfr","C:/Users/rpaup/Desktop/Naha/Naha/Images/Rapfr/v.bmp")
        };
        int counter = 0;
        int fc = 15;
        public RapCover()
        {
            InitializeComponent();
            tour();
        }

        public void tour()
        {
            if (list.Length == 0 && counter == 0)
            {
                var menu = new Menu();
                menu.ShowDialog();
                this.Hide();

            }

            else
            {
                if (counter == 0)
                {
                    ChoixAlbum();
                    label_album.Text = "";
                    label_artiste.Text = "";
                    afficherImage();
                    counter++;
                }

                else if (counter == 1)
                {
                    Bitmap cover = new Bitmap(Path.GetFullPath(resul.FileCover));
                    pbx_cover.Image = cover;
                    label_album.Text = resul.Title;
                    label_artiste.Text = resul.Artist;
                    counter--;
                }
            }
        }

        public void ChoixAlbum()
        {
            Random random = new Random();
            int nblist = random.Next(list.Length);
            resul = list[nblist];
            list = list.Where((source, index) => index != nblist).ToArray();
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            tour();
        }

        private void tB_difficulty_Scroll(object sender, EventArgs e)
        {
            label_TbValue.Text = tB_difficulty.Value.ToString();
            fc = tB_difficulty.Value;
            afficherImage();
        }

        public void afficherImage()
        {
            Bitmap cover = new Bitmap(Path.GetFullPath(resul.FileCover));
            Bitmap coverPix = new Bitmap(fc, fc);
            int facteur = cover.Width / fc;
            int i = 0;
            int j = 0;
            for (int x = 0; x < cover.Width; x = x + facteur)
            {
                i++;
                j = 0;
                for (int y = 0; y < cover.Height; y = y + facteur)
                {
                    Color color = cover.GetPixel(x, y);
                    Color newcolor = Color.FromArgb(color.R, color.G, color.B);
                    coverPix.SetPixel(i, j, newcolor);
                    j++;
                    if (j == fc - 1) y = cover.Height;
                }
                if (i == fc - 1) x = cover.Height;
            }
            pbx_cover.Image = coverPix;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fc = 30;
            label_TbValue.Text = fc.ToString();
            afficherImage();
        }

        private void button_lev2_Click(object sender, EventArgs e)
        {
            fc = 20;
            label_TbValue.Text = fc.ToString();
            afficherImage();
        }

        private void button_lev1_Click(object sender, EventArgs e)
        {
            fc = 10;
            label_TbValue.Text = fc.ToString();
            afficherImage();
        }
    }
}
