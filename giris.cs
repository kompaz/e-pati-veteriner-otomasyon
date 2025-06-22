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
    public partial class giris_ekrani : Form
    {
        public giris_ekrani()
        {
            InitializeComponent();
        }

        private void btn_petOwner_Click(object sender, EventArgs e)
        {
            InfoScreenOwner infoScreenOwner = new InfoScreenOwner();
            this.Hide();
            infoScreenOwner.Show();
        }

        private void btn_vetGiris_Click(object sender, EventArgs e)
        {
            Vet Vet = new Vet();
            this.Hide();
            Vet.Show();
        }

        private void giris_ekrani_Load(object sender, EventArgs e)
        {
            //btn_vetGiris.FlatStyle = FlatStyle.Flat;
            //btn_vetGiris.FlatAppearance.BorderSize = 0;

            //btn_petOwner.FlatStyle = FlatStyle.Flat;
            //btn_petOwner.FlatAppearance.BorderSize = 0;

            //this.BackColor = Color.FromArgb(222, 236, 255);
            //btn_petOwner.BackColor = Color.FromArgb(243, 248, 255);
            //btn_vetGiris.BackColor = Color.FromArgb(243, 248, 255);
            //btn_vetGiris.ForeColor = Color.FromArgb(198, 207, 255);
            //btn_petOwner.ForeColor = Color.FromArgb(198, 207, 255);

        }
    }
}
