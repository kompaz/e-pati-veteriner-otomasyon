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
    public partial class screenSorgula : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=desktop-7ch6a9v;Initial Catalog=ePati;Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public screenSorgula()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyaır", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (ms == DialogResult.Yes)
            {
                Vet vet = new Vet();
                this.Close();
                vet.Show();
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            
            DialogResult sonuc;
            sonuc = MessageBox.Show("Girdiğiniz Id doğruluğundan emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                btn_cikis.Visible = false;
                panel_info.Visible = true;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM e_Pati WHERE evcilHayvanID = @evcilHayvanID", sqlConnection);

                command.Parameters.AddWithValue("@evcilHayvanID", textBox1.Text);
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                btn_listele.Enabled = true;
        }

        private void screenSorgula_Load(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyaır", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (ms == DialogResult.Yes)
            {
                Vet vet = new Vet();
                this.Close();
                vet.Show();
            }
        }
    }
}
