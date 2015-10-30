namespace Yahtzee_Project
{
    partial class Scoreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreTextLbl = new System.Windows.Forms.Label();
            this.highscoreTextLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.highscoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTextLbl
            // 
            this.scoreTextLbl.AutoSize = true;
            this.scoreTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreTextLbl.Location = new System.Drawing.Point(3, 25);
            this.scoreTextLbl.Name = "scoreTextLbl";
            this.scoreTextLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreTextLbl.TabIndex = 0;
            this.scoreTextLbl.Text = "Score:";
            // 
            // highscoreTextLbl
            // 
            this.highscoreTextLbl.AutoSize = true;
            this.highscoreTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.highscoreTextLbl.Location = new System.Drawing.Point(3, 54);
            this.highscoreTextLbl.Name = "highscoreTextLbl";
            this.highscoreTextLbl.Size = new System.Drawing.Size(58, 13);
            this.highscoreTextLbl.TabIndex = 0;
            this.highscoreTextLbl.Text = "Highscore:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Location = new System.Drawing.Point(87, 25);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(13, 13);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "0";
            // 
            // highscoreLbl
            // 
            this.highscoreLbl.AutoSize = true;
            this.highscoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.highscoreLbl.Location = new System.Drawing.Point(87, 54);
            this.highscoreLbl.Name = "highscoreLbl";
            this.highscoreLbl.Size = new System.Drawing.Size(13, 13);
            this.highscoreLbl.TabIndex = 0;
            this.highscoreLbl.Text = "0";
            // 
            // Scoreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.highscoreLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.highscoreTextLbl);
            this.Controls.Add(this.scoreTextLbl);
            this.Name = "Scoreview";
            this.Size = new System.Drawing.Size(150, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTextLbl;
        private System.Windows.Forms.Label highscoreTextLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label highscoreLbl;
    }
}
