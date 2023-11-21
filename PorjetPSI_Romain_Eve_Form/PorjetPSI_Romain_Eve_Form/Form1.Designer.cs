using System.Windows.Forms;

namespace PorjetPSI_Romain_Eve_Form
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            nunaceGrisToolStripMenuItem = new ToolStripMenuItem();
            noirEtBlancToolStripMenuItem = new ToolStripMenuItem();
            matriceConvolutionToolStripMenuItem = new ToolStripMenuItem();
            flouToolStripMenuItem = new ToolStripMenuItem();
            renforcementDesBordsToolStripMenuItem = new ToolStripMenuItem();
            repoussageToolStripMenuItem = new ToolStripMenuItem();
            detectionDeContourToolStripMenuItem = new ToolStripMenuItem();
            rotationToolStripMenuItem = new ToolStripMenuItem();
            agrandireToolStripMenuItem = new ToolStripMenuItem();
            fractaleToolStripMenuItem1 = new ToolStripMenuItem();
            imageDansImageToolStripMenuItem1 = new ToolStripMenuItem();
            huffmanToolStripMenuItem1 = new ToolStripMenuItem();
            paintballToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBoxImage = new PictureBox();
            listBoxImages = new ListBox();
            labelUnderImage = new Label();
            buttonMoins = new Button();
            buttonPlus = new Button();
            buttonRotation = new Button();
            labelRotation = new Label();
            textBoxRotation = new TextBox();
            labelHuffman = new Label();
            listBoxColor = new ListBox();
            labelChoixCouleur = new Label();
            labelTaille = new Label();
            numericUpDownPaintball = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaintball).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nunaceGrisToolStripMenuItem, noirEtBlancToolStripMenuItem, matriceConvolutionToolStripMenuItem, rotationToolStripMenuItem, agrandireToolStripMenuItem, fractaleToolStripMenuItem1, imageDansImageToolStripMenuItem1, huffmanToolStripMenuItem1, paintballToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(208, 598);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nunaceGrisToolStripMenuItem
            // 
            nunaceGrisToolStripMenuItem.Name = "nunaceGrisToolStripMenuItem";
            nunaceGrisToolStripMenuItem.Padding = new Padding(4, 0, 4, 10);
            nunaceGrisToolStripMenuItem.Size = new Size(193, 36);
            nunaceGrisToolStripMenuItem.Text = "Nuance de gris";
            nunaceGrisToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            nunaceGrisToolStripMenuItem.Click += nunaceGrisToolStripMenuItem_Click;
            // 
            // noirEtBlancToolStripMenuItem
            // 
            noirEtBlancToolStripMenuItem.Name = "noirEtBlancToolStripMenuItem";
            noirEtBlancToolStripMenuItem.Padding = new Padding(4, 0, 4, 10);
            noirEtBlancToolStripMenuItem.Size = new Size(193, 36);
            noirEtBlancToolStripMenuItem.Text = "Noir et blanc";
            noirEtBlancToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            noirEtBlancToolStripMenuItem.Click += noirEtBlancToolStripMenuItem_Click;
            // 
            // matriceConvolutionToolStripMenuItem
            // 
            matriceConvolutionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flouToolStripMenuItem, renforcementDesBordsToolStripMenuItem, repoussageToolStripMenuItem, detectionDeContourToolStripMenuItem });
            matriceConvolutionToolStripMenuItem.Name = "matriceConvolutionToolStripMenuItem";
            matriceConvolutionToolStripMenuItem.Padding = new Padding(4, 0, 4, 10);
            matriceConvolutionToolStripMenuItem.Size = new Size(193, 36);
            matriceConvolutionToolStripMenuItem.Text = "Matrice Convolution";
            matriceConvolutionToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flouToolStripMenuItem
            // 
            flouToolStripMenuItem.Name = "flouToolStripMenuItem";
            flouToolStripMenuItem.Size = new Size(330, 34);
            flouToolStripMenuItem.Text = "Flou";
            flouToolStripMenuItem.Click += flouToolStripMenuItem_Click;
            // 
            // renforcementDesBordsToolStripMenuItem
            // 
            renforcementDesBordsToolStripMenuItem.Name = "renforcementDesBordsToolStripMenuItem";
            renforcementDesBordsToolStripMenuItem.Size = new Size(330, 34);
            renforcementDesBordsToolStripMenuItem.Text = "Renforcement des bords";
            renforcementDesBordsToolStripMenuItem.Click += renforcementDesBordsToolStripMenuItem_Click;
            // 
            // repoussageToolStripMenuItem
            // 
            repoussageToolStripMenuItem.Name = "repoussageToolStripMenuItem";
            repoussageToolStripMenuItem.Size = new Size(330, 34);
            repoussageToolStripMenuItem.Text = "Repoussage";
            repoussageToolStripMenuItem.Click += repoussageToolStripMenuItem_Click;
            // 
            // detectionDeContourToolStripMenuItem
            // 
            detectionDeContourToolStripMenuItem.Name = "detectionDeContourToolStripMenuItem";
            detectionDeContourToolStripMenuItem.Size = new Size(330, 34);
            detectionDeContourToolStripMenuItem.Text = "Detection de contour";
            detectionDeContourToolStripMenuItem.Click += detectionDeContourToolStripMenuItem_Click;
            // 
            // rotationToolStripMenuItem
            // 
            rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            rotationToolStripMenuItem.Padding = new Padding(4, 0, 4, 10);
            rotationToolStripMenuItem.Size = new Size(193, 36);
            rotationToolStripMenuItem.Text = "Rotation";
            rotationToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            rotationToolStripMenuItem.Click += rotationToolStripMenuItem_Click;
            // 
            // agrandireToolStripMenuItem
            // 
            agrandireToolStripMenuItem.Name = "agrandireToolStripMenuItem";
            agrandireToolStripMenuItem.Padding = new Padding(4, 0, 4, 10);
            agrandireToolStripMenuItem.Size = new Size(193, 36);
            agrandireToolStripMenuItem.Text = "Agrandire/Retrecire";
            agrandireToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            agrandireToolStripMenuItem.Click += agrandireToolStripMenuItem_Click;
            // 
            // fractaleToolStripMenuItem1
            // 
            fractaleToolStripMenuItem1.Name = "fractaleToolStripMenuItem1";
            fractaleToolStripMenuItem1.Padding = new Padding(4, 0, 4, 10);
            fractaleToolStripMenuItem1.Size = new Size(193, 36);
            fractaleToolStripMenuItem1.Text = "Fractale";
            fractaleToolStripMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
            fractaleToolStripMenuItem1.Click += fractaleToolStripMenuItem1_Click;
            // 
            // imageDansImageToolStripMenuItem1
            // 
            imageDansImageToolStripMenuItem1.Name = "imageDansImageToolStripMenuItem1";
            imageDansImageToolStripMenuItem1.Padding = new Padding(4, 0, 4, 10);
            imageDansImageToolStripMenuItem1.Size = new Size(193, 36);
            imageDansImageToolStripMenuItem1.Text = "Image dans image";
            imageDansImageToolStripMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
            imageDansImageToolStripMenuItem1.Click += imageDansImageToolStripMenuItem1_Click;
            // 
            // huffmanToolStripMenuItem1
            // 
            huffmanToolStripMenuItem1.Name = "huffmanToolStripMenuItem1";
            huffmanToolStripMenuItem1.Padding = new Padding(4, 0, 4, 10);
            huffmanToolStripMenuItem1.Size = new Size(193, 36);
            huffmanToolStripMenuItem1.Text = "Huffman";
            huffmanToolStripMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
            huffmanToolStripMenuItem1.Click += huffmanToolStripMenuItem1_Click;
            // 
            // paintballToolStripMenuItem1
            // 
            paintballToolStripMenuItem1.Name = "paintballToolStripMenuItem1";
            paintballToolStripMenuItem1.Padding = new Padding(4, 0, 4, 10);
            paintballToolStripMenuItem1.Size = new Size(193, 36);
            paintballToolStripMenuItem1.Text = "Paintball";
            paintballToolStripMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
            paintballToolStripMenuItem1.Click += paintballToolStripMenuItem1_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Anchor = AnchorStyles.None;
            pictureBoxImage.BackColor = SystemColors.Control;
            pictureBoxImage.Location = new Point(269, 55);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(745, 432);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImage.TabIndex = 1;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.MouseClick += mouseClickImage;
            // 
            // listBoxImages
            // 
            listBoxImages.BackColor = Color.FromArgb(224, 224, 224);
            listBoxImages.FormattingEnabled = true;
            listBoxImages.ItemHeight = 25;
            listBoxImages.Location = new Point(12, 339);
            listBoxImages.Name = "listBoxImages";
            listBoxImages.Size = new Size(121, 204);
            listBoxImages.TabIndex = 3;
            listBoxImages.SelectedIndexChanged += listBoxImages_SelectedIndexChanged;
            // 
            // labelUnderImage
            // 
            labelUnderImage.BackColor = Color.Transparent;
            labelUnderImage.Dock = DockStyle.Bottom;
            labelUnderImage.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnderImage.Location = new Point(208, 549);
            labelUnderImage.Name = "labelUnderImage";
            labelUnderImage.Size = new Size(941, 49);
            labelUnderImage.TabIndex = 5;
            labelUnderImage.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonMoins
            // 
            buttonMoins.AutoSize = true;
            buttonMoins.Location = new Point(34, 546);
            buttonMoins.Name = "buttonMoins";
            buttonMoins.Size = new Size(37, 35);
            buttonMoins.TabIndex = 6;
            buttonMoins.Text = "-";
            buttonMoins.UseVisualStyleBackColor = true;
            buttonMoins.Click += buttonMoins_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.AutoSize = true;
            buttonPlus.Location = new Point(77, 546);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(38, 35);
            buttonPlus.TabIndex = 7;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonRotation
            // 
            buttonRotation.Location = new Point(927, 519);
            buttonRotation.Name = "buttonRotation";
            buttonRotation.Size = new Size(98, 32);
            buttonRotation.TabIndex = 8;
            buttonRotation.Text = "Entrer";
            buttonRotation.UseVisualStyleBackColor = true;
            buttonRotation.Click += buttonRotation_Click;
            // 
            // labelRotation
            // 
            labelRotation.AutoSize = true;
            labelRotation.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRotation.Location = new Point(257, 522);
            labelRotation.Name = "labelRotation";
            labelRotation.Size = new Size(98, 29);
            labelRotation.TabIndex = 9;
            labelRotation.Text = "Angle :";
            // 
            // textBoxRotation
            // 
            textBoxRotation.BackColor = SystemColors.Control;
            textBoxRotation.BorderStyle = BorderStyle.None;
            textBoxRotation.Location = new Point(352, 527);
            textBoxRotation.Name = "textBoxRotation";
            textBoxRotation.Size = new Size(62, 24);
            textBoxRotation.TabIndex = 10;
            // 
            // labelHuffman
            // 
            labelHuffman.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHuffman.Location = new Point(194, 53);
            labelHuffman.Name = "labelHuffman";
            labelHuffman.Size = new Size(882, 449);
            labelHuffman.TabIndex = 11;
            // 
            // listBoxColor
            // 
            listBoxColor.BackColor = SystemColors.Control;
            listBoxColor.BorderStyle = BorderStyle.None;
            listBoxColor.FormattingEnabled = true;
            listBoxColor.ItemHeight = 25;
            listBoxColor.Location = new Point(1020, 140);
            listBoxColor.Name = "listBoxColor";
            listBoxColor.Size = new Size(103, 125);
            listBoxColor.TabIndex = 5;
            listBoxColor.SelectedIndexChanged += listBoxColor_SelectedIndexChanged;
            // 
            // labelChoixCouleur
            // 
            labelChoixCouleur.AutoSize = true;
            labelChoixCouleur.Location = new Point(1020, 72);
            labelChoixCouleur.Name = "labelChoixCouleur";
            labelChoixCouleur.Size = new Size(128, 50);
            labelChoixCouleur.TabIndex = 12;
            labelChoixCouleur.Text = "Choisir \r\nla couleur :";
            // 
            // labelTaille
            // 
            labelTaille.AutoSize = true;
            labelTaille.Location = new Point(1020, 294);
            labelTaille.Name = "labelTaille";
            labelTaille.Size = new Size(103, 50);
            labelTaille.TabIndex = 13;
            labelTaille.Text = "Choisir\r\nla taille :\r\n";
            // 
            // numericUpDownPaintball
            // 
            numericUpDownPaintball.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownPaintball.Location = new Point(1020, 371);
            numericUpDownPaintball.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDownPaintball.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPaintball.Name = "numericUpDownPaintball";
            numericUpDownPaintball.Size = new Size(50, 31);
            numericUpDownPaintball.TabIndex = 14;
            numericUpDownPaintball.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPaintball.ValueChanged += numericUpDownPaintball_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1149, 598);
            Controls.Add(buttonRotation);
            Controls.Add(numericUpDownPaintball);
            Controls.Add(labelTaille);
            Controls.Add(labelChoixCouleur);
            Controls.Add(listBoxColor);
            Controls.Add(labelRotation);
            Controls.Add(textBoxRotation);
            Controls.Add(buttonPlus);
            Controls.Add(labelUnderImage);
            Controls.Add(buttonMoins);
            Controls.Add(listBoxImages);
            Controls.Add(pictureBoxImage);
            Controls.Add(menuStrip1);
            Controls.Add(labelHuffman);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Projet PSI - Eve PINEAU  Romain PAUPE";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaintball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nunaceGrisToolStripMenuItem;
        private ToolStripMenuItem noirEtBlancToolStripMenuItem;
        private ToolStripMenuItem matriceConvolutionToolStripMenuItem;
        private ToolStripMenuItem flouToolStripMenuItem;
        private ToolStripMenuItem renforcementDesBordsToolStripMenuItem;
        private ToolStripMenuItem repoussageToolStripMenuItem;
        private ToolStripMenuItem detectionDeContourToolStripMenuItem;
        private ToolStripMenuItem rotationToolStripMenuItem;
        private ToolStripMenuItem agrandireToolStripMenuItem;
        private ToolStripMenuItem fractaleToolStripMenuItem1;
        private ToolStripMenuItem imageDansImageToolStripMenuItem1;
        private ToolStripMenuItem huffmanToolStripMenuItem1;
        private ToolStripMenuItem paintballToolStripMenuItem1;
        private PictureBox pictureBoxImage;
        private ListBox listBoxImages;
        private Label labelUnderImage;
        private Button buttonMoins;
        private Button buttonPlus;
        private Button buttonRotation;
        private Label labelRotation;
        private TextBox textBoxRotation;
        private Label labelHuffman;
        private ListBox listBoxColor;
        private Label labelChoixCouleur;
        private Label labelTaille;
        private NumericUpDown numericUpDownPaintball;
    }
}