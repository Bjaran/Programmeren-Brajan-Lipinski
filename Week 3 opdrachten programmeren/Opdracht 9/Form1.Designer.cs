namespace Opdracht_9
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
            this.rdVoetbal = new System.Windows.Forms.RadioButton();
            this.rdHandbal = new System.Windows.Forms.RadioButton();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lblDuur = new System.Windows.Forms.Label();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.txtDuur = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblContributie = new System.Windows.Forms.Label();
            this.lblContributieShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdVoetbal
            // 
            this.rdVoetbal.AutoSize = true;
            this.rdVoetbal.Location = new System.Drawing.Point(100, 46);
            this.rdVoetbal.Name = "rdVoetbal";
            this.rdVoetbal.Size = new System.Drawing.Size(61, 17);
            this.rdVoetbal.TabIndex = 0;
            this.rdVoetbal.TabStop = true;
            this.rdVoetbal.Text = "Voetbal";
            this.rdVoetbal.UseVisualStyleBackColor = true;
            this.rdVoetbal.CheckedChanged += new System.EventHandler(this.RdVoetbal_CheckedChanged);
            // 
            // rdHandbal
            // 
            this.rdHandbal.AutoSize = true;
            this.rdHandbal.Location = new System.Drawing.Point(100, 69);
            this.rdHandbal.Name = "rdHandbal";
            this.rdHandbal.Size = new System.Drawing.Size(65, 17);
            this.rdHandbal.TabIndex = 1;
            this.rdHandbal.TabStop = true;
            this.rdHandbal.Text = "Handbal";
            this.rdHandbal.UseVisualStyleBackColor = true;
            this.rdHandbal.CheckedChanged += new System.EventHandler(this.RdHandbal_CheckedChanged);
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(24, 46);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(55, 13);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sportsoort";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(24, 114);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.lblLeeftijd.TabIndex = 3;
            this.lblLeeftijd.Text = "Leeftijd";
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Location = new System.Drawing.Point(24, 155);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(95, 13);
            this.lblDuur.TabIndex = 4;
            this.lblDuur.Text = "Duur lidmaatschap";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(120, 107);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 5;
            // 
            // txtDuur
            // 
            this.txtDuur.Location = new System.Drawing.Point(120, 152);
            this.txtDuur.Name = "txtDuur";
            this.txtDuur.Size = new System.Drawing.Size(100, 20);
            this.txtDuur.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(27, 201);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(178, 30);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken Contributie";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblContributie
            // 
            this.lblContributie.AutoSize = true;
            this.lblContributie.Location = new System.Drawing.Point(24, 253);
            this.lblContributie.Name = "lblContributie";
            this.lblContributie.Size = new System.Drawing.Size(110, 13);
            this.lblContributie.TabIndex = 8;
            this.lblContributie.Text = "Te betalen contributie";
            // 
            // lblContributieShow
            // 
            this.lblContributieShow.AutoSize = true;
            this.lblContributieShow.Location = new System.Drawing.Point(178, 253);
            this.lblContributieShow.Name = "lblContributieShow";
            this.lblContributieShow.Size = new System.Drawing.Size(0, 13);
            this.lblContributieShow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 285);
            this.Controls.Add(this.lblContributieShow);
            this.Controls.Add(this.lblContributie);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtDuur);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.lblDuur);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.rdHandbal);
            this.Controls.Add(this.rdVoetbal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdVoetbal;
        private System.Windows.Forms.RadioButton rdHandbal;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Label lblDuur;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.TextBox txtDuur;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblContributie;
        private System.Windows.Forms.Label lblContributieShow;
    }
}

