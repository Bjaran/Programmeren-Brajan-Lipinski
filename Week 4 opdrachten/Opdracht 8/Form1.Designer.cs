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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.btnVergelijk = new System.Windows.Forms.Button();
            this.lblSom1 = new System.Windows.Forms.Label();
            this.lblSom2 = new System.Windows.Forms.Label();
            this.lblUitslag1 = new System.Windows.Forms.Label();
            this.lblUitslag2 = new System.Windows.Forms.Label();
            this.lblGelijk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een getal(n)";
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(131, 24);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(114, 20);
            this.txtGetal.TabIndex = 1;
            // 
            // btnVergelijk
            // 
            this.btnVergelijk.Location = new System.Drawing.Point(15, 73);
            this.btnVergelijk.Name = "btnVergelijk";
            this.btnVergelijk.Size = new System.Drawing.Size(230, 23);
            this.btnVergelijk.TabIndex = 2;
            this.btnVergelijk.Text = "Vergelijk";
            this.btnVergelijk.UseVisualStyleBackColor = true;
            this.btnVergelijk.Click += new System.EventHandler(this.BtnVergelijk_Click);
            // 
            // lblSom1
            // 
            this.lblSom1.AutoSize = true;
            this.lblSom1.Location = new System.Drawing.Point(15, 127);
            this.lblSom1.Name = "lblSom1";
            this.lblSom1.Size = new System.Drawing.Size(122, 13);
            this.lblSom1.TabIndex = 3;
            this.lblSom1.Text = "som = 0 + 1 + 2 + .... + n";
            // 
            // lblSom2
            // 
            this.lblSom2.AutoSize = true;
            this.lblSom2.Location = new System.Drawing.Point(12, 164);
            this.lblSom2.Name = "lblSom2";
            this.lblSom2.Size = new System.Drawing.Size(103, 13);
            this.lblSom2.TabIndex = 4;
            this.lblSom2.Text = "som = n × (n + 1) / 2";
            // 
            // lblUitslag1
            // 
            this.lblUitslag1.AutoSize = true;
            this.lblUitslag1.Location = new System.Drawing.Point(200, 127);
            this.lblUitslag1.Name = "lblUitslag1";
            this.lblUitslag1.Size = new System.Drawing.Size(0, 13);
            this.lblUitslag1.TabIndex = 5;
            // 
            // lblUitslag2
            // 
            this.lblUitslag2.AutoSize = true;
            this.lblUitslag2.Location = new System.Drawing.Point(200, 164);
            this.lblUitslag2.Name = "lblUitslag2";
            this.lblUitslag2.Size = new System.Drawing.Size(0, 13);
            this.lblUitslag2.TabIndex = 6;
            // 
            // lblGelijk
            // 
            this.lblGelijk.AutoSize = true;
            this.lblGelijk.Location = new System.Drawing.Point(15, 199);
            this.lblGelijk.Name = "lblGelijk";
            this.lblGelijk.Size = new System.Drawing.Size(0, 13);
            this.lblGelijk.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 221);
            this.Controls.Add(this.lblGelijk);
            this.Controls.Add(this.lblUitslag2);
            this.Controls.Add(this.lblUitslag1);
            this.Controls.Add(this.lblSom2);
            this.Controls.Add(this.lblSom1);
            this.Controls.Add(this.btnVergelijk);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Button btnVergelijk;
        private System.Windows.Forms.Label lblSom1;
        private System.Windows.Forms.Label lblSom2;
        private System.Windows.Forms.Label lblUitslag1;
        private System.Windows.Forms.Label lblUitslag2;
        private System.Windows.Forms.Label lblGelijk;
    }
}

