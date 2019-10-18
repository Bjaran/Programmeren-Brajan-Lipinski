namespace Opdracht_6
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
            this.lblStartbedrag = new System.Windows.Forms.Label();
            this.txtStartBedrag = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblEindKapitaal = new System.Windows.Forms.Label();
            this.lblEindBedrag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStartbedrag
            // 
            this.lblStartbedrag.AutoSize = true;
            this.lblStartbedrag.Location = new System.Drawing.Point(23, 38);
            this.lblStartbedrag.Name = "lblStartbedrag";
            this.lblStartbedrag.Size = new System.Drawing.Size(62, 13);
            this.lblStartbedrag.TabIndex = 0;
            this.lblStartbedrag.Text = "Startbedrag";
            // 
            // txtStartBedrag
            // 
            this.txtStartBedrag.Location = new System.Drawing.Point(136, 38);
            this.txtStartBedrag.Name = "txtStartBedrag";
            this.txtStartBedrag.Size = new System.Drawing.Size(100, 20);
            this.txtStartBedrag.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(26, 88);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(210, 33);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken bedrag na 5 jaar met % 5 rente";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblEindKapitaal
            // 
            this.lblEindKapitaal.AutoSize = true;
            this.lblEindKapitaal.Location = new System.Drawing.Point(23, 140);
            this.lblEindKapitaal.Name = "lblEindKapitaal";
            this.lblEindKapitaal.Size = new System.Drawing.Size(65, 13);
            this.lblEindKapitaal.TabIndex = 3;
            this.lblEindKapitaal.Text = "Eindkapitaal";
            // 
            // lblEindBedrag
            // 
            this.lblEindBedrag.AutoSize = true;
            this.lblEindBedrag.Location = new System.Drawing.Point(175, 140);
            this.lblEindBedrag.Name = "lblEindBedrag";
            this.lblEindBedrag.Size = new System.Drawing.Size(0, 13);
            this.lblEindBedrag.TabIndex = 4;
            this.lblEindBedrag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 176);
            this.Controls.Add(this.lblEindBedrag);
            this.Controls.Add(this.lblEindKapitaal);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtStartBedrag);
            this.Controls.Add(this.lblStartbedrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartbedrag;
        private System.Windows.Forms.TextBox txtStartBedrag;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblEindKapitaal;
        private System.Windows.Forms.Label lblEindBedrag;
    }
}

