namespace Project_Yahtzee_Enkelvoudige_opdracht.Views
{
    partial class YahtzeeView
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
            this.throwAllBtn = new System.Windows.Forms.Button();
            this.aantalWorpenTextLbl = new System.Windows.Forms.Label();
            this.aantalWorpenLbl = new System.Windows.Forms.Label();
            this.divideTextLbl = new System.Windows.Forms.Label();
            this.maxAantalWorpenLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // throwAllBtn
            // 
            this.throwAllBtn.Location = new System.Drawing.Point(3, 26);
            this.throwAllBtn.Name = "throwAllBtn";
            this.throwAllBtn.Size = new System.Drawing.Size(494, 23);
            this.throwAllBtn.TabIndex = 0;
            this.throwAllBtn.Text = "Werp ze allemaal";
            this.throwAllBtn.UseVisualStyleBackColor = true;
            this.throwAllBtn.Click += new System.EventHandler(this.throwAllBtn_Click);
            // 
            // aantalWorpenTextLbl
            // 
            this.aantalWorpenTextLbl.AutoSize = true;
            this.aantalWorpenTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.aantalWorpenTextLbl.Location = new System.Drawing.Point(3, 71);
            this.aantalWorpenTextLbl.Name = "aantalWorpenTextLbl";
            this.aantalWorpenTextLbl.Size = new System.Drawing.Size(81, 13);
            this.aantalWorpenTextLbl.TabIndex = 1;
            this.aantalWorpenTextLbl.Text = "Aantal Worpen:";
            // 
            // aantalWorpenLbl
            // 
            this.aantalWorpenLbl.AutoSize = true;
            this.aantalWorpenLbl.BackColor = System.Drawing.Color.Transparent;
            this.aantalWorpenLbl.Location = new System.Drawing.Point(90, 71);
            this.aantalWorpenLbl.Name = "aantalWorpenLbl";
            this.aantalWorpenLbl.Size = new System.Drawing.Size(0, 13);
            this.aantalWorpenLbl.TabIndex = 1;
            // 
            // divideTextLbl
            // 
            this.divideTextLbl.AutoSize = true;
            this.divideTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.divideTextLbl.Location = new System.Drawing.Point(99, 71);
            this.divideTextLbl.Name = "divideTextLbl";
            this.divideTextLbl.Size = new System.Drawing.Size(12, 13);
            this.divideTextLbl.TabIndex = 1;
            this.divideTextLbl.Text = "/";
            // 
            // maxAantalWorpenLbl
            // 
            this.maxAantalWorpenLbl.AutoSize = true;
            this.maxAantalWorpenLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxAantalWorpenLbl.Location = new System.Drawing.Point(117, 71);
            this.maxAantalWorpenLbl.Name = "maxAantalWorpenLbl";
            this.maxAantalWorpenLbl.Size = new System.Drawing.Size(0, 13);
            this.maxAantalWorpenLbl.TabIndex = 1;
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxAantalWorpenLbl);
            this.Controls.Add(this.divideTextLbl);
            this.Controls.Add(this.aantalWorpenLbl);
            this.Controls.Add(this.aantalWorpenTextLbl);
            this.Controls.Add(this.throwAllBtn);
            this.Name = "YahtzeeView";
            this.Size = new System.Drawing.Size(501, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button throwAllBtn;
        private System.Windows.Forms.Label aantalWorpenTextLbl;
        private System.Windows.Forms.Label aantalWorpenLbl;
        private System.Windows.Forms.Label divideTextLbl;
        private System.Windows.Forms.Label maxAantalWorpenLbl;
    }
}
