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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tabelVoor = new System.Windows.Forms.Label();
            this.lbl_tableNa = new System.Windows.Forms.Label();
            this.lbl_vergelijkingsgetal = new System.Windows.Forms.Label();
            this.txt_getal = new System.Windows.Forms.TextBox();
            this.btn_vergelijk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inhoud tabel (vooraf)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhoud tabel (achteraf)";
            // 
            // lbl_tabelVoor
            // 
            this.lbl_tabelVoor.AutoSize = true;
            this.lbl_tabelVoor.Location = new System.Drawing.Point(16, 52);
            this.lbl_tabelVoor.Name = "lbl_tabelVoor";
            this.lbl_tabelVoor.Size = new System.Drawing.Size(0, 13);
            this.lbl_tabelVoor.TabIndex = 2;
            // 
            // lbl_tableNa
            // 
            this.lbl_tableNa.AutoSize = true;
            this.lbl_tableNa.Location = new System.Drawing.Point(271, 52);
            this.lbl_tableNa.Name = "lbl_tableNa";
            this.lbl_tableNa.Size = new System.Drawing.Size(0, 13);
            this.lbl_tableNa.TabIndex = 41;
            // 
            // lbl_vergelijkingsgetal
            // 
            this.lbl_vergelijkingsgetal.AutoSize = true;
            this.lbl_vergelijkingsgetal.Location = new System.Drawing.Point(19, 342);
            this.lbl_vergelijkingsgetal.Name = "lbl_vergelijkingsgetal";
            this.lbl_vergelijkingsgetal.Size = new System.Drawing.Size(89, 13);
            this.lbl_vergelijkingsgetal.TabIndex = 42;
            this.lbl_vergelijkingsgetal.Text = "Vergelijkingsgetal";
            // 
            // txt_getal
            // 
            this.txt_getal.Location = new System.Drawing.Point(225, 339);
            this.txt_getal.Name = "txt_getal";
            this.txt_getal.Size = new System.Drawing.Size(100, 20);
            this.txt_getal.TabIndex = 43;
            this.txt_getal.TextChanged += new System.EventHandler(this.txt_getal_TextChanged);
            // 
            // btn_vergelijk
            // 
            this.btn_vergelijk.Location = new System.Drawing.Point(353, 339);
            this.btn_vergelijk.Name = "btn_vergelijk";
            this.btn_vergelijk.Size = new System.Drawing.Size(75, 23);
            this.btn_vergelijk.TabIndex = 44;
            this.btn_vergelijk.Text = "Vergelijk";
            this.btn_vergelijk.UseVisualStyleBackColor = true;
            this.btn_vergelijk.Click += new System.EventHandler(this.btn_vergelijk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 367);
            this.Controls.Add(this.btn_vergelijk);
            this.Controls.Add(this.txt_getal);
            this.Controls.Add(this.lbl_vergelijkingsgetal);
            this.Controls.Add(this.lbl_tableNa);
            this.Controls.Add(this.lbl_tabelVoor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tabelVoor;
        private System.Windows.Forms.Label lbl_tableNa;
        private System.Windows.Forms.Label lbl_vergelijkingsgetal;
        private System.Windows.Forms.TextBox txt_getal;
        private System.Windows.Forms.Button btn_vergelijk;
    }
}

