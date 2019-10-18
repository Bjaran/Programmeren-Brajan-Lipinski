namespace Opdracht_5
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
            this.lbl_getal1 = new System.Windows.Forms.Label();
            this.txt_Getal_1 = new System.Windows.Forms.TextBox();
            this.txt_Getal_2 = new System.Windows.Forms.TextBox();
            this.lblgetal2 = new System.Windows.Forms.Label();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Keer = new System.Windows.Forms.Button();
            this.btn_Delen = new System.Windows.Forms.Button();
            this.lbl_Uitkomst = new System.Windows.Forms.Label();
            this.lbl_Uitkomst_Getal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_getal1
            // 
            this.lbl_getal1.AutoSize = true;
            this.lbl_getal1.Location = new System.Drawing.Point(12, 49);
            this.lbl_getal1.Name = "lbl_getal1";
            this.lbl_getal1.Size = new System.Drawing.Size(41, 13);
            this.lbl_getal1.TabIndex = 0;
            this.lbl_getal1.Text = "Getal 1";
            // 
            // txt_Getal_1
            // 
            this.txt_Getal_1.Location = new System.Drawing.Point(190, 46);
            this.txt_Getal_1.Name = "txt_Getal_1";
            this.txt_Getal_1.Size = new System.Drawing.Size(139, 20);
            this.txt_Getal_1.TabIndex = 1;
            // 
            // txt_Getal_2
            // 
            this.txt_Getal_2.Location = new System.Drawing.Point(190, 71);
            this.txt_Getal_2.Name = "txt_Getal_2";
            this.txt_Getal_2.Size = new System.Drawing.Size(139, 20);
            this.txt_Getal_2.TabIndex = 2;
            // 
            // lblgetal2
            // 
            this.lblgetal2.AutoSize = true;
            this.lblgetal2.Location = new System.Drawing.Point(12, 78);
            this.lblgetal2.Name = "lblgetal2";
            this.lblgetal2.Size = new System.Drawing.Size(41, 13);
            this.lblgetal2.TabIndex = 3;
            this.lblgetal2.Text = "Getal 2";
            // 
            // btn_Plus
            // 
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(15, 143);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(74, 66);
            this.btn_Plus.TabIndex = 4;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(95, 143);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(74, 66);
            this.btn_Min.TabIndex = 5;
            this.btn_Min.Text = "-";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Keer
            // 
            this.btn_Keer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Keer.Location = new System.Drawing.Point(175, 143);
            this.btn_Keer.Name = "btn_Keer";
            this.btn_Keer.Size = new System.Drawing.Size(74, 66);
            this.btn_Keer.TabIndex = 6;
            this.btn_Keer.Text = "X";
            this.btn_Keer.UseVisualStyleBackColor = true;
            this.btn_Keer.Click += new System.EventHandler(this.btn_Keer_Click);
            // 
            // btn_Delen
            // 
            this.btn_Delen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delen.Location = new System.Drawing.Point(255, 143);
            this.btn_Delen.Name = "btn_Delen";
            this.btn_Delen.Size = new System.Drawing.Size(74, 66);
            this.btn_Delen.TabIndex = 7;
            this.btn_Delen.Text = ":";
            this.btn_Delen.UseVisualStyleBackColor = true;
            this.btn_Delen.Click += new System.EventHandler(this.btn_Delen_Click);
            // 
            // lbl_Uitkomst
            // 
            this.lbl_Uitkomst.AutoSize = true;
            this.lbl_Uitkomst.Location = new System.Drawing.Point(12, 241);
            this.lbl_Uitkomst.Name = "lbl_Uitkomst";
            this.lbl_Uitkomst.Size = new System.Drawing.Size(48, 13);
            this.lbl_Uitkomst.TabIndex = 8;
            this.lbl_Uitkomst.Text = "Uitkomst";
            // 
            // lbl_Uitkomst_Getal
            // 
            this.lbl_Uitkomst_Getal.AutoSize = true;
            this.lbl_Uitkomst_Getal.Location = new System.Drawing.Point(148, 241);
            this.lbl_Uitkomst_Getal.Name = "lbl_Uitkomst_Getal";
            this.lbl_Uitkomst_Getal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Uitkomst_Getal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 273);
            this.Controls.Add(this.lbl_Uitkomst_Getal);
            this.Controls.Add(this.lbl_Uitkomst);
            this.Controls.Add(this.btn_Delen);
            this.Controls.Add(this.btn_Keer);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.lblgetal2);
            this.Controls.Add(this.txt_Getal_2);
            this.Controls.Add(this.txt_Getal_1);
            this.Controls.Add(this.lbl_getal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_getal1;
        private System.Windows.Forms.TextBox txt_Getal_1;
        private System.Windows.Forms.TextBox txt_Getal_2;
        private System.Windows.Forms.Label lblgetal2;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Keer;
        private System.Windows.Forms.Button btn_Delen;
        private System.Windows.Forms.Label lbl_Uitkomst;
        private System.Windows.Forms.Label lbl_Uitkomst_Getal;
    }
}

