using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ypgProjesi
{
    public partial class TKFSoru: Form
    {
        private string isim;
        private string soyisim;
        public TKFSoru(string isim, string soyisim)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
        }
       
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                int toplamTkf = 0;

                foreach (Control kontrol in this.Controls)
                {
                    if (kontrol is GroupBox groupBox)
                    {
                        foreach (Control rb in groupBox.Controls)
                        {
                            if (rb is RadioButton radioButton && radioButton.Checked)
                            {
                                toplamTkf += Convert.ToInt32(radioButton.Tag);
                            }
                        }
                    }
                }

                lblSonuc.Text = "Toplam TKF: " + toplamTkf.ToString();

                string sorgu = "UPDATE Kullanici SET TKF_Degeri = @tkf WHERE Adi = @adi AND Soyadi = @soyadi";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@adi", isim);
                    komut.Parameters.AddWithValue("@soyadi", soyisim);
                    komut.Parameters.AddWithValue("@tkf", toplamTkf);

                    komut.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        


        private void AinHesapGec_Click(object sender, EventArgs e)
        {
            AinHesaplama form3 = new AinHesaplama(isim, soyisim);
            form3.Show();
            this.Hide();

        }

        private void TKFSoru_Load(object sender, EventArgs e)
        {

        }
    }
}
