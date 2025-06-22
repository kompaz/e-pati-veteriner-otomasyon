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
    public partial class screenYeniEkle : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=desktop-7ch6a9v;Initial Catalog=ePati;Integrated Security=True");
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public screenYeniEkle()
        {
            InitializeComponent();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            this.Close();
            vet.Show();
        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Ekleme yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if(m == DialogResult.Yes)
            {

                string sorgu = "INSERT INTO e_Pati(evcilHayvanID,evcilHayvanAdı,evcilHayvanIRkı," +
                    " evcilHayvanCinsiyet, hayvanSahibiAdı,hayvanSahibiTelefonNo,veterinerAdı" +
                    ",veterinerTelNo,hayvanHastalıkları) VALUES " +
                    "(@evcilHayvanID, @evcilHayvanAdı, @evcilHayvanIRkı, @evcilHayvanCinsiyet, @hayvanSahibiAdı," +
                    "@hayvanSahibiTelefonNo, @veterinerAdı, @veterinerTelNo, @hayvanHastalıkları)";

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

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
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

                MessageBox.Show("Yeni Evcil Hayvan Sisteme Başarıyla Eklendi!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
