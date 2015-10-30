namespace Yahtzee_Project
{
    partial class Yahtzeeview
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
            this.throwAllDice = new System.Windows.Forms.Button();
            this.aantalWorpenTextLbl = new System.Windows.Forms.Label();
            this.aantalWorpenLbl = new System.Windows.Forms.Label();
            this.divideLbl = new System.Windows.Forms.Label();
            this.maxAantalWorpenLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // throwAllDice
            // 
            this.throwAllDice.Location = new System.Drawing.Point(3, 24);
            this.throwAllDice.Name = "throwAllDice";
            this.throwAllDice.Size = new System.Drawing.Size(437, 23);
            this.throwAllDice.TabIndex = 0;
            this.throwAllDice.Text = "Werp ze allemaal";
            this.throwAllDice.UseVisualStyleBackColor = true;
            this.throwAllDice.Click += new System.EventHandler(this.throwAllDice_Click);
            // 
            // aantalWorpenTextLbl
            // 
            this.aantalWorpenTextLbl.AutoSize = true;
            this.aantalWorpenTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.aantalWorpenTextLbl.Location = new System.Drawing.Point(3, 59);
            this.aantalWorpenTextLbl.Name = "aantalWorpenTextLbl";
            this.aantalWorpenTextLbl.Size = new System.Drawing.Size(78, 13);
            this.aantalWorpenTextLbl.TabIndex = 1;
            this.aantalWorpenTextLbl.Text = "Aantal worpen:";
            // 
            // aantalWorpenLbl
            // 
            this.aantalWorpenLbl.AutoSize = true;
            this.aantalWorpenLbl.BackColor = System.Drawing.Color.Transparent;
            this.aantalWorpenLbl.Location = new System.Drawing.Point(87, 59);
            this.aantalWorpenLbl.Name = "aantalWorpenLbl";
            this.aantalWorpenLbl.Size = new System.Drawing.Size(0, 13);
            this.aantalWorpenLbl.TabIndex = 1;
            // 
            // divideLbl
            // 
            this.divideLbl.AutoSize = true;
            this.divideLbl.BackColor = System.Drawing.Color.Transparent;
            this.divideLbl.Location = new System.Drawing.Point(102, 59);
            this.divideLbl.Name = "divideLbl";
            this.divideLbl.Size = new System.Drawing.Size(12, 13);
            this.divideLbl.TabIndex = 1;
            this.divideLbl.Text = "/";
            // 
            // maxAantalWorpenLbl
            // 
            this.maxAantalWorpenLbl.AutoSize = true;
            this.maxAantalWorpenLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxAantalWorpenLbl.Location = new System.Drawing.Point(125, 59);
            this.maxAantalWorpenLbl.Name = "maxAantalWorpenLbl";
            this.maxAantalWorpenLbl.Size = new System.Drawing.Size(0, 13);
            this.maxAantalWorpenLbl.TabIndex = 1;
            // 
            // Yahtzeeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxAantalWorpenLbl);
            this.Controls.Add(this.divideLbl);
            this.Controls.Add(this.aantalWorpenLbl);
            this.Controls.Add(this.aantalWorpenTextLbl);
            this.Controls.Add(this.throwAllDice);
            this.Name = "Yahtzeeview";
            this.Size = new System.Drawing.Size(440, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button throwAllDice;
        private System.Windows.Forms.Label aantalWorpenTextLbl;
        private System.Windows.Forms.Label aantalWorpenLbl;
        private System.Windows.Forms.Label divideLbl;
        private System.Windows.Forms.Label maxAantalWorpenLbl;
    }
}
