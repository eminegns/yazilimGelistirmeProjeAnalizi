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
    public partial class GirisEkrani: Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");

        private void bttnTkfGec_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text.Trim();
            string soyisim = txtSoyisim.Text.Trim();

            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim))
            {
                MessageBox.Show("Lütfen isim ve soyisim giriniz.");
                return;
            }

            try
            {
                baglanti.Open();

                // Kullanıcıyı veritabanına ekle
                string ekleSorgu = @"INSERT INTO Kullanici (Adi, Soyadi) VALUES (@ad, @soyad)";

                using (SqlCommand komut = new SqlCommand(ekleSorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ad", isim);
                    komut.Parameters.AddWithValue("@soyad", soyisim);
                    komut.ExecuteNonQuery();
                }

                

                // Diğer forma geç
                TKFSoru form2 = new TKFSoru(isim, soyisim);
                form2.Show();
                this.Hide();
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
    }
}
