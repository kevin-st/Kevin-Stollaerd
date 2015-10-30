namespace Project_Yahtzee_Enkelvoudige_opdracht.Views
{
    partial class Teerlingview
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
            this.werpBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // werpBtn
            // 
            this.werpBtn.Location = new System.Drawing.Point(37, 124);
            this.werpBtn.Name = "werpBtn";
            this.werpBtn.Size = new System.Drawing.Size(75, 23);
            this.werpBtn.TabIndex = 0;
            this.werpBtn.Text = "Werp";
            this.werpBtn.UseVisualStyleBackColor = true;
            this.werpBtn.Click += new System.EventHandler(this.werpBtn_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreLbl.Location = new System.Drawing.Point(0, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(150, 121);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Teerlingview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.werpBtn);
            this.Name = "Teerlingview";
            this.Load += new System.EventHandler(this.Teerlingview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button werpBtn;
        private System.Windows.Forms.Label scoreLbl;
    }
}
