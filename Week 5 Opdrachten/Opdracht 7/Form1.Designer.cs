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
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_gooien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(25, 40);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(0, 13);
            this.lbl_text.TabIndex = 0;
            // 
            // btn_gooien
            // 
            this.btn_gooien.Location = new System.Drawing.Point(28, 161);
            this.btn_gooien.Name = "btn_gooien";
            this.btn_gooien.Size = new System.Drawing.Size(203, 23);
            this.btn_gooien.TabIndex = 1;
            this.btn_gooien.Text = "Gooien";
            this.btn_gooien.UseVisualStyleBackColor = true;
            this.btn_gooien.Click += new System.EventHandler(this.btn_gooien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 196);
            this.Controls.Add(this.btn_gooien);
            this.Controls.Add(this.lbl_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_gooien;
    }
}

