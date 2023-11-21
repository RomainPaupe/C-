using System.ComponentModel;
using System.Drawing.Design;

namespace Naha
{
    public partial class acceuil : Form
    {
        biere biere = Program.choisir_biere(Program.init_list_biere());
        int count = 1;
        int score = 0;


        biere[] list = new biere[] {
            new biere("1664", "5.5", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/seizequatre.jfif"),
            new biere("Kronenbourg", "4.2", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/kro.jpg"),
            new biere("Triple karmeliet", "8.4", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/tripleK.jpg"),
            new biere("Goudale", "7.2", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/goudale.jfif"),
            new biere("8.6", "8.6", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/huitsix.jpg"),
            new biere("Leffe", "6.6", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/leffe.jpg"),
            new biere("Heineken", "5", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/heineken.jpg"),
            new biere("Desperados", "5.9", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/desperados.jpg"),
            new biere("Hoegaarden", "4.9", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/hoegaarden.jpg"),
            new biere("Guinness", "4.2", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/guinness.jpg"),
            new biere("Corona", "4.6", "C:/Users/rpaup/Desktop/Naha/Naha/Images/Bière/corona.jpg")};
        public acceuil()
        {
            InitializeComponent();
            tour();
        }

        private void button_fin_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.ShowDialog();
            this.Hide();
            
        }
        public void tour()      
        {
            if (list.Length == 0)
            {
                //Effacement de tout les controles sur la page
                Controls.Remove(label_nomBiere);
                Controls.Remove(label1);
                Controls.Remove(label2);
                Controls.Remove(label_TorF);
                Controls.Remove(label_score);
                Controls.Remove(textBox_degre);
                Controls.Remove(pbx_biere);
                Controls.Remove(button_jouer);

                //Création d'un nouveau label pour anoncer la fin de partie et afficher le score
                Label label_fin = new Label();
                label_fin.AutoSize = true;
                label_fin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                label_fin.Location = new System.Drawing.Point(270, 111);
                label_fin.Name = "label_fin";
                label_fin.TabIndex = 4;
                label_fin.Text = "Partie terminer !\nScore : " + Convert.ToString(score);

                //Création du bouton quitter
                Button button_fin = new Button();
                button_fin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                button_fin.Location = new System.Drawing.Point(270, 304);
                button_fin.Name = "button1";
                button_fin.Size = new System.Drawing.Size(261, 96);
                button_fin.TabIndex = 12;
                button_fin.Text = "QUITTER";
                button_fin.UseVisualStyleBackColor = true;
                button_fin.Click += new System.EventHandler(button_fin_Click);

                //Ajout du label et du button sur la page
                this.Controls.Add(label_fin);
                this.Controls.Add(button_fin);
            }

            else
            {
                if (count == 1)
                {
                    //Initialisation du random
                    var random = new Random();
                    int nblist = random.Next(list.Length);

                    //Clear la page
                    label_TorF.Text = "";
                    textBox_degre.Text = "";
                    button_jouer.Text = "VERIFIER\n(space)";

                    //Initialisation d'une nouvelle biere
                    biere = list[nblist];
                    list = list.Where((source, index) => index != nblist).ToArray();
                    label_nomBiere.Text = biere.Nom;
                    pbx_biere.Image = Image.FromFile(biere.File);
                    count--;
                }

                else if (count == 0)
                {
                    //Remplacer les , en . 
                    string reponse = textBox_degre.Text;
                    reponse = reponse.Replace(',', '.');
                    button_jouer.Text = "BIERE SUIVANTE\n(space)";

                    //Vérifier la réponse
                    if (reponse == biere.Degre)
                    {
                        label_TorF.Text = "VRAI";
                        label_TorF.ForeColor = Color.Green;
                        score++;
                        label_score.Text = Convert.ToString(score);

                    }
                    else
                    {
                        label_TorF.Text = "FAUX, REPONSE = " + biere.Degre;
                        label_TorF.ForeColor = Color.Red;
                    }
                    count++;
                }
            }

        }
        private void button_jouer_Click(object sender, EventArgs e)
        {
            tour();
        }
    }
}
