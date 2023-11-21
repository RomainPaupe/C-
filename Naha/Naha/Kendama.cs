using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Naha
{
    public partial class Kendama : Form
    {
        string[] trickList = { "Spike", "Small Cup", "Big Cup", "Base Cup" };
        int counter = 1;
        int precendant;
        int time = 1;
        public Kendama()
        {
            InitializeComponent();
        }

        public void lancement()
        {
            var rad = new Random();
            int a;
            do {
                a = rad.Next(trickList.Length);
            } while (precendant == a);
            precendant = a;

            label_tricks.Text =trickList[a];

        }

        public void vocal(int a)
        {
            SoundPlayer voix = new SoundPlayer();
            switch (a)
                {
                case 0:
                    voix.SoundLocation = "C:/Users/rpaup/Desktop/Naha/Naha/Musique/Spike.wav";
                    break;
                case 1:
                    voix.SoundLocation = "C:/Users/rpaup/Desktop/Naha/Naha/Musique/Small-Cup.wav";
                    break;
                case 2: 
                    voix.SoundLocation = "C:/Users/rpaup/Desktop/Naha/Naha/Musique/Big-Cup.wav";
                    break;
                case 3:
                    voix.SoundLocation = "C:/Users/rpaup/Desktop/Naha/Naha/Musique/Base-Cup.wav";
                    break;
            }
            voix.PlaySync();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                button1.Text = "STOP";
                counter--;
                timer1.Start();
                lancement();
            }
            else if(counter == 0)
            {
                counter++;
                button1.Text = "START";
                label_tricks.Text = "OFF";
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time == 1)
            {
                lancement();
                time--;
                timer1.Interval = 1;
            }

            else if(time == 0)
            {
                vocal(precendant);
                time++;
                timer1.Interval = 1500;
            }
        }

    }
}
