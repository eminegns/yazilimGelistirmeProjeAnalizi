using projehilal;
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
    public partial class SatirSayisiHesaplama: Form
    {
        private string isim;
        private string soyisim;

        public SatirSayisiHesaplama(string isim, string soyisim)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");

        private void bttnSShesaplama_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // 1. Kullanıcının İN değeri
                double inDegeri = 0;
                string inSorgu = "SELECT IN_Degeri FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";

                using (SqlCommand cmd = new SqlCommand(inSorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@adi", isim);
                    cmd.Parameters.AddWithValue("@soyadi", soyisim);

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc == null || sonuc == DBNull.Value)
                    {
                        MessageBox.Show("Bu kullanıcıya ait İN değeri bulunamadı.");
                        return;
                    }

                    inDegeri = Convert.ToDouble(sonuc);
                }

                // 2. Platform seçimi ve NKD (OrtalamaSatirSayisi) değeri
                if (cmbPlatform.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir programlama platformu seçin.");
                    return;
                }

                string secilenPlatform = cmbPlatform.SelectedItem.ToString();
                int nkdDegeri = 0;

                string nkdSorgu = "SELECT OrtalamaSatirSayisi FROM ProgramlamaPlatformu WHERE PlatformAdi = @platform";

                using (SqlCommand cmd = new SqlCommand(nkdSorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@platform", secilenPlatform);

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc == null || sonuc == DBNull.Value)
                    {
                        MessageBox.Show("Seçilen platforma ait NKD değeri bulunamadı.");
                        return;
                    }

                    nkdDegeri = Convert.ToInt32(sonuc);
                }

                // 3. SS Hesapla
                double ss = inDegeri * nkdDegeri;
                lblSS.Text = "Satır Sayısı (SS): " + ss.ToString("0.00");

                // 4. Veritabanına kaydet
                string guncelleSorgu = "UPDATE Kullanici SET Satir_sayisi = @ss WHERE Adi = @adi AND Soyadi = @soyadi";

                using (SqlCommand guncelleCmd = new SqlCommand(guncelleSorgu, baglanti))
                {
                    guncelleCmd.Parameters.AddWithValue("@ss", ss);
                    guncelleCmd.Parameters.AddWithValue("@adi", isim);
                    guncelleCmd.Parameters.AddWithValue("@soyadi", soyisim);
                    guncelleCmd.ExecuteNonQuery();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void bttnCocomoGec_Click(object sender, EventArgs e)
        {
            cocomoModel form5 = new cocomoModel(isim, soyisim);
            form5.Show();
            this.Hide();
        }
    }
}
