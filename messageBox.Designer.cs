
namespace E_Pati
{
    partial class messageBox
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
            this.lbl_warning = new System.Windows.Forms.Label();
            this.btn_evet = new System.Windows.Forms.Button();
            this.btn_hyr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Modern No. 20", 12.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_warning.Location = new System.Drawing.Point(29, 39);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(383, 21);
            this.lbl_warning.TabIndex = 0;
            this.lbl_warning.Text = "Bilgileri güncellemek istediğinizden emin misiniz?";
            // 
            // btn_evet
            // 
            this.btn_evet.BackColor = System.Drawing.Color.White;
            this.btn_evet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_evet.Font = new System.Drawing.Font("Modern No. 20", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_evet.Location = new System.Drawing.Point(91, 90);
            this.btn_evet.Name = "btn_evet";
            this.btn_evet.Size = new System.Drawing.Size(88, 25);
            this.btn_evet.TabIndex = 1;
            this.btn_evet.Text = "Evet";
            this.btn_evet.UseVisualStyleBackColor = false;
            this.btn_evet.Click += new System.EventHandler(this.btn_evet_Click);
            // 
            // btn_hyr
            // 
            this.btn_hyr.BackColor = System.Drawing.Color.White;
            this.btn_hyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hyr.Font = new System.Drawing.Font("Modern No. 20", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hyr.Location = new System.Drawing.Point(260, 90);
            this.btn_hyr.Name = "btn_hyr";
            this.btn_hyr.Size = new System.Drawing.Size(83, 25);
            this.btn_hyr.TabIndex = 2;
            this.btn_hyr.Text = "Hayır";
            this.btn_hyr.UseVisualStyleBackColor = false;
            // 
            // messageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 140);
            this.Controls.Add(this.btn_hyr);
            this.Controls.Add(this.btn_evet);
            this.Controls.Add(this.lbl_warning);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "messageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uyarı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button btn_evet;
        private System.Windows.Forms.Button btn_hyr;
    }
}