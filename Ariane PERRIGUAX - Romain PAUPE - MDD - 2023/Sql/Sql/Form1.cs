using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace Sql
{
    public partial class FormMagasin : Form
    {
        MySqlConnection maConnexion = null;
        Client clientConnecter;
        int prixBouquet = 0;
        Panel[] panelList;
        public FormMagasin(MySqlConnection maConnexion)
        {
            InitializeComponent();
            panelList = new Panel[] { panelStatistique, panelCommandeSucces, panelClient, panelIncription, panelProduits, panelCommandePersonalise, panelCommandStandard, panelInfoClient, panelSuiviCommande, panelAdmin };
            PanelLocation();
            DisplayPannel(panelClient);
            this.maConnexion = maConnexion;
            buttonCommande.Hide();
            buttonCommandeStandard.Hide();
            buttonSuiviCommande.Hide();
            buttonStat.Hide();
        }

        #region pannelControle
        private void buttonCommande_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelCommandePersonalise);
        }
        private void buttonClient_Click_1(object sender, EventArgs e)
        {
            if (clientConnecter == null) DisplayPannel(panelClient);
            else DisplayPannel(panelInfoClient);
        }
        private void buttonProduits_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelProduits);
        }
        private void buttonNewCount_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelIncription);
        }
        private void buttonCommandeStandar_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelCommandStandard);
        }
        private void buttonSuiviCommande_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelSuiviCommande);
        }
        private void buttonDeconnecter_Click(object sender, EventArgs e)
        {
            clientConnecter = null;
            buttonCommande.Hide();
            buttonCommandeStandard.Hide();
            labelConnecter.Text = "";
            DisplayPannel(panelClient);
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelAdmin);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelInfoClient);
        }
        private void buttonStat_Click(object sender, EventArgs e)
        {
            DisplayPannel(panelStatistique);
        }
        private void DisplayPannel(Panel pannelName)
        {
            switch (pannelName.Name)
            {
                case "panelIncription":
                    labelErreur.Hide();
                    break;
                case "panelClient":
                    labelErreurConnexion.Hide();
                    break;
                case "panelProduits":
                    ProduitView();
                    break;
                case "panelCommandePersonalise":
                    CommandePersonnalise();
                    break;
                case "panelCommandStandard":
                    CommandeStandard();
                    break;
                case "panelInfoClient":
                    GetInfoClient();
                    break;
                case "panelSuiviCommande":
                    SuiviCommande();
                    break;
                case "panelStatistique":
                    GetStatistiques();
                    break;


            }
            for (int i = 0; i < panelList.Length; i++) { panelList[i].Hide(); }
            pannelName.BringToFront();
            pannelName.Show();
        }
        private void PanelLocation()
        {
            ClientSize = new Size(1400, 970);
            for (int i = 0; i < panelList.Length; i++)
            {
                int y = (ClientSize.Height - 20) / 2 - panelList[i].Height / 2;
                int x = ClientSize.Width / 2 - panelList[i].Width / 2;
                panelList[i].Location = new Point(x, y);
            }
        }
        #endregion

        #region Commande
        private void CommandePersonnalise()
        {
            MySqlCommand getMagasin = maConnexion.CreateCommand();
            getMagasin.CommandText = $"select * from magasin";

            listBoxMagasins.Items.Clear();
            MySqlDataReader MagasinReader = getMagasin.ExecuteReader();
            while (MagasinReader.Read())
            {
                listBoxMagasins.Items.Add(MagasinReader[1].ToString());
            }
            MagasinReader.Close();
            getMagasin.Dispose();

            MySqlCommand getAccessoir = maConnexion.CreateCommand();
            getAccessoir.CommandText = $"Select * from accessoir;";

            MySqlDataReader accessoirReader = getAccessoir.ExecuteReader();
            while (accessoirReader.Read())
            {
                string[] accessoir = { accessoirReader[0].ToString(), accessoirReader[1].ToString(), "" };
                dataGridViewAccessoir.Rows.Add(accessoir);
            }
            accessoirReader.Close();
            getAccessoir.Dispose();
        }
        private void CommandeStandard()
        {
            MySqlCommand getMagasin = maConnexion.CreateCommand();
            getMagasin.CommandText = $"select * from magasin";

            listBoxMagasin2.Items.Clear();
            MySqlDataReader MagasinReader = getMagasin.ExecuteReader();
            while (MagasinReader.Read())
            {
                listBoxMagasin2.Items.Add(MagasinReader[1].ToString());
            }
            MagasinReader.Close();
            getMagasin.Dispose();

            MySqlCommand getBouquet = maConnexion.CreateCommand();
            getBouquet.CommandText = "select* from bouquet where categorie = 'Standard'; ";

            MySqlDataReader bouquetReader = getBouquet.ExecuteReader();
            while (bouquetReader.Read())
            {
                string[] accessoir = { bouquetReader[1].ToString(), bouquetReader[3].ToString(), bouquetReader[4].ToString() };
                dataGridViewCommandeStandard.Rows.Add(accessoir);
            }
            bouquetReader.Close();
            getBouquet.Dispose();
        }
        private Dictionary<string, string> DetailCommande()
        {
            var map = new Dictionary<string, string>();
            prixBouquet = 0;
            for (int i = 0; i < dataGridViewCommandePersonalise.Rows.Count; i++)
            {
                if (dataGridViewCommandePersonalise.Rows[i].Cells[3].Value != "")
                {
                    try
                    {
                        prixBouquet += Convert.ToInt32(dataGridViewCommandePersonalise.Rows[i].Cells[3].Value) * Convert.ToInt32(dataGridViewCommandePersonalise.Rows[i].Cells[1].Value);
                        map.Add((string)(dataGridViewCommandePersonalise.Rows[i].Cells[0].Value), (String)dataGridViewCommandePersonalise.Rows[i].Cells[3].Value);
                    }
                    catch (Exception ex) { }
                }
            }

            for (int i = 0; i < dataGridViewAccessoir.Rows.Count; i++)
            {
                if (dataGridViewAccessoir.Rows[i].Cells[2].Value != "")
                {
                    try
                    {
                        prixBouquet += Convert.ToInt32(dataGridViewAccessoir.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridViewAccessoir.Rows[i].Cells[1].Value);
                        map.Add((string)(dataGridViewAccessoir.Rows[i].Cells[0].Value), (String)dataGridViewAccessoir.Rows[i].Cells[2].Value);
                    }
                    catch (Exception ex) { }
                }
            }
            return map;
        }
        private void buttonActualiserPrixTotal_Click(object sender, EventArgs e)
        {
            var map = DetailCommande();

            string list = "";
            foreach (KeyValuePair<string, string> i in map)
            {
                list += $"{i.Key} - {i.Value}\r\n";
            }

            labelPrixTotal.Text = $"Détail de la commande : \r\n{list}Prix total : {prixBouquet}€\r\n";
        }
        private void listBoxMagasins_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCommandePersonalise.Rows.Clear();
            MySqlCommand getFleur = maConnexion.CreateCommand();
            getFleur.CommandText = $"select stock.id_fleur, fleur.prix, stock.quantite_disponible from stock natural join fleur where stock.id_magasin = {listBoxMagasins.SelectedIndex + 1};";

            MySqlDataReader getFleurReader = getFleur.ExecuteReader();
            while (getFleurReader.Read())
            {
                string[] fleur = { getFleurReader[0].ToString(), getFleurReader[1].ToString(), getFleurReader[2].ToString(), "" };
                dataGridViewCommandePersonalise.Rows.Add(fleur);
            }
            getFleurReader.Close();
            getFleur.Dispose();
        }
        private void buttonValiderCommande_Click(object sender, EventArgs e)
        {
            int idB = 0;
            int idC = 0;
            int idM = listBoxMagasins.SelectedIndex + 1;
            DateTime dateLivraison = dateTimePickerCommande.Value;
            DateTime dateCommande = DateTime.Now;
            string etatCommande = EtatCommande(dateLivraison, dateCommande, "CommandeP");

            string nomBouquet = $"Bouquet de {clientConnecter.getPrenom()} {clientConnecter.getNom()}";
            string categorie = "Bouquet Personnalisé";
            int prixBouquetFinal = prixBouquet;
            string composition = "Bouquet composé de ";
            var map = DetailCommande();

            for (int i = 0; i < map.Count; i++)
            {
                KeyValuePair<string, string> item = map.ElementAt(i);
                if (i + 1 == map.Count - 1) composition += $"{item.Value} {item.Key} et ";
                else if (i + 1 == map.Count) composition += $"{item.Value} {item.Key}.";
                else composition += $"{item.Value} {item.Key}, ";
            }

            MySqlCommand cmdIdB = maConnexion.CreateCommand();
            cmdIdB.CommandText = $"select count(*) from bouquet;";

            MySqlDataReader IdBReader = cmdIdB.ExecuteReader();
            while (IdBReader.Read())
            {
                idB = Convert.ToInt32(IdBReader.GetString(0)) + 1;
            }
            IdBReader.Close();
            cmdIdB.Dispose();

            MySqlCommand cmdCountNbCient = maConnexion.CreateCommand();
            cmdCountNbCient.CommandText = "select count(*) from commande";

            MySqlDataReader nbClientReader = cmdCountNbCient.ExecuteReader();
            while (nbClientReader.Read())
            {
                idC = Convert.ToInt32(nbClientReader.GetString(0)) + 1;
            }
            nbClientReader.Close();
            cmdCountNbCient.Dispose();

            if (dateCommande > dateLivraison)
            {
                labelErreurCommande.Text = "ERREUR, La date de livraison n'est pas valide";
            }
            else if (QuantiteEnStock() && (dateLivraison - dateCommande).Days <= 3)
            {
                labelErreurCommande.Text = "ERREUR, Les quantitées de fleurs sélectionnez ne correspondent pas au disponibilité en magasin";
            }
            else
            {
                if ((dateLivraison - dateCommande).Days <= 3)
                {
                    for (int i = 0; i < map.Count; i++)
                    {
                        KeyValuePair<string, string> item = map.ElementAt(i);

                        MySqlCommand fleurExist = maConnexion.CreateCommand();
                        fleurExist.CommandText = $"select count(*) from fleur where id_fleur = '{item.Key}';";
                        int fleurCount = 0;
                        MySqlDataReader fleurExistReader = fleurExist.ExecuteReader();
                        while (fleurExistReader.Read())
                        {
                            fleurCount = Convert.ToInt32(fleurExistReader.GetString(0));
                        }
                        fleurExistReader.Close();
                        fleurExist.Dispose();

                        if (fleurCount != 0)
                        {
                            MySqlCommand deleteFleur = maConnexion.CreateCommand();
                            deleteFleur.CommandText = $"update stock Set quantite_disponible = quantite_disponible - {item.Value} where id_magasin = {idM} and id_fleur = '{item.Key}';";

                            deleteFleur.ExecuteNonQuery();
                            deleteFleur.Dispose();
                        }
                    }

                }
                string cmdTextB = $"INSERT INTO `magasins`.`bouquet` VALUES({idB}, '{nomBouquet}', '{categorie}', {prixBouquet}, '{composition}');";
                MySqlCommand cmdNewBouquet = maConnexion.CreateCommand();
                cmdNewBouquet.CommandText = cmdTextB;
                cmdNewBouquet.ExecuteNonQuery();
                cmdNewBouquet.Dispose();

                string cmdTextC = $"INSERT INTO `magasins`.`commande` VALUES({idC}, '{dateLivraison.Year}-{dateLivraison.Month}-{dateLivraison.Day}', '{dateCommande.Year}-{dateCommande.Month}-{dateCommande.Day}', {idB}, {idM}, {clientConnecter.getId()}, '{etatCommande}');";
                MySqlCommand cmdNewCommande = maConnexion.CreateCommand();
                cmdNewCommande.CommandText = cmdTextC;
                cmdNewCommande.ExecuteNonQuery();
                cmdNewCommande.Dispose();
                DisplayPannel(panelCommandeSucces);
            }
        }
        private void buttonValideCommandStandard_Click(object sender, EventArgs e)
        {
            int idB = 0;
            int idC = 0;
            int idM = listBoxMagasin2.SelectedIndex + 1;
            DateTime dateLivraison = dateTimePickerCommandeS.Value;
            DateTime dateCommande = DateTime.Now;
            string etatCommande = EtatCommande(dateLivraison, dateCommande, "CommandeP");

            string nomBouquet = dataGridViewCommandeStandard.SelectedRows[0].Cells[0].Value.ToString();
            string categorie = "Bouquet Standard";
            int prixBouquetFinal = Convert.ToInt32(dataGridViewCommandeStandard.SelectedRows[0].Cells[1].Value.ToString());
            string composition = dataGridViewCommandeStandard.SelectedRows[0].Cells[2].Value.ToString();

            MySqlCommand cmdIdB = maConnexion.CreateCommand();
            cmdIdB.CommandText = $"select id_bouquet from bouquet where nom = '{nomBouquet}';";

            MySqlDataReader IdBReader = cmdIdB.ExecuteReader();
            while (IdBReader.Read())
            {
                idB = Convert.ToInt32(IdBReader.GetString(0)) + 1;
            }
            IdBReader.Close();
            cmdIdB.Dispose();

            MySqlCommand cmdCountNbCient = maConnexion.CreateCommand();
            cmdCountNbCient.CommandText = "select count(*) from commande";

            MySqlDataReader nbClientReader = cmdCountNbCient.ExecuteReader();
            while (nbClientReader.Read())
            {
                idC = Convert.ToInt32(nbClientReader.GetString(0)) + 1;
            }
            nbClientReader.Close();
            cmdCountNbCient.Dispose();

            if (dateCommande > dateLivraison)
            {
                labelErreurCommandeS.Text = "ERREUR, La date de livraison n'est pas valide";
            }
            else
            {
                string cmdTextC = $"INSERT INTO `magasins`.`commande` VALUES({idC}, '{dateLivraison.Year}-{dateLivraison.Month}-{dateLivraison.Day}', '{dateCommande.Year}-{dateCommande.Month}-{dateCommande.Day}', {idB}, {idM}, {clientConnecter.getId()}, '{etatCommande}');";
                MySqlCommand cmdNewCommande = maConnexion.CreateCommand();
                cmdNewCommande.CommandText = cmdTextC;
                cmdNewCommande.ExecuteNonQuery();
                cmdNewCommande.Dispose();
                DisplayPannel(panelCommandeSucces);
            }
        }
        private bool QuantiteEnStock()
        {
            for (int i = 0; i < dataGridViewCommandePersonalise.Rows.Count; i++)
            {
                if (dataGridViewCommandePersonalise.Rows[i].Cells[3].Value != "")
                {
                    try
                    {
                        if (Convert.ToInt32(dataGridViewCommandePersonalise.Rows[i].Cells[3].Value) > Convert.ToInt32(dataGridViewCommandePersonalise.Rows[i].Cells[2].Value)) return true;
                    }
                    catch (Exception ex) { }
                }
            }
            return false;
        }
        private string EtatCommande(DateTime livraison, DateTime commande, string typeCommande)
        {
            TimeSpan delay = livraison - commande;
            string resul = "";

            if (delay.Days <= 3 && typeCommande == "CommandeP") resul = "CPAV";
            else if (delay.Days <= 3 && typeCommande == "CommandeS") resul = "VINV";
            else resul = "CC";

            return resul;
        }

        #endregion

        #region Produit
        private void ListFleur(string cmd, DataGridView grid)
        {
            MySqlCommand getFleur = maConnexion.CreateCommand();
            getFleur.CommandText = cmd;

            MySqlDataReader getFleurReader = getFleur.ExecuteReader();
            while (getFleurReader.Read())
            {
                string[] fleur = { getFleurReader[0].ToString(), getFleurReader[1].ToString() + "€", getFleurReader[2].ToString(), getFleurReader[3].ToString() };
                grid.Rows.Add(fleur);
            }
            getFleurReader.Close();
            getFleur.Dispose();
        }

        private void ListAccessoir(string cmd, DataGridView grid)
        {
            MySqlCommand getAccessoir = maConnexion.CreateCommand();
            getAccessoir.CommandText = cmd;

            MySqlDataReader AccessoirReader = getAccessoir.ExecuteReader();
            while (AccessoirReader.Read())
            {
                string[] fleur = { AccessoirReader[0].ToString(), AccessoirReader[1].ToString() + "€", "Illimité", "a l'année" };
                grid.Rows.Add(fleur);
            }
            AccessoirReader.Close();
            getAccessoir.Dispose();
        }

        public void ProduitView()
        {
            int nbMagasin = 0;
            MySqlCommand getNbMagasin = maConnexion.CreateCommand();
            getNbMagasin.CommandText = "select count(*) from magasin;";

            MySqlDataReader nbMagasinReader = getNbMagasin.ExecuteReader();
            while (nbMagasinReader.Read())
            {
                nbMagasin = Convert.ToInt32(nbMagasinReader[0]);
            }
            nbMagasinReader.Close();
            getNbMagasin.Dispose();

            for (int i = 1; i <= nbMagasin + 2; i++)
            {
                #region creation datagrid et label
                int posH = 313 * (i - 1);
                int x = panelProduits.Width / 2;
                Label label = new Label();
                label.Size = new Size(473, 33);
                label.Location = new Point(x - label.Width / 2, 20 + posH);
                label.TabIndex = 1;
                label.TextAlign = ContentAlignment.TopCenter;

                ColumnNom = new DataGridViewTextBoxColumn();
                ColumnPrix = new DataGridViewTextBoxColumn();
                ColumnDispo = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ColumnQuantite = new DataGridViewTextBoxColumn();
                ColumnNom.HeaderText = "Nom";
                ColumnNom.Name = "ColumnNom";
                ColumnNom.ReadOnly = true;
                ColumnPrix.HeaderText = "Prix";
                ColumnPrix.Name = "ColumnPrix";
                ColumnPrix.ReadOnly = true;
                ColumnDispo.HeaderText = "Disponbilité";
                ColumnDispo.Name = "ColumnDispo";
                ColumnDispo.ReadOnly = true;
                ColumnQuantite.HeaderText = "Quantité";
                ColumnQuantite.Name = "ColumnQuantite";
                ColumnQuantite.ReadOnly = true;

                DataGridView grid = new DataGridView();
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.BackgroundColor = Color.White;
                grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                grid.Columns.AddRange(new DataGridViewColumn[] { ColumnNom, ColumnPrix, ColumnQuantite, ColumnDispo });
                grid.Location = new Point(x - grid.Width, 56 + posH);
                grid.Name = "dataGridViewFleurMag1";
                grid.RowTemplate.Height = 25;
                grid.Size = new Size(473, 260);
                grid.TabIndex = 0;

                panelProduits.Controls.Add(label);
                panelProduits.Controls.Add(grid);
                #endregion
                string nomMagasin = "";
                if (i <= nbMagasin)
                {
                    MySqlCommand getNomMagasin = maConnexion.CreateCommand();
                    getNomMagasin.CommandText = $"select nom from magasin where id_magasin = {i};";

                    MySqlDataReader nomMagasinReader = getNomMagasin.ExecuteReader();
                    while (nomMagasinReader.Read())
                    {
                        nomMagasin = (string)nomMagasinReader[0];
                    }
                    nomMagasinReader.Close();
                    getNomMagasin.Dispose();
                    string commande = $"select id_fleur, prix, quantite_disponible, disponibilite from stock natural join fleur where id_magasin = {i};";
                    ListFleur(commande, grid);
                }
                else if (i == nbMagasin + 1)
                {
                    nomMagasin = "Tous les magasin de Monsieur Belle-fleur";
                    string commande = $"select id_fleur, prix, sum(quantite_disponible), disponibilite from stock natural join fleur group by id_fleur;";
                    ListFleur(commande, grid);
                }
                else
                {
                    nomMagasin = "Accessoir";
                    string commande = $"select * from accessoir;";
                    ListAccessoir(commande, grid);
                }
                label.Text = nomMagasin;

            }
        }
        #endregion

        #region Client
        private void Connexion(string mail)
        {
            clientConnecter = new Client(mail, maConnexion);

            labelConnecter.Text = $"Id : {clientConnecter.getId()}      Nom : {clientConnecter.getNom()}     Prénom : {clientConnecter.getPrenom()}";
            labelConnecter.Location = new Point(0, ClientSize.Height - labelConnecter.Height);
            buttonCommande.Show();
            buttonCommandeStandard.Show();
            DisplayPannel(panelInfoClient);
        }
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            int mailExist = 0;
            bool issue = false;
            MySqlCommand getMail = maConnexion.CreateCommand();
            getMail.CommandText = $"select count(*) from clients where courriel = '{textBoxMail.Text}'";

            MySqlDataReader getmailReader = getMail.ExecuteReader();
            while (getmailReader.Read())
            {
                mailExist = Convert.ToInt32(getmailReader.GetString(0));
            }
            getmailReader.Close();
            getMail.Dispose();

            if (mailExist == 0)
            {
                labelErreurConnexion.Text = "ERREUR, l'adresse mail n'existe pas dans la base de donnée";
                textBoxMail.Text = "";
                labelErreurConnexion.Show();
            }

            else
            {
                MySqlCommand getMdp = maConnexion.CreateCommand();
                getMdp.CommandText = $"select mdp from clients where courriel = '{textBoxMail.Text}';";

                MySqlDataReader getMdpReader = getMdp.ExecuteReader();
                while (getMdpReader.Read())
                {
                    issue = (textBoxMdp.Text == getMdpReader.GetString(0));
                }
                getMdp.Dispose();
                getMdpReader.Close();
                if (issue)
                {
                    Connexion(textBoxMail.Text);
                    textBoxMail.Text = "";
                    textBoxMdp.Text = "";
                }
                else
                {
                    labelErreurConnexion.Text = "ERREUR, le mot de passe n'est pas correct";
                    textBoxMdp.Text = "";
                    labelErreurConnexion.Show();
                }
            }
        }
        private void buttonInscrription_Click(object sender, EventArgs e)
        {
            int mailExist = 0;
            int id = 0;
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string tel = textBoxTel.Text;
            string mail = textBoxMailInsc.Text;
            string mdp = textBoxMdpInsc.Text;
            string adresse = textBoxAdresse.Text;
            string carte = textBoxCarte.Text;

            MySqlCommand cmdCountNbCient = maConnexion.CreateCommand();
            cmdCountNbCient.CommandText = "select count(*) from clients";

            MySqlDataReader nbClientReader = cmdCountNbCient.ExecuteReader();
            while (nbClientReader.Read())
            {
                id = Convert.ToInt32(nbClientReader.GetString(0)) + 1;
            }
            nbClientReader.Close();
            cmdCountNbCient.Dispose();

            MySqlCommand getMail = maConnexion.CreateCommand();
            getMail.CommandText = $"select count(*) from clients where courriel = '{textBoxMailInsc.Text}'";

            MySqlDataReader getmailReader = getMail.ExecuteReader();
            while (getmailReader.Read())
            {
                mailExist = Convert.ToInt32(getmailReader.GetString(0));
            }
            getmailReader.Close();
            getMail.Dispose();
            if (tel.Length != 10)
            {
                textBoxTel.Text = "";
                labelErreur.Text = "ERREUR, Le numéro de téléphone est incorrect";
                labelErreur.Show();
            }
            else if (mailExist > 0)
            {
                textBoxMailInsc.Text = "";
                textBoxMdpInsc.Text = "";
                labelErreur.Text = "ERREUR, l'adresse mail est déjà utiliser";
                labelErreur.Show();
            }
            else if (mdp.Length > 20)
            {
                textBoxMdpInsc.Text = "";
                labelErreur.Text = "Erreur, votre mot de passe est trop long (20 caractères maximum)";
                labelErreur.Show();
            }
            else if (carte.Length != 16)
            {
                textBoxCarte.Text = "";
                labelErreur.Text = "ERREUR, Le numéro de carte est incorrect (Ne pas mettre d'espace entre les numéros)"; ;
                labelErreur.Show();
            }
            else
            {
                MySqlCommand newClient = maConnexion.CreateCommand();
                newClient.CommandText = $"INSERT INTO `magasins`.`clients` VALUES({id}, '{prenom}', '{nom}', '{tel}', '{mail}', '{mdp}', '{adresse}', '{carte}', '');";
                newClient.ExecuteNonQuery();
                newClient.Dispose();
                Connexion(textBoxMailInsc.Text);

                textBoxAdresse.Text = "";
                textBoxCarte.Text = "";
                textBoxMailInsc.Text = "";
                textBoxMdpInsc.Text = "";
                textBoxNom.Text = "";
                textBoxPrenom.Text = "";
                textBoxTel.Text = "";
            }


        }
        private void GetInfoClient()
        {
            dataGridViewHistCommandeClient.Rows.Clear();
            MySqlCommand getCommandes = maConnexion.CreateCommand();
            getCommandes.CommandText = $"SELECT sum(prix_bouquet) AS  id_commande, commande.id_bouquet, bouquet.nom, magasin.nom, date_commande, date_livraison, bouquet.prix_bouquet, code_etat\r\nFROM commande NATURAL JOIN( bouquet, clients, magasin) where id_client = {clientConnecter.getId()}\r\nGROUP BY id_commande;";

            MySqlDataReader comandesReader = getCommandes.ExecuteReader();
            while (comandesReader.Read())
            {
                string[] commande = { comandesReader[0].ToString(), comandesReader[1].ToString(), comandesReader[2].ToString(), comandesReader[3].ToString(), comandesReader[4].ToString(), comandesReader[5].ToString(), comandesReader[6].ToString() + "€", comandesReader[7].ToString() };
                dataGridViewHistCommandeClient.Rows.Add(commande);
            }
            comandesReader.Close();
            getCommandes.Dispose();
            CalculFidelite();

            labelClient.Text = $"Nom : {clientConnecter.getNom()}\n\r" +
                $"Prénom : {clientConnecter.getPrenom()}\n\r" +
                $"Id : {clientConnecter.getId()}\n\r" +
                $"Téléphone : {clientConnecter.getTel()}\n\r" +
                $"Mail : {clientConnecter.getMail()}\n\r" +
                $"Mot de passe : {clientConnecter.getmdp()}\n\r" +
                $"Adresse de facturation : {clientConnecter.getAdresse()}\n\r" +
                $"Carte : {clientConnecter.getCarte()}\n\r" +
                $"Statut fidelité : {clientConnecter.getStatut_fidelite()}\n\r";
        }
        private void CalculFidelite()
        {
            int firstMounth = 100000000;
            int lastMounth = 0;
            int nbCommande = 0;

            for (int i = 0; i < dataGridViewHistCommandeClient.RowCount - 1; i++)
            {
                int mounth = Convert.ToInt32(dataGridViewHistCommandeClient.Rows[i].Cells[4].Value.ToString().Substring(8, 2)) * 12 + Convert.ToInt32(dataGridViewHistCommandeClient.Rows[i].Cells[4].Value.ToString().Substring(3, 2));
                if (mounth < firstMounth) firstMounth = mounth;
                if (mounth > lastMounth) lastMounth = mounth;
                nbCommande++;
            }

            int nbMount = lastMounth - firstMounth + 1;
            double cmdPerMounth = nbCommande / nbMount;

            if (cmdPerMounth > 4.5) clientConnecter.setStatut_fidelite("OR");
            else if (cmdPerMounth > 0.5) clientConnecter.setStatut_fidelite("BRONZE");
            else clientConnecter.setStatut_fidelite("NON");

            MySqlCommand setClientStatut = maConnexion.CreateCommand();
            setClientStatut.CommandText = $"update clients Set statut_fidelite = '{clientConnecter.getStatut_fidelite()}' where id_client = {clientConnecter.getId()};";
            setClientStatut.ExecuteNonQuery();
            setClientStatut.Dispose();

        }
        #endregion

        #region Admin
        private void buttonConnecteAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxMdpAdmin.Text == "1234")
            {
                buttonSuiviCommande.Show();
                buttonStat.Show();
            }
            else
            {
                buttonSuiviCommande.Hide();
                buttonStat.Hide();
            }
        }
        private void SuiviCommande()
        {
            dataGridViewSuiviCommande.Rows.Clear();
            MySqlCommand getCommandes = maConnexion.CreateCommand();
            getCommandes.CommandText = $"SELECT sum(prix_bouquet) AS prixBouquet, id_commande, commande.id_client, magasin.nom, date_commande, date_livraison, commande.id_bouquet, bouquet.prix_bouquet, code_etat\r\nFROM commande NATURAL JOIN( bouquet, clients, magasin)\r\nGROUP BY id_commande;";

            MySqlDataReader comandesReader = getCommandes.ExecuteReader();
            while (comandesReader.Read())
            {

                string[] commande = { comandesReader[1].ToString(), comandesReader[2].ToString(), comandesReader[3].ToString(), comandesReader[4].ToString(), comandesReader[5].ToString(), comandesReader[6].ToString(), comandesReader[7].ToString() + "€", comandesReader[8].ToString() };
                dataGridViewSuiviCommande.Rows.Add(commande);
            }
            comandesReader.Close();
            getCommandes.Dispose();
        }
        private void GetStatistiques()
        {
            MySqlCommand commande = maConnexion.CreateCommand();
            commande.CommandText = "SELECT AVG(prix_bouquet) from bouquet;";

            MySqlDataReader reader = commande.ExecuteReader();
            string prixMoyenBouquet = "";
            while (reader.Read())
            {
                prixMoyenBouquet = reader[0].ToString();
            }
            commande.Dispose();
            reader.Close();

            commande = maConnexion.CreateCommand();
            commande.CommandText = "SELECT clients.nom, SUM(bouquet.prix_bouquet) as total_dépensé\r\nFROM clients\r\nJOIN commande ON clients.id_client = commande.id_client\r\nJOIN bouquet  ON commande.id_bouquet = bouquet.id_bouquet\r\nWHERE MONTH(commande.date_commande) = MONTH(CURRENT_DATE()) AND YEAR(commande.date_commande) = YEAR(CURRENT_DATE())\r\nGROUP BY nom\r\nORDER BY total_dépensé DESC\r\n LIMIT 10;";
            reader = commande.ExecuteReader();
            string meilleurClients = "";
            int count = 0;
            while (reader.Read() && count < 3)
            {
                count++;
                meilleurClients += $"{count}. {reader[0].ToString()}      ";
            }
            commande.Dispose();
            reader.Close();

            commande = maConnexion.CreateCommand();
            commande.CommandText = "SELECT clients.nom, SUM(bouquet.prix_bouquet) as total_dépensé\r\nFROM clients\r\nJOIN commande ON clients.id_client = commande.id_client\r\nJOIN bouquet  ON commande.id_bouquet = bouquet.id_bouquet\r\nWHERE YEAR(commande.date_commande) = YEAR(CURRENT_DATE())\r\nGROUP BY nom\r\nORDER BY total_dépensé DESC;";
            reader = commande.ExecuteReader();
            string meilleurClientsAnnee = "";
            count = 0;
            while (reader.Read() && count < 3)
            {
                count++;
                meilleurClientsAnnee += $"{count}. {reader[0].ToString()}      ";
            }
            commande.Dispose();
            reader.Close();

            commande = maConnexion.CreateCommand();
            commande.CommandText = "SELECT bouquet.nom AS nom_bouquet, count(id_commande) AS nombre_commandes\r\nFROM commande\r\nJOIN bouquet  ON commande.id_bouquet = bouquet.id_bouquet\r\nWHERE categorie IN ('Standard')\r\nGROUP BY bouquet.nom\r\nORDER BY COUNT(id_commande) DESC\r\nLIMIT 10;";
            reader = commande.ExecuteReader();
            string bouquetStandarSucces = "";
            count = 0;
            while (reader.Read() && count < 3)
            {
                count++;
                bouquetStandarSucces += $"{count}. {reader[0].ToString()}      ";
            }
            commande.Dispose();
            reader.Close();

            commande = maConnexion.CreateCommand();
            commande.CommandText = "SELECT magasin.nom AS nom_magasin, SUM(bouquet.prix_bouquet ) AS chiffre_affaires\r\nFROM magasin\r\nJOIN commande c ON magasin.id_magasin = c.id_bouquet\r\nJOIN bouquet ON c.id_bouquet = bouquet.id_bouquet\r\nGROUP BY magasin.nom\r\nORDER BY chiffre_affaires DESC\r\nLIMIT 5;";
            reader = commande.ExecuteReader();
            string magChiffreAffaire = "";
            count = 0;
            while (reader.Read() && count < 3)
            {
                count++;
                magChiffreAffaire += $"{count}. {reader[0].ToString()}      ";
            }
            commande.Dispose();
            reader.Close();

            commande = maConnexion.CreateCommand();
            commande.CommandText = "SELECT id_fleur AS nom_fleur, MAX(quantite_disponible) AS total_restant_disponible\r\n FROM stock NATURAL JOIN(fleur)\r\n GROUP BY id_fleur\r\n  ORDER BY total_restant_disponible DESC\r\n  LIMIT 20;";
            reader = commande.ExecuteReader();
            string fleurExoMoinsV = "";
            count = 0;
            while (reader.Read() && count < 3)
            {
                count++;
                fleurExoMoinsV += $"{count}. {reader[0].ToString()}      ";
            }
            commande.Dispose();
            reader.Close();


            labelStatistique.Text = $"Prix moyen du bouquet : {prixMoyenBouquet}€" +
                $"\n\rMeilleur clients du mois : {meilleurClients}" +
                $"\n\rMeilleur clients de l'année : {meilleurClientsAnnee}" +
                $"\n\rBouquet standard qui a eu le plus de succes : {bouquetStandarSucces}" +
                $"\n\rMagasin qui à générer le plus gros chiffre d'affaire : {magChiffreAffaire}" +
                $"\n\rFleur exotique la moins vendu : {fleurExoMoinsV}";
        }
        #endregion


    }
}