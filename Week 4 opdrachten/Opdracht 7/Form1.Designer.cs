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
            this.lblZijde = new System.Windows.Forms.Label();
            this.txtZijde = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblVierkant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZijde
            // 
            this.lblZijde.AutoSize = true;
            this.lblZijde.Location = new System.Drawing.Point(13, 22);
            this.lblZijde.Name = "lblZijde";
            this.lblZijde.Size = new System.Drawing.Size(30, 13);
            this.lblZijde.TabIndex = 0;
            this.lblZijde.Text = "Zijde";
            // 
            // txtZijde
            // 
            this.txtZijde.Location = new System.Drawing.Point(118, 22);
            this.txtZijde.Name = "txtZijde";
            this.txtZijde.Size = new System.Drawing.Size(100, 20);
            this.txtZijde.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(16, 59);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(202, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Maak vierkant";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblVierkant
            // 
            this.lblVierkant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVierkant.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVierkant.Location = new System.Drawing.Point(0, 85);
            this.lblVierkant.Name = "lblVierkant";
            this.lblVierkant.Size = new System.Drawing.Size(240, 203);
            this.lblVierkant.TabIndex = 3;
            this.lblVierkant.Text = "X";
            this.lblVierkant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 288);
            this.Controls.Add(this.lblVierkant);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtZijde);
            this.Controls.Add(this.lblZijde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZijde;
        private System.Windows.Forms.TextBox txtZijde;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblVierkant;
    }
}

