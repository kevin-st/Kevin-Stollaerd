namespace Yahtzee_Project
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
            this.aantalOgenLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // werpBtn
            // 
            this.werpBtn.Location = new System.Drawing.Point(39, 124);
            this.werpBtn.Name = "werpBtn";
            this.werpBtn.Size = new System.Drawing.Size(75, 23);
            this.werpBtn.TabIndex = 0;
            this.werpBtn.Text = "Werp";
            this.werpBtn.UseVisualStyleBackColor = true;
            this.werpBtn.Click += new System.EventHandler(this.werpBtn_Click);
            // 
            // aantalOgenLbl
            // 
            this.aantalOgenLbl.BackColor = System.Drawing.Color.Transparent;
            this.aantalOgenLbl.Location = new System.Drawing.Point(0, 0);
            this.aantalOgenLbl.Name = "aantalOgenLbl";
            this.aantalOgenLbl.Size = new System.Drawing.Size(150, 121);
            this.aantalOgenLbl.TabIndex = 1;
            this.aantalOgenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Teerlingview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aantalOgenLbl);
            this.Controls.Add(this.werpBtn);
            this.Name = "Teerlingview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button werpBtn;
        private System.Windows.Forms.Label aantalOgenLbl;
    }
}
