
namespace E_Pati
{
    partial class Vet
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.btn_sorgu = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(108, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.BackColor = System.Drawing.Color.White;
            this.btn_yeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yeni.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_yeni.Location = new System.Drawing.Point(108, 217);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(212, 58);
            this.btn_yeni.TabIndex = 3;
            this.btn_yeni.Text = "Yeni Evcil Hayvan";
            this.btn_yeni.UseVisualStyleBackColor = false;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // btn_sorgu
            // 
            this.btn_sorgu.BackColor = System.Drawing.Color.White;
            this.btn_sorgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorgu.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sorgu.Location = new System.Drawing.Point(108, 73);
            this.btn_sorgu.Name = "btn_sorgu";
            this.btn_sorgu.Size = new System.Drawing.Size(212, 58);
            this.btn_sorgu.TabIndex = 1;
            this.btn_sorgu.Text = "Evcil Hayvan Sorgula";
            this.btn_sorgu.UseVisualStyleBackColor = false;
            this.btn_sorgu.Click += new System.EventHandler(this.btn_sorgu_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guncelle.Location = new System.Drawing.Point(108, 145);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(212, 58);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Evcil Hayvan Bilgi Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // Vet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 403);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sorgu);
            this.Controls.Add(this.btn_yeni);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Vet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veteriner Ekranı";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_sorgu;
        private System.Windows.Forms.Button btn_guncelle;
    }
}