namespace Naha
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_lancerJeu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_jeu2 = new System.Windows.Forms.Button();
            this.button_morpion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_lancerJeu
            // 
            this.button_lancerJeu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_lancerJeu.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_lancerJeu.ForeColor = System.Drawing.Color.Firebrick;
            this.button_lancerJeu.Location = new System.Drawing.Point(208, 206);
            this.button_lancerJeu.Name = "button_lancerJeu";
            this.button_lancerJeu.Size = new System.Drawing.Size(350, 160);
            this.button_lancerJeu.TabIndex = 0;
            this.button_lancerJeu.Text = "Lancer je jeu\r\n";
            this.button_lancerJeu.UseVisualStyleBackColor = true;
            this.button_lancerJeu.Click += new System.EventHandler(this.button_lancerJeu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 185);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenu dans mon premier projet windows forms !\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_jeu2
            // 
            this.button_jeu2.Location = new System.Drawing.Point(626, 259);
            this.button_jeu2.Name = "button_jeu2";
            this.button_jeu2.Size = new System.Drawing.Size(133, 122);
            this.button_jeu2.TabIndex = 2;
            this.button_jeu2.Text = "Lancer l\'autre jeux";
            this.button_jeu2.UseVisualStyleBackColor = true;
            this.button_jeu2.Click += new System.EventHandler(this.button_jeu2_Click);
            // 
            // button_morpion
            // 
            this.button_morpion.Location = new System.Drawing.Point(32, 181);
            this.button_morpion.Name = "button_morpion";
            this.button_morpion.Size = new System.Drawing.Size(147, 154);
            this.button_morpion.TabIndex = 3;
            this.button_morpion.Text = "Le morpion";
            this.button_morpion.UseVisualStyleBackColor = true;
            this.button_morpion.Click += new System.EventHandler(this.button_morpion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "PacMan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(381, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "kENDAMA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_morpion);
            this.Controls.Add(this.button_jeu2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_lancerJeu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_lancerJeu;
        private Label label1;
        private Button button_jeu2;
        private Button button_morpion;
        private Button button1;
        private Button button2;
    }
}