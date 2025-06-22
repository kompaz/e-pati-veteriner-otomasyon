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
    public partial class vetGuncel : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=desktop-7ch6a9v;Initial Catalog=ePati;Integrated Security=True");
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public vetGuncel()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyaır", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (ms == DialogResult.Yes)
            {
                Vet vet = new Vet();
                this.Close();
                vet.Show();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            DialogResult message = MessageBox.Show("Bilgileri silemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (message == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM e_Pati WHERE evcilHayvanID = @evcilHayvanID";
                sqlCommand = new SqlCommand(sorgu, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@evcilHayvanID", tbx_petNameID.Text);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                tbx_petNameID.Text = "";
                MessageBox.Show("Evcil Hayvan Kaydı Başarıyla Silindi!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bilgileri güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (message == DialogResult.Yes)
            {
                sqlConnection.Open();

                string sorgu = "UPDATE e_Pati SET evcilHayvanID = @evcilHayvanID," +
                "evcilHayvanAdı =@evcilHayvanAdı, evcilHayvanIRkı = @evcilHayvanIRkı, evcilHayvanCinsiyet = @evcilHayvanCinsiyet," +
                "hayvanSahibiAdı = @hayvanSahibiAdı, hayvanSahibiTelefonNo = @hayvanSahibiTelefonNo," +
                "veterinerAdı = @veterinerAdı, veterinerTelNo = @veterinerTelNo," +
                "hayvanHastalıkları = @hayvanHastalıkları";

                sqlCommand = new SqlCommand(sorgu, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@evcilHayvanID", tbx_petNameID.Text);
                sqlCommand.Parameters.AddWithValue("@evcilHayvanAdı", txb_petName.Text);
                sqlCommand.Parameters.AddWithValue("@evcilHayvanIRkı", listBox.SelectedItem);
                sqlCommand.Parameters.AddWithValue("@evcilHayvanCinsiyet", txb_hayvanCinsiyet.Text);
                sqlCommand.Parameters.AddWithValue("@hayvanSahibiAdı", txb_ownerName.Text);
                sqlCommand.Parameters.AddWithValue("@hayvanSahibiTelefonNo", txb_ownerNo.Text);
                sqlCommand.Parameters.AddWithValue("@veterinerAdı", txb_vetName.Text);
                sqlCommand.Parameters.AddWithValue("@veterinerTelNo", txb_vetNo.Text);
                sqlCommand.Parameters.AddWithValue("@hayvanHastalıkları", txb_deases.Text);

                sqlConnection.Close();

                tbx_petNameID.Text = "";
                txb_petName.Text = "";
                listBox.SelectedIndex = 0;
                txb_hayvanCinsiyet.Text = "";
                txb_ownerName.Text = "";
                txb_ownerNo.Text = "";
                txb_vetName.Text = "";
                txb_vetNo.Text = "";
                txb_deases.Text = "";

                MessageBox.Show("Evcil Hayvan Kaydı Başarıyla Güncellendi!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tbx_petNameID.Text = "";
                txb_petName.Text = "";
                listBox.SelectedIndex = 0;
                txb_hayvanCinsiyet.Text = "";
                txb_ownerName.Text = "";
                txb_ownerNo.Text = "";
                txb_vetName.Text = "";
                txb_vetNo.Text = "";
                txb_deases.Text = "";
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
