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
            this.lblGraden = new System.Windows.Forms.Label();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.lblOmrekenen = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblNGraden = new System.Windows.Forms.Label();
            this.lblNieuweGraden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGraden
            // 
            this.lblGraden.AutoSize = true;
            this.lblGraden.Location = new System.Drawing.Point(23, 40);
            this.lblGraden.Name = "lblGraden";
            this.lblGraden.Size = new System.Drawing.Size(42, 13);
            this.lblGraden.TabIndex = 0;
            this.lblGraden.Text = "Graden";
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(141, 37);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(100, 20);
            this.txtGetal.TabIndex = 1;
            // 
            // lblOmrekenen
            // 
            this.lblOmrekenen.AutoSize = true;
            this.lblOmrekenen.Location = new System.Drawing.Point(23, 93);
            this.lblOmrekenen.Name = "lblOmrekenen";
            this.lblOmrekenen.Size = new System.Drawing.Size(62, 13);
            this.lblOmrekenen.TabIndex = 2;
            this.lblOmrekenen.Text = "Omrekenen";
            this.lblOmrekenen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 131);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "van Celcius naar Kelvin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(58, 154);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "van Celcius naar Farenheit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(58, 177);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "van Farenheit naar Celcius";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(58, 214);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(183, 23);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblNGraden
            // 
            this.lblNGraden.AutoSize = true;
            this.lblNGraden.Location = new System.Drawing.Point(23, 249);
            this.lblNGraden.Name = "lblNGraden";
            this.lblNGraden.Size = new System.Drawing.Size(79, 13);
            this.lblNGraden.TabIndex = 7;
            this.lblNGraden.Text = "Nieuwe graden";
            this.lblNGraden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNieuweGraden
            // 
            this.lblNieuweGraden.AutoSize = true;
            this.lblNieuweGraden.Location = new System.Drawing.Point(117, 249);
            this.lblNieuweGraden.Name = "lblNieuweGraden";
            this.lblNieuweGraden.Size = new System.Drawing.Size(0, 13);
            this.lblNieuweGraden.TabIndex = 8;
            this.lblNieuweGraden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 278);
            this.Controls.Add(this.lblNieuweGraden);
            this.Controls.Add(this.lblNGraden);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblOmrekenen);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.lblGraden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGraden;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Label lblOmrekenen;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblNGraden;
        private System.Windows.Forms.Label lblNieuweGraden;
    }
}

