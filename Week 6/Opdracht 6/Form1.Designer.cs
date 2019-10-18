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
            this.lblGetal = new System.Windows.Forms.Label();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.btnBerekenReference = new System.Windows.Forms.Button();
            this.btnBerekenReferenceOut = new System.Windows.Forms.Button();
            this.btnBerekenValue = new System.Windows.Forms.Button();
            this.lbl_uitkomst = new System.Windows.Forms.Label();
            this.lbl_Uitkomst_Getal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(13, 29);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(32, 13);
            this.lblGetal.TabIndex = 0;
            this.lblGetal.Text = "Getal";
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(119, 29);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(147, 20);
            this.txtGetal.TabIndex = 1;
            // 
            // btnBerekenReference
            // 
            this.btnBerekenReference.Location = new System.Drawing.Point(16, 103);
            this.btnBerekenReference.Name = "btnBerekenReference";
            this.btnBerekenReference.Size = new System.Drawing.Size(266, 40);
            this.btnBerekenReference.TabIndex = 2;
            this.btnBerekenReference.Text = "Bereken kwadraad by Reference (REF)";
            this.btnBerekenReference.UseVisualStyleBackColor = true;
            this.btnBerekenReference.Click += new System.EventHandler(this.btnBerekenReference_Click);
            // 
            // btnBerekenReferenceOut
            // 
            this.btnBerekenReferenceOut.Location = new System.Drawing.Point(16, 149);
            this.btnBerekenReferenceOut.Name = "btnBerekenReferenceOut";
            this.btnBerekenReferenceOut.Size = new System.Drawing.Size(266, 40);
            this.btnBerekenReferenceOut.TabIndex = 3;
            this.btnBerekenReferenceOut.Text = "Bereken kwadraad by Reference (OUT)";
            this.btnBerekenReferenceOut.UseVisualStyleBackColor = true;
            this.btnBerekenReferenceOut.Click += new System.EventHandler(this.btnBerekenReferenceOut_Click);
            // 
            // btnBerekenValue
            // 
            this.btnBerekenValue.Location = new System.Drawing.Point(16, 195);
            this.btnBerekenValue.Name = "btnBerekenValue";
            this.btnBerekenValue.Size = new System.Drawing.Size(266, 40);
            this.btnBerekenValue.TabIndex = 4;
            this.btnBerekenValue.Text = "Bereken kwadraad by Value";
            this.btnBerekenValue.UseVisualStyleBackColor = true;
            this.btnBerekenValue.Click += new System.EventHandler(this.btnBerekenValue_Click);
            // 
            // lbl_uitkomst
            // 
            this.lbl_uitkomst.AutoSize = true;
            this.lbl_uitkomst.Location = new System.Drawing.Point(13, 268);
            this.lbl_uitkomst.Name = "lbl_uitkomst";
            this.lbl_uitkomst.Size = new System.Drawing.Size(48, 13);
            this.lbl_uitkomst.TabIndex = 5;
            this.lbl_uitkomst.Text = "Uitkomst";
            // 
            // lbl_Uitkomst_Getal
            // 
            this.lbl_Uitkomst_Getal.AutoSize = true;
            this.lbl_Uitkomst_Getal.Location = new System.Drawing.Point(116, 268);
            this.lbl_Uitkomst_Getal.Name = "lbl_Uitkomst_Getal";
            this.lbl_Uitkomst_Getal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Uitkomst_Getal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 290);
            this.Controls.Add(this.lbl_Uitkomst_Getal);
            this.Controls.Add(this.lbl_uitkomst);
            this.Controls.Add(this.btnBerekenValue);
            this.Controls.Add(this.btnBerekenReferenceOut);
            this.Controls.Add(this.btnBerekenReference);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.lblGetal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Button btnBerekenReference;
        private System.Windows.Forms.Button btnBerekenReferenceOut;
        private System.Windows.Forms.Button btnBerekenValue;
        private System.Windows.Forms.Label lbl_uitkomst;
        private System.Windows.Forms.Label lbl_Uitkomst_Getal;
    }
}

