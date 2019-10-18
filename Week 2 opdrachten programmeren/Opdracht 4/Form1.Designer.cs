namespace Opdracht_4
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblGeefPrijs = new System.Windows.Forms.Label();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.lblPrijsDis = new System.Windows.Forms.Label();
            this.lblBtwDis = new System.Windows.Forms.Label();
            this.lblTotaalPrijsDis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(83, 92);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 34);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "Bereken BTW";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblGeefPrijs
            // 
            this.lblGeefPrijs.AutoSize = true;
            this.lblGeefPrijs.Location = new System.Drawing.Point(12, 46);
            this.lblGeefPrijs.Name = "lblGeefPrijs";
            this.lblGeefPrijs.Size = new System.Drawing.Size(54, 13);
            this.lblGeefPrijs.TabIndex = 1;
            this.lblGeefPrijs.Text = "Geef prijs:";
            this.lblGeefPrijs.Click += new System.EventHandler(this.LblGeefPrijs_Click);
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(83, 43);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 2;
            this.txtPrijs.TextChanged += new System.EventHandler(this.TxtPrijs_TextChanged);
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(183, 145);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblPrijs.TabIndex = 3;
            this.lblPrijs.Click += new System.EventHandler(this.LblPrijs_Click);
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(183, 168);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(0, 13);
            this.lblBtw.TabIndex = 3;
            this.lblBtw.Click += new System.EventHandler(this.LblBtw_Click);
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Location = new System.Drawing.Point(183, 190);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblTotaalPrijs.TabIndex = 3;
            this.lblTotaalPrijs.Click += new System.EventHandler(this.LblTotaalPrijs_Click);
            // 
            // lblPrijsDis
            // 
            this.lblPrijsDis.AutoSize = true;
            this.lblPrijsDis.Location = new System.Drawing.Point(12, 145);
            this.lblPrijsDis.Name = "lblPrijsDis";
            this.lblPrijsDis.Size = new System.Drawing.Size(29, 13);
            this.lblPrijsDis.TabIndex = 4;
            this.lblPrijsDis.Text = "Prijs:";
            this.lblPrijsDis.Click += new System.EventHandler(this.LblPrijsDis_Click);
            // 
            // lblBtwDis
            // 
            this.lblBtwDis.AutoSize = true;
            this.lblBtwDis.Location = new System.Drawing.Point(12, 168);
            this.lblBtwDis.Name = "lblBtwDis";
            this.lblBtwDis.Size = new System.Drawing.Size(35, 13);
            this.lblBtwDis.TabIndex = 4;
            this.lblBtwDis.Text = "BTW:";
            this.lblBtwDis.Click += new System.EventHandler(this.LblBtwDis_Click);
            // 
            // lblTotaalPrijsDis
            // 
            this.lblTotaalPrijsDis.AutoSize = true;
            this.lblTotaalPrijsDis.Location = new System.Drawing.Point(12, 190);
            this.lblTotaalPrijsDis.Name = "lblTotaalPrijsDis";
            this.lblTotaalPrijsDis.Size = new System.Drawing.Size(58, 13);
            this.lblTotaalPrijsDis.TabIndex = 4;
            this.lblTotaalPrijsDis.Text = "Totaal prijs";
            this.lblTotaalPrijsDis.Click += new System.EventHandler(this.LblTotaalPrijsDis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 212);
            this.Controls.Add(this.lblTotaalPrijsDis);
            this.Controls.Add(this.lblBtwDis);
            this.Controls.Add(this.lblPrijsDis);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.lblGeefPrijs);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Opdracht 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblGeefPrijs;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblTotaalPrijs;
        private System.Windows.Forms.Label lblPrijsDis;
        private System.Windows.Forms.Label lblBtwDis;
        private System.Windows.Forms.Label lblTotaalPrijsDis;
    }
}

