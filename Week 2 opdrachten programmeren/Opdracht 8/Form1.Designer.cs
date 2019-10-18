namespace Opdracht_8
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
            this.lblTshirts = new System.Windows.Forms.Label();
            this.lblBroeken = new System.Windows.Forms.Label();
            this.txtThirts = new System.Windows.Forms.TextBox();
            this.txtBroeken = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblRekening = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.lblDatumShow = new System.Windows.Forms.Label();
            this.lblPrijsShow = new System.Windows.Forms.Label();
            this.lblBtwShow = new System.Windows.Forms.Label();
            this.lblTotaalPrijsShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTshirts
            // 
            this.lblTshirts.AutoSize = true;
            this.lblTshirts.Location = new System.Drawing.Point(13, 28);
            this.lblTshirts.Name = "lblTshirts";
            this.lblTshirts.Size = new System.Drawing.Size(128, 13);
            this.lblTshirts.TabIndex = 0;
            this.lblTshirts.Text = "Aantal T-shirts (á € 30.00)";
            // 
            // lblBroeken
            // 
            this.lblBroeken.AutoSize = true;
            this.lblBroeken.Location = new System.Drawing.Point(12, 58);
            this.lblBroeken.Name = "lblBroeken";
            this.lblBroeken.Size = new System.Drawing.Size(140, 13);
            this.lblBroeken.TabIndex = 1;
            this.lblBroeken.Text = "Aantal Broeken (á € 100.00)";
            // 
            // txtThirts
            // 
            this.txtThirts.Location = new System.Drawing.Point(193, 28);
            this.txtThirts.Name = "txtThirts";
            this.txtThirts.Size = new System.Drawing.Size(100, 20);
            this.txtThirts.TabIndex = 2;
            // 
            // txtBroeken
            // 
            this.txtBroeken.Location = new System.Drawing.Point(193, 55);
            this.txtBroeken.Name = "txtBroeken";
            this.txtBroeken.Size = new System.Drawing.Size(100, 20);
            this.txtBroeken.TabIndex = 3;
            // 
            // btnBereken
            // 
            this.btnBereken.Image = global::Opdracht_8.Properties.Resources._366_512;
            this.btnBereken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBereken.Location = new System.Drawing.Point(16, 112);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(277, 50);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblRekening
            // 
            this.lblRekening.AutoSize = true;
            this.lblRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekening.Location = new System.Drawing.Point(16, 204);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(61, 13);
            this.lblRekening.TabIndex = 5;
            this.lblRekening.Text = "Rekening";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 242);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Datum:";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(19, 270);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(29, 13);
            this.lblPrijs.TabIndex = 7;
            this.lblPrijs.Text = "Prijs:";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(19, 296);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(35, 13);
            this.lblBtw.TabIndex = 8;
            this.lblBtw.Text = "BTW:";
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Location = new System.Drawing.Point(19, 323);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(61, 13);
            this.lblTotaalPrijs.TabIndex = 9;
            this.lblTotaalPrijs.Text = "Totaal prijs:";
            this.lblTotaalPrijs.Click += new System.EventHandler(this.LblTotaalPrijs_Click);
            // 
            // lblDatumShow
            // 
            this.lblDatumShow.AutoSize = true;
            this.lblDatumShow.Location = new System.Drawing.Point(195, 242);
            this.lblDatumShow.Name = "lblDatumShow";
            this.lblDatumShow.Size = new System.Drawing.Size(0, 13);
            this.lblDatumShow.TabIndex = 10;
            this.lblDatumShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrijsShow
            // 
            this.lblPrijsShow.AutoSize = true;
            this.lblPrijsShow.Location = new System.Drawing.Point(252, 270);
            this.lblPrijsShow.Name = "lblPrijsShow";
            this.lblPrijsShow.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsShow.TabIndex = 11;
            this.lblPrijsShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBtwShow
            // 
            this.lblBtwShow.AutoSize = true;
            this.lblBtwShow.Location = new System.Drawing.Point(252, 296);
            this.lblBtwShow.Name = "lblBtwShow";
            this.lblBtwShow.Size = new System.Drawing.Size(0, 13);
            this.lblBtwShow.TabIndex = 12;
            this.lblBtwShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotaalPrijsShow
            // 
            this.lblTotaalPrijsShow.AutoSize = true;
            this.lblTotaalPrijsShow.Location = new System.Drawing.Point(252, 323);
            this.lblTotaalPrijsShow.Name = "lblTotaalPrijsShow";
            this.lblTotaalPrijsShow.Size = new System.Drawing.Size(0, 13);
            this.lblTotaalPrijsShow.TabIndex = 13;
            this.lblTotaalPrijsShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 376);
            this.Controls.Add(this.lblTotaalPrijsShow);
            this.Controls.Add(this.lblBtwShow);
            this.Controls.Add(this.lblPrijsShow);
            this.Controls.Add(this.lblDatumShow);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblRekening);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtBroeken);
            this.Controls.Add(this.txtThirts);
            this.Controls.Add(this.lblBroeken);
            this.Controls.Add(this.lblTshirts);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTshirts;
        private System.Windows.Forms.Label lblBroeken;
        private System.Windows.Forms.TextBox txtThirts;
        private System.Windows.Forms.TextBox txtBroeken;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblRekening;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblTotaalPrijs;
        private System.Windows.Forms.Label lblDatumShow;
        private System.Windows.Forms.Label lblPrijsShow;
        private System.Windows.Forms.Label lblBtwShow;
        private System.Windows.Forms.Label lblTotaalPrijsShow;
    }
}

