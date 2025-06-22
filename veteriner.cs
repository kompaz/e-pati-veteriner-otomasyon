using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pati
{
    public partial class Vet : Form
    {
        public Vet()
        {
            InitializeComponent();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            vetGuncel vetGuncel = new vetGuncel();
            this.Hide();
            vetGuncel.Show();
        }

        private void btn_sorgu_Click(object sender, EventArgs e)
        {
            screenSorgula screenSorgula = new screenSorgula();
            this.Hide();
            screenSorgula.Show();
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            screenYeniEkle screenYeni = new screenYeniEkle();
            this.Hide();
            screenYeni.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyaır", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (ms == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
