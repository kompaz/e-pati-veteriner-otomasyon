using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Pati
{
    public partial class InfoScreenOwner : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=desktop-7ch6a9v;Initial Catalog=ePati;Integrated Security=True");
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public InfoScreenOwner()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txb_petId.TextLength > 0)
                btn_listele.Enabled = true;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {

            if (txb_petId.TextLength != 0 && txb_tc.TextLength != 0)
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("Girdiğiniz Id ve kimlik numarası doğruluğundan emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    btn_cikis.Visible = false;
                    panel_info.Visible = true;
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM e_Pati WHERE evcilHayvanID = @evcilHayvanID AND hayvanSahibiTC = @hayvanSahibiTC", sqlConnection);

                    command.Parameters.AddWithValue("@evcilHayvanID", txb_petId.Text);
                    command.Parameters.AddWithValue("@hayvanSahibiTC", txb_tc.Text);
                    command.CommandType = CommandType.Text;

                    SqlDataReader dataReader = command.ExecuteReader();

                    dataReader.Read();

                    lbl_cvp_petName.Text = dataReader["evcilHayvanAdı"].ToString();
                    lbl_cvp_irk.Text = dataReader["evcilHayvanIRkı"].ToString();
                    lbl_cvp_cinsiyet.Text = dataReader["evcilHayvanCinsiyet"].ToString();
                    lbl_cvp_ownerName.Text = dataReader["hayvanSahibiAdı"].ToString();
                    lbl_cvp_ownerNumber.Text = dataReader["hayvanSahibiTelefonNo"].ToString();
                    lbl_cvp_vetName.Text = dataReader["veterinerAdı"].ToString();
                    lbl_cvp_vetNo.Text = dataReader["veterinerTelNo"].ToString();
                    lbl_cvp_petDiseases.Text = dataReader["hayvanHastalıkları"].ToString();

                    sqlConnection.Close();
                }
                else if (sonuc == DialogResult.No)
                {
                    MessageBox.Show("Tekrar ID Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Eksik veya Yanlış Bilgi Girdiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyaır", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            //if (ms == DialogResult.Yes)
            //{
            Application.Exit();
            //}

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyaır", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (ms == DialogResult.Yes)
            {
                giris_ekrani giris = new giris_ekrani();
                this.Close();
                giris.Show();
            }
        }
    }
}
