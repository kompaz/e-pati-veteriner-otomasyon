
namespace E_Pati
{
    partial class giris_ekrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ePati = new System.Windows.Forms.Label();
            this.btn_petOwner = new System.Windows.Forms.Button();
            this.btn_vetGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ePati
            // 
            this.lbl_ePati.AutoSize = true;
            this.lbl_ePati.Font = new System.Drawing.Font("Modern No. 20", 59.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ePati.ForeColor = System.Drawing.Color.Navy;
            this.lbl_ePati.Location = new System.Drawing.Point(42, 65);
            this.lbl_ePati.Name = "lbl_ePati";
            this.lbl_ePati.Size = new System.Drawing.Size(504, 90);
            this.lbl_ePati.TabIndex = 0;
            this.lbl_ePati.Text = "E - PATI 🐾";
            // 
            // btn_petOwner
            // 
            this.btn_petOwner.BackColor = System.Drawing.Color.White;
            this.btn_petOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petOwner.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_petOwner.ForeColor = System.Drawing.Color.Navy;
            this.btn_petOwner.Location = new System.Drawing.Point(345, 227);
            this.btn_petOwner.Name = "btn_petOwner";
            this.btn_petOwner.Size = new System.Drawing.Size(149, 65);
            this.btn_petOwner.TabIndex = 2;
            this.btn_petOwner.Text = "Evcil Hayvan Sahibi";
            this.btn_petOwner.UseVisualStyleBackColor = false;
            this.btn_petOwner.Click += new System.EventHandler(this.btn_petOwner_Click);
            // 
            // btn_vetGiris
            // 
            this.btn_vetGiris.BackColor = System.Drawing.Color.White;
            this.btn_vetGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vetGiris.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_vetGiris.ForeColor = System.Drawing.Color.Navy;
            this.btn_vetGiris.Location = new System.Drawing.Point(88, 227);
            this.btn_vetGiris.Name = "btn_vetGiris";
            this.btn_vetGiris.Size = new System.Drawing.Size(149, 65);
            this.btn_vetGiris.TabIndex = 1;
            this.btn_vetGiris.Text = "Veteriner";
            this.btn_vetGiris.UseVisualStyleBackColor = false;
            this.btn_vetGiris.Click += new System.EventHandler(this.btn_vetGiris_Click);
            // 
            // giris_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 357);
            this.Controls.Add(this.btn_vetGiris);
            this.Controls.Add(this.btn_petOwner);
            this.Controls.Add(this.lbl_ePati);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "giris_ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E - PATI";
            this.Load += new System.EventHandler(this.giris_ekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ePati;
        private System.Windows.Forms.Button btn_petOwner;
        private System.Windows.Forms.Button btn_vetGiris;
    }
}

