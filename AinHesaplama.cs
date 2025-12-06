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
    public partial class AinHesaplama : Form
    {
        private string isim;
        private string soyisim;
        double toplam = 0;

        public AinHesaplama(string isim, string soyisim)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = 0;

            try
            {
                toplam += Convert.ToInt32(txtGirdi.Text) * 4;
                toplam += Convert.ToInt32(txtCikti.Text) * 5;
                toplam += Convert.ToInt32(txtSorgu.Text) * 4;
                toplam += Convert.ToInt32(txtKutuk.Text) * 10;
                toplam += Convert.ToInt32(txtArayuz.Text) * 7;

                lblAinHesap.Text = "Toplam AİN: " + toplam.ToString();

                // SQL'e AIN değerini kaydet
                baglanti.Open();
                string sorgu = "UPDATE Kullanici SET AIN_Degeri = @ain WHERE Adi = @ad AND Soyadi = @soyad";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ain", toplam);
                    komut.Parameters.AddWithValue("@ad", isim);
                    komut.Parameters.AddWithValue("@soyad", soyisim);

                    komut.ExecuteNonQuery();
                }

               
            }
            catch (FormatException)
            {
                lblAinHesap.Text = "Lütfen tüm kutulara geçerli bir sayı girin.";
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

        private void bttnIslevNoktasi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // TKF'yi çek
                string sorgu = "SELECT TKF_Degeri FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";

                int TKF = 0;

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@adi", isim);
                    komut.Parameters.AddWithValue("@soyadi", soyisim);

                    

                    object sonuc = komut.ExecuteScalar();

                    if (sonuc != null && sonuc != DBNull.Value)
                    {
                        TKF = Convert.ToInt32(sonuc);
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcıya ait TKF değeri bulunamadı veya boş.");
                        return;
                    }
                }

                double IN = toplam * (0.65 + 0.01 * TKF);

                lbl_islevNoktasi.Text = "İN Değeri: " + IN.ToString("0.00");

                string update = "UPDATE Kullanici SET AIN_Degeri = @ain, IN_Degeri = @in WHERE Adi = @adi AND Soyadi = @soyadi";

                using (SqlCommand guncelleKomut = new SqlCommand(update, baglanti))
                {
                    guncelleKomut.Parameters.AddWithValue("@ain", toplam);
                    guncelleKomut.Parameters.AddWithValue("@in", IN);
                    guncelleKomut.Parameters.AddWithValue("@adi", isim);
                    guncelleKomut.Parameters.AddWithValue("@soyadi", soyisim);
                    guncelleKomut.ExecuteNonQuery();
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

        private void bttnSSgec_Click(object sender, EventArgs e)
        {
            SatirSayisiHesaplama form4 = new SatirSayisiHesaplama(isim, soyisim);
            form4.Show();
            this.Hide();
        }

        private void lblAinHesap_Click(object sender, EventArgs e)
        {

        }
    }

}
