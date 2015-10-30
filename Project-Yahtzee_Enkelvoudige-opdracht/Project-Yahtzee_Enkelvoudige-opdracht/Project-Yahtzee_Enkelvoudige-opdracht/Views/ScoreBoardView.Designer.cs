namespace Project_Yahtzee_Enkelvoudige_opdracht.Views
{
    partial class ScoreBoardView
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
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highscoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTextLbl
            // 
            this.scoreTextLbl.AutoSize = true;
            this.scoreTextLbl.Location = new System.Drawing.Point(12, 30);
            this.scoreTextLbl.Name = "scoreTextLbl";
            this.scoreTextLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreTextLbl.TabIndex = 0;
            this.scoreTextLbl.Text = "Score:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(76, 30);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(13, 13);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Highscore:";
            // 
            // highscoreLbl
            // 
            this.highscoreLbl.AutoSize = true;
            this.highscoreLbl.Location = new System.Drawing.Point(76, 61);
            this.highscoreLbl.Name = "highscoreLbl";
            this.highscoreLbl.Size = new System.Drawing.Size(13, 13);
            this.highscoreLbl.TabIndex = 0;
            this.highscoreLbl.Text = "0";
            // 
            // ScoreBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.highscoreLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreTextLbl);
            this.Name = "ScoreBoardView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTextLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highscoreLbl;
    }
}
