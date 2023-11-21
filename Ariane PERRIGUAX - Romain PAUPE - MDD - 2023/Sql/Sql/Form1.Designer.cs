namespace Sql
{
    partial class FormMagasin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagasin));
            panelClient = new Panel();
            labelErreurConnexion = new Label();
            buttonNewCount = new Button();
            textBoxMdp = new TextBox();
            labelMdp = new Label();
            buttonConnexion = new Button();
            textBoxMail = new TextBox();
            labelMail = new Label();
            panel1 = new Panel();
            buttonAdmin = new Button();
            buttonSuiviCommande = new Button();
            buttonCommandeStandard = new Button();
            buttonCommande = new Button();
            buttonStat = new Button();
            buttonProduits = new Button();
            buttonClient = new Button();
            labelConnecter = new Label();
            panelProduits = new Panel();
            panelIncription = new Panel();
            labelErreur = new Label();
            textBoxCarte = new TextBox();
            textBoxAdresse = new TextBox();
            textBoxMdpInsc = new TextBox();
            textBoxMailInsc = new TextBox();
            textBoxTel = new TextBox();
            textBoxPrenom = new TextBox();
            textBoxNom = new TextBox();
            buttonInscrription = new Button();
            labelCarte = new Label();
            labelAdresse = new Label();
            labelMdpInsc = new Label();
            labelMailInsc = new Label();
            labelTel = new Label();
            labelPrenom = new Label();
            labelNom = new Label();
            panelCommandePersonalise = new Panel();
            labelErreurCommande = new Label();
            buttonValiderCommande = new Button();
            dataGridViewAccessoir = new DataGridView();
            A = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dateTimePickerCommande = new DateTimePicker();
            label3 = new Label();
            listBoxMagasins = new ListBox();
            label2 = new Label();
            label1 = new Label();
            buttonActualiserPrixTotal = new Button();
            labelPrixTotal = new Label();
            dataGridViewCommandePersonalise = new DataGridView();
            ColumnCommandeNomFleur = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColumnCommandeQuantitéDisponible = new DataGridViewTextBoxColumn();
            ColumnCommandeQuantite = new DataGridViewTextBoxColumn();
            panelSuiviCommande = new Panel();
            label6 = new Label();
            dataGridViewSuiviCommande = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            panelCommandStandard = new Panel();
            listBoxMagasin2 = new ListBox();
            label10 = new Label();
            labelErreurCommandeS = new Label();
            buttonValideCommandStandard = new Button();
            dateTimePickerCommandeS = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            dataGridViewCommandeStandard = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            labelClient = new Label();
            panelInfoClient = new Panel();
            buttonDeconnecter = new Button();
            dataGridViewHistCommandeClient = new DataGridView();
            Column14 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            panelAdmin = new Panel();
            labelErreurAdmin = new Label();
            buttonConnecteAdmin = new Button();
            textBoxMdpAdmin = new TextBox();
            label9 = new Label();
            panelCommandeSucces = new Panel();
            label11 = new Label();
            buttonOK = new Button();
            labelStatistique = new Label();
            panelStatistique = new Panel();
            panelClient.SuspendLayout();
            panel1.SuspendLayout();
            panelIncription.SuspendLayout();
            panelCommandePersonalise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccessoir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandePersonalise).BeginInit();
            panelSuiviCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuiviCommande).BeginInit();
            panelCommandStandard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandeStandard).BeginInit();
            panelInfoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistCommandeClient).BeginInit();
            panelAdmin.SuspendLayout();
            panelCommandeSucces.SuspendLayout();
            panelStatistique.SuspendLayout();
            SuspendLayout();
            // 
            // panelClient
            // 
            panelClient.Anchor = AnchorStyles.None;
            panelClient.Controls.Add(labelErreurConnexion);
            panelClient.Controls.Add(buttonNewCount);
            panelClient.Controls.Add(textBoxMdp);
            panelClient.Controls.Add(labelMdp);
            panelClient.Controls.Add(buttonConnexion);
            panelClient.Controls.Add(textBoxMail);
            panelClient.Controls.Add(labelMail);
            panelClient.Location = new Point(48, 456);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(313, 219);
            panelClient.TabIndex = 1;
            // 
            // labelErreurConnexion
            // 
            labelErreurConnexion.AutoEllipsis = true;
            labelErreurConnexion.ForeColor = Color.Red;
            labelErreurConnexion.Location = new Point(3, 147);
            labelErreurConnexion.Name = "labelErreurConnexion";
            labelErreurConnexion.Size = new Size(307, 53);
            labelErreurConnexion.TabIndex = 6;
            labelErreurConnexion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonNewCount
            // 
            buttonNewCount.Location = new Point(92, 116);
            buttonNewCount.Name = "buttonNewCount";
            buttonNewCount.Size = new Size(128, 24);
            buttonNewCount.TabIndex = 5;
            buttonNewCount.Text = "Crée un compte";
            buttonNewCount.UseVisualStyleBackColor = true;
            buttonNewCount.Click += buttonNewCount_Click;
            // 
            // textBoxMdp
            // 
            textBoxMdp.Location = new Point(130, 48);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.Size = new Size(128, 23);
            textBoxMdp.TabIndex = 4;
            // 
            // labelMdp
            // 
            labelMdp.AutoSize = true;
            labelMdp.Location = new Point(34, 48);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(83, 15);
            labelMdp.TabIndex = 3;
            labelMdp.Text = "Mot de passe :";
            // 
            // buttonConnexion
            // 
            buttonConnexion.Location = new Point(92, 84);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(128, 24);
            buttonConnexion.TabIndex = 2;
            buttonConnexion.Text = "Connexion";
            buttonConnexion.UseVisualStyleBackColor = true;
            buttonConnexion.Click += buttonConnexion_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(130, 16);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(128, 23);
            textBoxMail.TabIndex = 1;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(34, 16);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(83, 15);
            labelMail.TabIndex = 0;
            labelMail.Text = "Adresse mail : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAdmin);
            panel1.Controls.Add(buttonSuiviCommande);
            panel1.Controls.Add(buttonCommandeStandard);
            panel1.Controls.Add(buttonCommande);
            panel1.Controls.Add(buttonStat);
            panel1.Controls.Add(buttonProduits);
            panel1.Controls.Add(buttonClient);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 34);
            panel1.TabIndex = 2;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(834, 6);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(97, 22);
            buttonAdmin.TabIndex = 7;
            buttonAdmin.Text = "Administrateur";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonSuiviCommande
            // 
            buttonSuiviCommande.Location = new Point(585, 5);
            buttonSuiviCommande.Name = "buttonSuiviCommande";
            buttonSuiviCommande.Size = new Size(114, 24);
            buttonSuiviCommande.TabIndex = 6;
            buttonSuiviCommande.Text = "Suivi Commande";
            buttonSuiviCommande.UseVisualStyleBackColor = true;
            buttonSuiviCommande.Click += buttonSuiviCommande_Click;
            // 
            // buttonCommandeStandard
            // 
            buttonCommandeStandard.AutoSize = true;
            buttonCommandeStandard.Location = new Point(419, 5);
            buttonCommandeStandard.Name = "buttonCommandeStandard";
            buttonCommandeStandard.Size = new Size(136, 25);
            buttonCommandeStandard.TabIndex = 5;
            buttonCommandeStandard.Text = "Commande Standard";
            buttonCommandeStandard.UseVisualStyleBackColor = true;
            buttonCommandeStandard.Click += buttonCommandeStandar_Click;
            // 
            // buttonCommande
            // 
            buttonCommande.Location = new Point(224, 6);
            buttonCommande.Name = "buttonCommande";
            buttonCommande.Size = new Size(165, 23);
            buttonCommande.TabIndex = 3;
            buttonCommande.Text = "Commande Personalisé";
            buttonCommande.UseVisualStyleBackColor = true;
            buttonCommande.Click += buttonCommande_Click;
            // 
            // buttonStat
            // 
            buttonStat.Location = new Point(729, 6);
            buttonStat.Name = "buttonStat";
            buttonStat.Size = new Size(75, 23);
            buttonStat.TabIndex = 2;
            buttonStat.Text = "Statistiques";
            buttonStat.UseVisualStyleBackColor = true;
            buttonStat.Click += buttonStat_Click;
            // 
            // buttonProduits
            // 
            buttonProduits.Location = new Point(119, 6);
            buttonProduits.Name = "buttonProduits";
            buttonProduits.Size = new Size(75, 23);
            buttonProduits.TabIndex = 1;
            buttonProduits.Text = "Produits";
            buttonProduits.UseVisualStyleBackColor = true;
            buttonProduits.Click += buttonProduits_Click;
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(14, 6);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(75, 23);
            buttonClient.TabIndex = 0;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click_1;
            // 
            // labelConnecter
            // 
            labelConnecter.AutoSize = true;
            labelConnecter.Location = new Point(0, 545);
            labelConnecter.Name = "labelConnecter";
            labelConnecter.Size = new Size(0, 15);
            labelConnecter.TabIndex = 4;
            // 
            // panelProduits
            // 
            panelProduits.AutoScroll = true;
            panelProduits.Location = new Point(130, 452);
            panelProduits.Name = "panelProduits";
            panelProduits.Size = new Size(605, 438);
            panelProduits.TabIndex = 3;
            // 
            // panelIncription
            // 
            panelIncription.AutoSize = true;
            panelIncription.Controls.Add(labelErreur);
            panelIncription.Controls.Add(textBoxCarte);
            panelIncription.Controls.Add(textBoxAdresse);
            panelIncription.Controls.Add(textBoxMdpInsc);
            panelIncription.Controls.Add(textBoxMailInsc);
            panelIncription.Controls.Add(textBoxTel);
            panelIncription.Controls.Add(textBoxPrenom);
            panelIncription.Controls.Add(textBoxNom);
            panelIncription.Controls.Add(buttonInscrription);
            panelIncription.Controls.Add(labelCarte);
            panelIncription.Controls.Add(labelAdresse);
            panelIncription.Controls.Add(labelMdpInsc);
            panelIncription.Controls.Add(labelMailInsc);
            panelIncription.Controls.Add(labelTel);
            panelIncription.Controls.Add(labelPrenom);
            panelIncription.Controls.Add(labelNom);
            panelIncription.Location = new Point(856, 40);
            panelIncription.Name = "panelIncription";
            panelIncription.Size = new Size(479, 395);
            panelIncription.TabIndex = 4;
            // 
            // labelErreur
            // 
            labelErreur.AutoEllipsis = true;
            labelErreur.ForeColor = Color.Red;
            labelErreur.Location = new Point(9, 334);
            labelErreur.Name = "labelErreur";
            labelErreur.Size = new Size(467, 52);
            labelErreur.TabIndex = 15;
            labelErreur.Text = "ERREUR, le mail est déja utiliser, veuillez saisir un nouveau";
            labelErreur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCarte
            // 
            textBoxCarte.Location = new Point(189, 239);
            textBoxCarte.Name = "textBoxCarte";
            textBoxCarte.Size = new Size(214, 23);
            textBoxCarte.TabIndex = 14;
            // 
            // textBoxAdresse
            // 
            textBoxAdresse.Location = new Point(189, 201);
            textBoxAdresse.Name = "textBoxAdresse";
            textBoxAdresse.Size = new Size(214, 23);
            textBoxAdresse.TabIndex = 13;
            // 
            // textBoxMdpInsc
            // 
            textBoxMdpInsc.Location = new Point(189, 166);
            textBoxMdpInsc.Name = "textBoxMdpInsc";
            textBoxMdpInsc.Size = new Size(214, 23);
            textBoxMdpInsc.TabIndex = 12;
            // 
            // textBoxMailInsc
            // 
            textBoxMailInsc.Location = new Point(189, 131);
            textBoxMailInsc.Name = "textBoxMailInsc";
            textBoxMailInsc.Size = new Size(214, 23);
            textBoxMailInsc.TabIndex = 11;
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(189, 96);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(214, 23);
            textBoxTel.TabIndex = 10;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(189, 61);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(214, 23);
            textBoxPrenom.TabIndex = 9;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(189, 26);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(214, 23);
            textBoxNom.TabIndex = 8;
            // 
            // buttonInscrription
            // 
            buttonInscrription.Location = new Point(157, 298);
            buttonInscrription.Name = "buttonInscrription";
            buttonInscrription.Size = new Size(170, 33);
            buttonInscrription.TabIndex = 7;
            buttonInscrription.Text = "Insciption";
            buttonInscrription.UseVisualStyleBackColor = true;
            buttonInscrription.Click += buttonInscrription_Click;
            // 
            // labelCarte
            // 
            labelCarte.AutoSize = true;
            labelCarte.Location = new Point(46, 242);
            labelCarte.Name = "labelCarte";
            labelCarte.Size = new Size(90, 15);
            labelCarte.TabIndex = 6;
            labelCarte.Text = "Carte de crédit :";
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(46, 206);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(54, 15);
            labelAdresse.TabIndex = 5;
            labelAdresse.Text = "Adresse :";
            // 
            // labelMdpInsc
            // 
            labelMdpInsc.AutoSize = true;
            labelMdpInsc.Location = new Point(46, 170);
            labelMdpInsc.Name = "labelMdpInsc";
            labelMdpInsc.Size = new Size(83, 15);
            labelMdpInsc.TabIndex = 4;
            labelMdpInsc.Text = "Mot de passe :";
            // 
            // labelMailInsc
            // 
            labelMailInsc.AutoSize = true;
            labelMailInsc.Location = new Point(46, 134);
            labelMailInsc.Name = "labelMailInsc";
            labelMailInsc.Size = new Size(80, 15);
            labelMailInsc.TabIndex = 3;
            labelMailInsc.Text = "Adresse mail :";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(46, 98);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(129, 15);
            labelTel.TabIndex = 2;
            labelTel.Text = "Numéro de téléphone :";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(46, 62);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(55, 15);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(46, 26);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(40, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            // 
            // panelCommandePersonalise
            // 
            panelCommandePersonalise.Controls.Add(labelErreurCommande);
            panelCommandePersonalise.Controls.Add(buttonValiderCommande);
            panelCommandePersonalise.Controls.Add(dataGridViewAccessoir);
            panelCommandePersonalise.Controls.Add(dateTimePickerCommande);
            panelCommandePersonalise.Controls.Add(label3);
            panelCommandePersonalise.Controls.Add(listBoxMagasins);
            panelCommandePersonalise.Controls.Add(label2);
            panelCommandePersonalise.Controls.Add(label1);
            panelCommandePersonalise.Controls.Add(buttonActualiserPrixTotal);
            panelCommandePersonalise.Controls.Add(labelPrixTotal);
            panelCommandePersonalise.Controls.Add(dataGridViewCommandePersonalise);
            panelCommandePersonalise.Location = new Point(500, 119);
            panelCommandePersonalise.Name = "panelCommandePersonalise";
            panelCommandePersonalise.Size = new Size(820, 463);
            panelCommandePersonalise.TabIndex = 5;
            // 
            // labelErreurCommande
            // 
            labelErreurCommande.ForeColor = Color.Red;
            labelErreurCommande.Location = new Point(11, 420);
            labelErreurCommande.Name = "labelErreurCommande";
            labelErreurCommande.Size = new Size(688, 33);
            labelErreurCommande.TabIndex = 10;
            labelErreurCommande.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonValiderCommande
            // 
            buttonValiderCommande.Location = new Point(278, 394);
            buttonValiderCommande.Name = "buttonValiderCommande";
            buttonValiderCommande.Size = new Size(152, 23);
            buttonValiderCommande.TabIndex = 9;
            buttonValiderCommande.Text = "Valider la commande";
            buttonValiderCommande.UseVisualStyleBackColor = true;
            buttonValiderCommande.Click += buttonValiderCommande_Click;
            // 
            // dataGridViewAccessoir
            // 
            dataGridViewAccessoir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccessoir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccessoir.Columns.AddRange(new DataGridViewColumn[] { A, Column1, Column2 });
            dataGridViewAccessoir.Location = new Point(278, 232);
            dataGridViewAccessoir.Name = "dataGridViewAccessoir";
            dataGridViewAccessoir.RowHeadersWidth = 62;
            dataGridViewAccessoir.RowTemplate.Height = 25;
            dataGridViewAccessoir.Size = new Size(434, 137);
            dataGridViewAccessoir.TabIndex = 8;
            // 
            // A
            // 
            A.HeaderText = "Accessoir";
            A.MinimumWidth = 8;
            A.Name = "A";
            A.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Prix";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantité voulu";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // dateTimePickerCommande
            // 
            dateTimePickerCommande.Location = new Point(11, 168);
            dateTimePickerCommande.Name = "dateTimePickerCommande";
            dateTimePickerCommande.Size = new Size(200, 23);
            dateTimePickerCommande.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 146);
            label3.Name = "label3";
            label3.Size = new Size(169, 15);
            label3.TabIndex = 6;
            label3.Text = "Choisir votre date de livraison :";
            // 
            // listBoxMagasins
            // 
            listBoxMagasins.FormattingEnabled = true;
            listBoxMagasins.ItemHeight = 15;
            listBoxMagasins.Location = new Point(9, 39);
            listBoxMagasins.Name = "listBoxMagasins";
            listBoxMagasins.Size = new Size(120, 94);
            listBoxMagasins.TabIndex = 5;
            listBoxMagasins.SelectedIndexChanged += listBoxMagasins_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 4;
            label2.Text = "Magasin où passer la commande : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 8);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 3;
            label1.Text = "Veuillez choisir les fleurs et acccessoirs de votre choix : ";
            // 
            // buttonActualiserPrixTotal
            // 
            buttonActualiserPrixTotal.Location = new Point(11, 221);
            buttonActualiserPrixTotal.Name = "buttonActualiserPrixTotal";
            buttonActualiserPrixTotal.Size = new Size(84, 23);
            buttonActualiserPrixTotal.TabIndex = 2;
            buttonActualiserPrixTotal.Text = "Actualiser";
            buttonActualiserPrixTotal.UseVisualStyleBackColor = true;
            buttonActualiserPrixTotal.Click += buttonActualiserPrixTotal_Click;
            // 
            // labelPrixTotal
            // 
            labelPrixTotal.AutoSize = true;
            labelPrixTotal.Location = new Point(11, 247);
            labelPrixTotal.Name = "labelPrixTotal";
            labelPrixTotal.Size = new Size(138, 30);
            labelPrixTotal.TabIndex = 1;
            labelPrixTotal.Text = "Détail de la commande : \r\nPrix total : 0€\r\n";
            // 
            // dataGridViewCommandePersonalise
            // 
            dataGridViewCommandePersonalise.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCommandePersonalise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCommandePersonalise.Columns.AddRange(new DataGridViewColumn[] { ColumnCommandeNomFleur, dataGridViewTextBoxColumn1, ColumnCommandeQuantitéDisponible, ColumnCommandeQuantite });
            dataGridViewCommandePersonalise.Location = new Point(278, 36);
            dataGridViewCommandePersonalise.Name = "dataGridViewCommandePersonalise";
            dataGridViewCommandePersonalise.RowHeadersWidth = 62;
            dataGridViewCommandePersonalise.RowTemplate.Height = 25;
            dataGridViewCommandePersonalise.Size = new Size(438, 190);
            dataGridViewCommandePersonalise.TabIndex = 0;
            // 
            // ColumnCommandeNomFleur
            // 
            ColumnCommandeNomFleur.HeaderText = "Fleur";
            ColumnCommandeNomFleur.MinimumWidth = 8;
            ColumnCommandeNomFleur.Name = "ColumnCommandeNomFleur";
            ColumnCommandeNomFleur.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Prix";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ColumnCommandeQuantitéDisponible
            // 
            ColumnCommandeQuantitéDisponible.HeaderText = "Quantités disponible";
            ColumnCommandeQuantitéDisponible.MinimumWidth = 8;
            ColumnCommandeQuantitéDisponible.Name = "ColumnCommandeQuantitéDisponible";
            ColumnCommandeQuantitéDisponible.ReadOnly = true;
            // 
            // ColumnCommandeQuantite
            // 
            ColumnCommandeQuantite.HeaderText = "Quantités voulu";
            ColumnCommandeQuantite.MinimumWidth = 8;
            ColumnCommandeQuantite.Name = "ColumnCommandeQuantite";
            // 
            // panelSuiviCommande
            // 
            panelSuiviCommande.Controls.Add(label6);
            panelSuiviCommande.Controls.Add(dataGridViewSuiviCommande);
            panelSuiviCommande.Location = new Point(283, 66);
            panelSuiviCommande.Name = "panelSuiviCommande";
            panelSuiviCommande.Size = new Size(947, 476);
            panelSuiviCommande.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 10);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 1;
            label6.Text = "Suivi des Commades :";
            // 
            // dataGridViewSuiviCommande
            // 
            dataGridViewSuiviCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuiviCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuiviCommande.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridViewSuiviCommande.Location = new Point(40, 38);
            dataGridViewSuiviCommande.Name = "dataGridViewSuiviCommande";
            dataGridViewSuiviCommande.RowHeadersWidth = 62;
            dataGridViewSuiviCommande.RowTemplate.Height = 25;
            dataGridViewSuiviCommande.Size = new Size(846, 435);
            dataGridViewSuiviCommande.TabIndex = 0;
            // 
            // Column6
            // 
            Column6.HeaderText = "Id Commande";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Id Client";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Magasin";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Date de commande";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Date de livraison";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Id bouquet";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Prix";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Etat";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            // 
            // panelCommandStandard
            // 
            panelCommandStandard.Controls.Add(listBoxMagasin2);
            panelCommandStandard.Controls.Add(label10);
            panelCommandStandard.Controls.Add(labelErreurCommandeS);
            panelCommandStandard.Controls.Add(buttonValideCommandStandard);
            panelCommandStandard.Controls.Add(dateTimePickerCommandeS);
            panelCommandStandard.Controls.Add(label5);
            panelCommandStandard.Controls.Add(label4);
            panelCommandStandard.Controls.Add(dataGridViewCommandeStandard);
            panelCommandStandard.Location = new Point(685, 532);
            panelCommandStandard.Name = "panelCommandStandard";
            panelCommandStandard.Size = new Size(523, 497);
            panelCommandStandard.TabIndex = 6;
            // 
            // listBoxMagasin2
            // 
            listBoxMagasin2.FormattingEnabled = true;
            listBoxMagasin2.ItemHeight = 15;
            listBoxMagasin2.Location = new Point(289, 40);
            listBoxMagasin2.Name = "listBoxMagasin2";
            listBoxMagasin2.Size = new Size(120, 94);
            listBoxMagasin2.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(289, 13);
            label10.Name = "label10";
            label10.Size = new Size(190, 15);
            label10.TabIndex = 6;
            label10.Text = "Magasin où passer la commande : ";
            // 
            // labelErreurCommandeS
            // 
            labelErreurCommandeS.ForeColor = Color.Red;
            labelErreurCommandeS.Location = new Point(21, 424);
            labelErreurCommandeS.Name = "labelErreurCommandeS";
            labelErreurCommandeS.Size = new Size(485, 49);
            labelErreurCommandeS.TabIndex = 5;
            labelErreurCommandeS.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonValideCommandStandard
            // 
            buttonValideCommandStandard.AutoSize = true;
            buttonValideCommandStandard.Location = new Point(189, 387);
            buttonValideCommandStandard.Name = "buttonValideCommandStandard";
            buttonValideCommandStandard.Size = new Size(220, 35);
            buttonValideCommandStandard.TabIndex = 4;
            buttonValideCommandStandard.Text = "Vallider votre commande";
            buttonValideCommandStandard.UseVisualStyleBackColor = true;
            buttonValideCommandStandard.Click += buttonValideCommandStandard_Click;
            // 
            // dateTimePickerCommandeS
            // 
            dateTimePickerCommandeS.Location = new Point(49, 36);
            dateTimePickerCommandeS.Name = "dateTimePickerCommandeS";
            dateTimePickerCommandeS.Size = new Size(200, 23);
            dateTimePickerCommandeS.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 124);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 2;
            label5.Text = "Selectionner un bouquet :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 13);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 1;
            label4.Text = "Choisir date de livraison :";
            // 
            // dataGridViewCommandeStandard
            // 
            dataGridViewCommandeStandard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCommandeStandard.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCommandeStandard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCommandeStandard.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5 });
            dataGridViewCommandeStandard.Location = new Point(49, 145);
            dataGridViewCommandeStandard.Name = "dataGridViewCommandeStandard";
            dataGridViewCommandeStandard.RowHeadersWidth = 62;
            dataGridViewCommandeStandard.RowTemplate.Height = 25;
            dataGridViewCommandeStandard.Size = new Size(428, 213);
            dataGridViewCommandeStandard.TabIndex = 0;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nom du bouquet";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Prix";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Composition";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(16, 35);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(391, 135);
            labelClient.TabIndex = 7;
            labelClient.Text = resources.GetString("labelClient.Text");
            // 
            // panelInfoClient
            // 
            panelInfoClient.Controls.Add(buttonDeconnecter);
            panelInfoClient.Controls.Add(dataGridViewHistCommandeClient);
            panelInfoClient.Controls.Add(label8);
            panelInfoClient.Controls.Add(label7);
            panelInfoClient.Controls.Add(labelClient);
            panelInfoClient.Location = new Point(561, 70);
            panelInfoClient.Name = "panelInfoClient";
            panelInfoClient.Size = new Size(827, 478);
            panelInfoClient.TabIndex = 8;
            // 
            // buttonDeconnecter
            // 
            buttonDeconnecter.Location = new Point(725, 449);
            buttonDeconnecter.Name = "buttonDeconnecter";
            buttonDeconnecter.Size = new Size(99, 23);
            buttonDeconnecter.TabIndex = 11;
            buttonDeconnecter.Text = "Se deconnecter";
            buttonDeconnecter.UseVisualStyleBackColor = true;
            buttonDeconnecter.Click += buttonDeconnecter_Click;
            // 
            // dataGridViewHistCommandeClient
            // 
            dataGridViewHistCommandeClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistCommandeClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistCommandeClient.Columns.AddRange(new DataGridViewColumn[] { Column14, Column19, Column15, Column16, Column17, Column18, Column20, Column21 });
            dataGridViewHistCommandeClient.Location = new Point(11, 223);
            dataGridViewHistCommandeClient.Name = "dataGridViewHistCommandeClient";
            dataGridViewHistCommandeClient.RowHeadersWidth = 62;
            dataGridViewHistCommandeClient.RowTemplate.Height = 25;
            dataGridViewHistCommandeClient.Size = new Size(691, 216);
            dataGridViewHistCommandeClient.TabIndex = 10;
            // 
            // Column14
            // 
            Column14.HeaderText = "Id Commande";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            // 
            // Column19
            // 
            Column19.HeaderText = "Id Bouquet";
            Column19.MinimumWidth = 8;
            Column19.Name = "Column19";
            // 
            // Column15
            // 
            Column15.HeaderText = "Nom Bouquet";
            Column15.MinimumWidth = 8;
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.HeaderText = "Magasin";
            Column16.MinimumWidth = 8;
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.HeaderText = "Date commande";
            Column17.MinimumWidth = 8;
            Column17.Name = "Column17";
            // 
            // Column18
            // 
            Column18.HeaderText = "Date livraison";
            Column18.MinimumWidth = 8;
            Column18.Name = "Column18";
            // 
            // Column20
            // 
            Column20.HeaderText = "Prix";
            Column20.MinimumWidth = 8;
            Column20.Name = "Column20";
            // 
            // Column21
            // 
            Column21.HeaderText = "Statut commande";
            Column21.MinimumWidth = 8;
            Column21.Name = "Column21";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 197);
            label8.Name = "label8";
            label8.Size = new Size(163, 15);
            label8.TabIndex = 9;
            label8.Text = "Historique des commandes :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 8);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 8;
            label7.Text = "Info Client : ";
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(labelErreurAdmin);
            panelAdmin.Controls.Add(buttonConnecteAdmin);
            panelAdmin.Controls.Add(textBoxMdpAdmin);
            panelAdmin.Controls.Add(label9);
            panelAdmin.Location = new Point(280, 518);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(275, 205);
            panelAdmin.TabIndex = 10;
            // 
            // labelErreurAdmin
            // 
            labelErreurAdmin.ForeColor = Color.Red;
            labelErreurAdmin.Location = new Point(19, 134);
            labelErreurAdmin.Name = "labelErreurAdmin";
            labelErreurAdmin.Size = new Size(235, 23);
            labelErreurAdmin.TabIndex = 3;
            labelErreurAdmin.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonConnecteAdmin
            // 
            buttonConnecteAdmin.Location = new Point(99, 92);
            buttonConnecteAdmin.Name = "buttonConnecteAdmin";
            buttonConnecteAdmin.Size = new Size(75, 23);
            buttonConnecteAdmin.TabIndex = 2;
            buttonConnecteAdmin.Text = "Valider";
            buttonConnecteAdmin.UseVisualStyleBackColor = true;
            buttonConnecteAdmin.Click += buttonConnecteAdmin_Click;
            // 
            // textBoxMdpAdmin
            // 
            textBoxMdpAdmin.Location = new Point(86, 59);
            textBoxMdpAdmin.Name = "textBoxMdpAdmin";
            textBoxMdpAdmin.Size = new Size(100, 23);
            textBoxMdpAdmin.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 37);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 0;
            label9.Text = "Mot de passe :";
            // 
            // panelCommandeSucces
            // 
            panelCommandeSucces.Controls.Add(label11);
            panelCommandeSucces.Controls.Add(buttonOK);
            panelCommandeSucces.Location = new Point(20, 542);
            panelCommandeSucces.Name = "panelCommandeSucces";
            panelCommandeSucces.Size = new Size(222, 99);
            panelCommandeSucces.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(28, 22);
            label11.Name = "label11";
            label11.Size = new Size(171, 15);
            label11.TabIndex = 1;
            label11.Text = "Commande passer avec succès";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(76, 47);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelStatistique
            // 
            labelStatistique.Dock = DockStyle.Fill;
            labelStatistique.Location = new Point(0, 0);
            labelStatistique.Name = "labelStatistique";
            labelStatistique.Size = new Size(689, 348);
            labelStatistique.TabIndex = 12;
            labelStatistique.Text = "label12";
            // 
            // panelStatistique
            // 
            panelStatistique.Controls.Add(labelStatistique);
            panelStatistique.Location = new Point(20, 86);
            panelStatistique.Name = "panelStatistique";
            panelStatistique.Size = new Size(689, 348);
            panelStatistique.TabIndex = 13;
            // 
            // FormMagasin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 610);
            Controls.Add(panelStatistique);
            Controls.Add(panelSuiviCommande);
            Controls.Add(panelCommandeSucces);
            Controls.Add(panelAdmin);
            Controls.Add(panelInfoClient);
            Controls.Add(panelCommandStandard);
            Controls.Add(labelConnecter);
            Controls.Add(panelClient);
            Controls.Add(panelIncription);
            Controls.Add(panelProduits);
            Controls.Add(panelCommandePersonalise);
            Controls.Add(panel1);
            Name = "FormMagasin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Magasin de Monsieur Bellefleur";
            panelClient.ResumeLayout(false);
            panelClient.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelIncription.ResumeLayout(false);
            panelIncription.PerformLayout();
            panelCommandePersonalise.ResumeLayout(false);
            panelCommandePersonalise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccessoir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandePersonalise).EndInit();
            panelSuiviCommande.ResumeLayout(false);
            panelSuiviCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuiviCommande).EndInit();
            panelCommandStandard.ResumeLayout(false);
            panelCommandStandard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandeStandard).EndInit();
            panelInfoClient.ResumeLayout(false);
            panelInfoClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistCommandeClient).EndInit();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelCommandeSucces.ResumeLayout(false);
            panelCommandeSucces.PerformLayout();
            panelStatistique.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelClient;
        private Button buttonNewCount;
        private TextBox textBoxMdp;
        private Label labelMdp;
        private Button buttonConnexion;
        private TextBox textBoxMail;
        private Label labelMail;
        private Panel panel1;
        private Button buttonClient;
        private Button buttonCommande;
        private Button buttonStat;
        private Button buttonProduits;
        private Panel panelProduits;
        private Panel panelIncription;
        private TextBox textBoxCarte;
        private TextBox textBoxAdresse;
        private TextBox textBoxMdpInsc;
        private TextBox textBoxMailInsc;
        private TextBox textBoxTel;
        private TextBox textBoxPrenom;
        private TextBox textBoxNom;
        private Button buttonInscrription;
        private Label labelCarte;
        private Label labelAdresse;
        private Label labelMdpInsc;
        private Label labelMailInsc;
        private Label labelTel;
        private Label labelPrenom;
        private Label labelNom;
        private Label labelErreur;
        private Label labelErreurConnexion;
        private DataGridViewTextBoxColumn ColumnNom;
        private DataGridViewTextBoxColumn ColumnPrix;
        private DataGridViewTextBoxColumn ColumnDispo;
        private Panel panelCommandePersonalise;
        private DataGridView dataGridViewCommandePersonalise;
        private Label labelPrixTotal;
        private Button buttonActualiserPrixTotal;
        private Label label2;
        private Label label1;
        private ListBox listBoxMagasins;
        private DateTimePicker dateTimePickerCommande;
        private Label label3;
        private Label labelConnecter;
        private DataGridViewTextBoxColumn ColumnCommandeNomFleur;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnCommandeQuantitéDisponible;
        private DataGridViewTextBoxColumn ColumnCommandeQuantite;
        private DataGridView dataGridViewAccessoir;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonValiderCommande;
        private Label labelErreurCommande;
        private Button buttonCommandeStandard;
        private Panel panelCommandStandard;
        private DataGridView dataGridViewCommandeStandard;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label labelErreurCommandeS;
        private Button buttonValideCommandStandard;
        private DateTimePicker dateTimePickerCommandeS;
        private Label label5;
        private Label label4;
        private Label labelClient;
        private Panel panelInfoClient;
        private Button buttonAdmin;
        private Button buttonSuiviCommande;
        private Panel panelSuiviCommande;
        private DataGridView dataGridViewSuiviCommande;
        private Label label6;
        private DataGridView dataGridViewHistCommandeClient;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private Label label8;
        private Label label7;
        private Button buttonDeconnecter;
        private Panel panelAdmin;
        private Label labelErreurAdmin;
        private Button buttonConnecteAdmin;
        private TextBox textBoxMdpAdmin;
        private Label label9;
        private ListBox listBoxMagasin2;
        private Label label10;
        private Panel panelCommandeSucces;
        private Label label11;
        private Button buttonOK;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private Label labelStatistique;
        private Panel panelStatistique;
    }
}