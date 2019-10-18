namespace Opdracht_7
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
            this.lblBeginKm = new System.Windows.Forms.Label();
            this.lblEindKm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeginKm = new System.Windows.Forms.TextBox();
            this.txtEindKm = new System.Windows.Forms.TextBox();
            this.txtPrijsPerKm = new System.Windows.Forms.TextBox();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnBedragen = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblPrijsExclBtw = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblPrijsInclBtw = new System.Windows.Forms.Label();
            this.lblPrijsExclBtwShow = new System.Windows.Forms.Label();
            this.lblBtwShow = new System.Windows.Forms.Label();
            this.lblPrijsInclBtwShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBeginKm
            // 
            this.lblBeginKm.AutoSize = true;
            this.lblBeginKm.Location = new System.Drawing.Point(13, 27);
            this.lblBeginKm.Name = "lblBeginKm";
            this.lblBeginKm.Size = new System.Drawing.Size(53, 13);
            this.lblBeginKm.TabIndex = 0;
            this.lblBeginKm.Text = "Begin KM";
            // 
            // lblEindKm
            // 
            this.lblEindKm.AutoSize = true;
            this.lblEindKm.Location = new System.Drawing.Point(13, 64);
            this.lblEindKm.Name = "lblEindKm";
            this.lblEindKm.Size = new System.Drawing.Size(47, 13);
            this.lblEindKm.TabIndex = 1;
            this.lblEindKm.Text = "Eind KM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prijs per KM";
            // 
            // txtBeginKm
            // 
            this.txtBeginKm.Location = new System.Drawing.Point(139, 24);
            this.txtBeginKm.Name = "txtBeginKm";
            this.txtBeginKm.Size = new System.Drawing.Size(100, 20);
            this.txtBeginKm.TabIndex = 3;
            this.txtBeginKm.TextChanged += new System.EventHandler(this.TxtBeginKm_TextChanged);
            // 
            // txtEindKm
            // 
            this.txtEindKm.Location = new System.Drawing.Point(139, 61);
            this.txtEindKm.Name = "txtEindKm";
            this.txtEindKm.Size = new System.Drawing.Size(100, 20);
            this.txtEindKm.TabIndex = 4;
            // 
            // txtPrijsPerKm
            // 
            this.txtPrijsPerKm.Location = new System.Drawing.Point(139, 96);
            this.txtPrijsPerKm.Name = "txtPrijsPerKm";
            this.txtPrijsPerKm.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsPerKm.TabIndex = 5;
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(263, 24);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 6;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // btnBedragen
            // 
            this.btnBedragen.Location = new System.Drawing.Point(263, 94);
            this.btnBedragen.Name = "btnBedragen";
            this.btnBedragen.Size = new System.Drawing.Size(75, 23);
            this.btnBedragen.TabIndex = 7;
            this.btnBedragen.Text = "Bedragen";
            this.btnBedragen.UseVisualStyleBackColor = true;
            this.btnBedragen.Click += new System.EventHandler(this.BtnBedragen_Click);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(0, 170);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(349, 13);
            this.lblLine.TabIndex = 8;
            this.lblLine.Text = "_________________________________________________________";
            // 
            // lblPrijsExclBtw
            // 
            this.lblPrijsExclBtw.AutoSize = true;
            this.lblPrijsExclBtw.Location = new System.Drawing.Point(12, 157);
            this.lblPrijsExclBtw.Name = "lblPrijsExclBtw";
            this.lblPrijsExclBtw.Size = new System.Drawing.Size(79, 13);
            this.lblPrijsExclBtw.TabIndex = 9;
            this.lblPrijsExclBtw.Text = "Prijs excl. BTW";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(139, 157);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(32, 13);
            this.lblBtw.TabIndex = 10;
            this.lblBtw.Text = "BTW";
            // 
            // lblPrijsInclBtw
            // 
            this.lblPrijsInclBtw.AutoSize = true;
            this.lblPrijsInclBtw.Location = new System.Drawing.Point(260, 157);
            this.lblPrijsInclBtw.Name = "lblPrijsInclBtw";
            this.lblPrijsInclBtw.Size = new System.Drawing.Size(76, 13);
            this.lblPrijsInclBtw.TabIndex = 11;
            this.lblPrijsInclBtw.Text = "Prijs incl. BTW";
            // 
            // lblPrijsExclBtwShow
            // 
            this.lblPrijsExclBtwShow.AutoSize = true;
            this.lblPrijsExclBtwShow.Location = new System.Drawing.Point(13, 206);
            this.lblPrijsExclBtwShow.Name = "lblPrijsExclBtwShow";
            this.lblPrijsExclBtwShow.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsExclBtwShow.TabIndex = 12;
            // 
            // lblBtwShow
            // 
            this.lblBtwShow.AutoSize = true;
            this.lblBtwShow.Location = new System.Drawing.Point(136, 206);
            this.lblBtwShow.Name = "lblBtwShow";
            this.lblBtwShow.Size = new System.Drawing.Size(0, 13);
            this.lblBtwShow.TabIndex = 13;
            // 
            // lblPrijsInclBtwShow
            // 
            this.lblPrijsInclBtwShow.AutoSize = true;
            this.lblPrijsInclBtwShow.Location = new System.Drawing.Point(260, 206);
            this.lblPrijsInclBtwShow.Name = "lblPrijsInclBtwShow";
            this.lblPrijsInclBtwShow.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsInclBtwShow.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 242);
            this.Controls.Add(this.lblPrijsInclBtwShow);
            this.Controls.Add(this.lblBtwShow);
            this.Controls.Add(this.lblPrijsExclBtwShow);
            this.Controls.Add(this.lblPrijsInclBtw);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblPrijsExclBtw);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnBedragen);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.txtPrijsPerKm);
            this.Controls.Add(this.txtEindKm);
            this.Controls.Add(this.txtBeginKm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEindKm);
            this.Controls.Add(this.lblBeginKm);
            this.Name = "Form1";
            this.Text = "Opdracht 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeginKm;
        private System.Windows.Forms.Label lblEindKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeginKm;
        private System.Windows.Forms.TextBox txtEindKm;
        private System.Windows.Forms.TextBox txtPrijsPerKm;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnBedragen;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblPrijsExclBtw;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblPrijsInclBtw;
        private System.Windows.Forms.Label lblPrijsExclBtwShow;
        private System.Windows.Forms.Label lblBtwShow;
        private System.Windows.Forms.Label lblPrijsInclBtwShow;
    }
}

