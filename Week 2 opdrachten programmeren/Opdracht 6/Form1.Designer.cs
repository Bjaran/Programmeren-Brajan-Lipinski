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
            this.lblSeconden = new System.Windows.Forms.Label();
            this.txtSeconden = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblTijd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeconden
            // 
            this.lblSeconden.AutoSize = true;
            this.lblSeconden.Location = new System.Drawing.Point(12, 22);
            this.lblSeconden.Name = "lblSeconden";
            this.lblSeconden.Size = new System.Drawing.Size(62, 13);
            this.lblSeconden.TabIndex = 0;
            this.lblSeconden.Text = "Seconden: ";
            // 
            // txtSeconden
            // 
            this.txtSeconden.Location = new System.Drawing.Point(90, 19);
            this.txtSeconden.Name = "txtSeconden";
            this.txtSeconden.Size = new System.Drawing.Size(100, 20);
            this.txtSeconden.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(15, 73);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(175, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken tijd";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(15, 134);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(130, 13);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "uren : minuten : seconden";
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Location = new System.Drawing.Point(15, 174);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(0, 13);
            this.lblTijd.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 201);
            this.Controls.Add(this.lblTijd);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtSeconden);
            this.Controls.Add(this.lblSeconden);
            this.Name = "Form1";
            this.Text = "Opdracht 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeconden;
        private System.Windows.Forms.TextBox txtSeconden;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblTijd;
    }
}

