namespace Naha
{
    partial class acceuil
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
            this.button_jouer = new System.Windows.Forms.Button();
            this.label_nomBiere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TorF = new System.Windows.Forms.Label();
            this.pbx_biere = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.textBox_degre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_biere)).BeginInit();
            this.SuspendLayout();
            // 
            // button_jouer
            // 
            this.button_jouer.AutoSize = true;
            this.button_jouer.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_jouer.Location = new System.Drawing.Point(319, 423);
            this.button_jouer.Name = "button_jouer";
            this.button_jouer.Size = new System.Drawing.Size(159, 50);
            this.button_jouer.TabIndex = 0;
            this.button_jouer.Text = "COMMENCER\r(space)\r";
            this.button_jouer.UseVisualStyleBackColor = true;
            this.button_jouer.Click += new System.EventHandler(this.button_jouer_Click);
            // 
            // label_nomBiere
            // 
            this.label_nomBiere.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nomBiere.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_nomBiere.Location = new System.Drawing.Point(6, 48);
            this.label_nomBiere.Name = "label_nomBiere";
            this.label_nomBiere.Size = new System.Drawing.Size(784, 60);
            this.label_nomBiere.TabIndex = 1;
            this.label_nomBiere.Text = "Nom de la bière\r\n";
            this.label_nomBiere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(155, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quel est le degré de cette biere ?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TorF
            // 
            this.label_TorF.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TorF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_TorF.Location = new System.Drawing.Point(199, 476);
            this.label_TorF.Name = "label_TorF";
            this.label_TorF.Size = new System.Drawing.Size(398, 33);
            this.label_TorF.TabIndex = 8;
            this.label_TorF.Text = "V ou F";
            this.label_TorF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbx_biere
            // 
            this.pbx_biere.Location = new System.Drawing.Point(270, 111);
            this.pbx_biere.Name = "pbx_biere";
            this.pbx_biere.Size = new System.Drawing.Size(256, 256);
            this.pbx_biere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_biere.TabIndex = 9;
            this.pbx_biere.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(640, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Score :";
            // 
            // label_score
            // 
            this.label_score.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_score.Location = new System.Drawing.Point(640, 178);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(88, 45);
            this.label_score.TabIndex = 11;
            this.label_score.Text = "0";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_degre
            // 
            this.textBox_degre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_degre.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_degre.Location = new System.Drawing.Point(271, 384);
            this.textBox_degre.Name = "textBox_degre";
            this.textBox_degre.Size = new System.Drawing.Size(254, 35);
            this.textBox_degre.TabIndex = 12;
            this.textBox_degre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.textBox_degre);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_biere);
            this.Controls.Add(this.label_TorF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nomBiere);
            this.Controls.Add(this.button_jouer);
            this.Name = "acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_biere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_jouer;
        private Label label_nomBiere;
        private Label label1;
        private Label label_TorF;
        private PictureBox pbx_biere;
        private Label label2;
        private Label label_score;
        private TextBox textBox_degre;
    }
}