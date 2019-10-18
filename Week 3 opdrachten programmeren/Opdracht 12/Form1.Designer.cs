namespace Opdracht_12
{
    partial class Form1
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
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblPrijsShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(12, 41);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.lblLeeftijd.TabIndex = 0;
            this.lblLeeftijd.Text = "Leeftijd";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(103, 38);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(15, 92);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(188, 32);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken prijs bioscoopkaartje";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(15, 148);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(104, 13);
            this.lblPrijs.TabIndex = 3;
            this.lblPrijs.Text = "Prijs bioscoopkaartje";
            // 
            // lblPrijsShow
            // 
            this.lblPrijsShow.AutoSize = true;
            this.lblPrijsShow.Location = new System.Drawing.Point(142, 148);
            this.lblPrijsShow.Name = "lblPrijsShow";
            this.lblPrijsShow.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsShow.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 184);
            this.Controls.Add(this.lblPrijsShow);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.lblLeeftijd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblPrijsShow;
    }
}

