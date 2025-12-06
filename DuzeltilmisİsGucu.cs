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
using ypgProjesi;

namespace hesaplama
{
    public partial class DuzeltilmisİsGucu: Form
    {
        private string isim;
        private string soyisim; 
        public DuzeltilmisİsGucu(string isim, string soyisim)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");




        private void bttnDuzeltilmisGuc_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                double isGucu = 0;
                double maliyetCarpani = 0;

                // SQL'den Is_Gucu ve Maliyet_Carpani değerlerini al
                string sorgu = "SELECT Is_gucu, Maliyet_Carpani FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@adi", isim);
                    cmd.Parameters.AddWithValue("@soyadi", soyisim);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isGucu = reader["Is_gucu"] != DBNull.Value ? Convert.ToDouble(reader["Is_gucu"]) : 0;
                            maliyetCarpani = reader["Maliyet_Carpani"] != DBNull.Value ? Convert.ToDouble(reader["Maliyet_Carpani"]) : 0;
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcıya ait veri bulunamadı.");
                            return;
                        }
                    }
                }

                // Verileri aldıktan sonra çarp
                double kd = isGucu * maliyetCarpani;
                lblMaliyetSonuc.Text = "Düzeltilmiş İş Gücü (KD): " + kd.ToString("0.00");

                // Güncelleme sorgusu
                string guncelle = "UPDATE Kullanici SET Duzeltilmis_is_gucu = @kd WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand guncelleCmd = new SqlCommand(guncelle, baglanti))
                {
                    guncelleCmd.Parameters.AddWithValue("@kd", kd);
                    guncelleCmd.Parameters.AddWithValue("@adi", isim);
                    guncelleCmd.Parameters.AddWithValue("@soyadi", soyisim);
                    guncelleCmd.ExecuteNonQuery();
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





        private void bttnOrtalamaPersonel_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                double kd = 0;
                double T = 0;

                // SQL'den Duzeltilmis_is_gucu ve Zaman değerlerini al
                string sorgu = "SELECT Duzeltilmis_is_gucu, Zaman FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@adi", isim);
                    cmd.Parameters.AddWithValue("@soyadi", soyisim);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kd = reader["Duzeltilmis_is_gucu"] != DBNull.Value ? Convert.ToDouble(reader["Duzeltilmis_is_gucu"]) : 0;
                            T = reader["Zaman"] != DBNull.Value ? Convert.ToDouble(reader["Zaman"]) : 0;
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcıya ait KD ve Zaman değeri bulunamadı.");
                            return;
                        }
                    }
                }

                // T 0 veya eksikse kontrol
                if (T == 0)
                {
                    MessageBox.Show("Zaman (T) değeri 0 olamaz veya bulunamadı.");
                    return;
                }

                double N = kd / T;
                lblOrtPersonel.Text = "Ortalama Personel Sayısı (N): " + N.ToString("0.00");

                // SQL'e ortalama personel sayısını yaz
                string guncelle = "UPDATE Kullanici SET Ortalama_Personel = @n WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand guncelleKomut = new SqlCommand(guncelle, baglanti))
                {
                    guncelleKomut.Parameters.AddWithValue("@n", N);
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

        private void btnCevir_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                double kd = 0;
                double sonuc = 0;

                // SQL'den Düzeltilmiş İş Gücü (KD) değerini al
                string sorgu = "SELECT Duzeltilmis_is_gucu FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@adi", isim);
                    cmd.Parameters.AddWithValue("@soyadi", soyisim);

                    object veri = cmd.ExecuteScalar();
                    if (veri != null && veri != DBNull.Value)
                    {
                        kd = Convert.ToDouble(veri);
                    }
                    else
                    {
                        MessageBox.Show("Düzeltilmiş iş gücü değeri bulunamadı.");
                        return;
                    }
                }

                // Hesaplama: (KD * 22) / 5
                sonuc = (kd * 22) / 5;
                lblHaftaCevir.Text = "Adam hafta " + sonuc.ToString("0.00");

                
                string guncelle = "UPDATE Kullanici SET Adam_hafta = @sonuc WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand guncelleKomut = new SqlCommand(guncelle, baglanti))
                {
                    guncelleKomut.Parameters.AddWithValue("@sonuc", sonuc);
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

        private void KullaniciGec_Click(object sender, EventArgs e)
        {
            kullanici form7 = new kullanici();
            form7.Show();
            this.Hide();
        }
    }
}
