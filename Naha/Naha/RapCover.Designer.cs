namespace Naha
{
    partial class RapCover
    {
        private System.ComponentModel.IContainer components = null;

       
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
            this.label_artiste = new System.Windows.Forms.Label();
            this.label_album = new System.Windows.Forms.Label();
            this.pbx_cover = new System.Windows.Forms.PictureBox();
            this.button_suivant = new System.Windows.Forms.Button();
            this.tB_difficulty = new System.Windows.Forms.TrackBar();
            this.label_TbValue = new System.Windows.Forms.Label();
            this.button_lev1 = new System.Windows.Forms.Button();
            this.button_lev2 = new System.Windows.Forms.Button();
            this.button_lev3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_difficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // label_artiste
            // 
            this.label_artiste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_artiste.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_artiste.ForeColor = System.Drawing.Color.White;
            this.label_artiste.Location = new System.Drawing.Point(369, 71);
            this.label_artiste.Name = "label_artiste";
            this.label_artiste.Size = new System.Drawing.Size(438, 33);
            this.label_artiste.TabIndex = 0;
            this.label_artiste.Text = "Artiste";
            this.label_artiste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_album
            // 
            this.label_album.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_album.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_album.ForeColor = System.Drawing.Color.White;
            this.label_album.Location = new System.Drawing.Point(405, 115);
            this.label_album.Name = "label_album";
            this.label_album.Size = new System.Drawing.Size(366, 33);
            this.label_album.TabIndex = 1;
            this.label_album.Text = "Album";
            this.label_album.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_cover
            // 
            this.pbx_cover.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbx_cover.Location = new System.Drawing.Point(282, 199);
            this.pbx_cover.Name = "pbx_cover";
            this.pbx_cover.Size = new System.Drawing.Size(600, 600);
            this.pbx_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_cover.TabIndex = 2;
            this.pbx_cover.TabStop = false;
            // 
            // button_suivant
            // 
            this.button_suivant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_suivant.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_suivant.ForeColor = System.Drawing.Color.Brown;
            this.button_suivant.Location = new System.Drawing.Point(513, 819);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(146, 34);
            this.button_suivant.TabIndex = 3;
            this.button_suivant.Text = "SUIVANT";
            this.button_suivant.UseVisualStyleBackColor = true;
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // tB_difficulty
            // 
            this.tB_difficulty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tB_difficulty.Location = new System.Drawing.Point(0, 796);
            this.tB_difficulty.Maximum = 100;
            this.tB_difficulty.Minimum = 2;
            this.tB_difficulty.Name = "tB_difficulty";
            this.tB_difficulty.Size = new System.Drawing.Size(1152, 69);
            this.tB_difficulty.TabIndex = 4;
            this.tB_difficulty.Value = 15;
            this.tB_difficulty.Scroll += new System.EventHandler(this.tB_difficulty_Scroll);
            // 
            // label_TbValue
            // 
            this.label_TbValue.AutoSize = true;
            this.label_TbValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_TbValue.Location = new System.Drawing.Point(12, 9);
            this.label_TbValue.Name = "label_TbValue";
            this.label_TbValue.Size = new System.Drawing.Size(59, 25);
            this.label_TbValue.TabIndex = 5;
            this.label_TbValue.Text = "label1";
            // 
            // button_lev1
            // 
            this.button_lev1.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_lev1.Location = new System.Drawing.Point(67, 101);
            this.button_lev1.Name = "button_lev1";
            this.button_lev1.Size = new System.Drawing.Size(140, 60);
            this.button_lev1.TabIndex = 6;
            this.button_lev1.Text = "Level 1";
            this.button_lev1.UseVisualStyleBackColor = true;
            this.button_lev1.Click += new System.EventHandler(this.button_lev1_Click);
            // 
            // button_lev2
            // 
            this.button_lev2.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_lev2.Location = new System.Drawing.Point(67, 245);
            this.button_lev2.Name = "button_lev2";
            this.button_lev2.Size = new System.Drawing.Size(140, 60);
            this.button_lev2.TabIndex = 7;
            this.button_lev2.Text = "Level 2";
            this.button_lev2.UseVisualStyleBackColor = true;
            this.button_lev2.Click += new System.EventHandler(this.button_lev2_Click);
            // 
            // button_lev3
            // 
            this.button_lev3.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_lev3.Location = new System.Drawing.Point(67, 381);
            this.button_lev3.Name = "button_lev3";
            this.button_lev3.Size = new System.Drawing.Size(140, 60);
            this.button_lev3.TabIndex = 8;
            this.button_lev3.Text = "Level 3";
            this.button_lev3.UseVisualStyleBackColor = true;
            this.button_lev3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RapCover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1152, 865);
            this.Controls.Add(this.button_lev3);
            this.Controls.Add(this.button_lev2);
            this.Controls.Add(this.button_lev1);
            this.Controls.Add(this.label_TbValue);
            this.Controls.Add(this.tB_difficulty);
            this.Controls.Add(this.button_suivant);
            this.Controls.Add(this.pbx_cover);
            this.Controls.Add(this.label_album);
            this.Controls.Add(this.label_artiste);
            this.Name = "RapCover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RapCover";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_difficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_artiste;
        private Label label_album;
        private PictureBox pbx_cover;
        private Button button_suivant;
        private TrackBar tB_difficulty;
        private Label label_TbValue;
        private Button button_lev1;
        private Button button_lev2;
        private Button button_lev3;
    }
}