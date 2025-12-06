using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ypgProjesi;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace projehilal
{
    public partial class cocomoModel : Form
    {
        string isim;
        string soyisim;

        public cocomoModel(string isim, string soyisim)
        {
            InitializeComponent();
            this.isim = isim;
            this.soyisim = soyisim;
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        public void CButton2_Click(object sender, EventArgs e)
        {

        }

        private void CButton2_Click_1(object sender, EventArgs e)
        {
            double S = 0;
            double K = 0;

            try
            {
                baglanti.Open();

                // Satır Sayısını Al
                string sorgu = "SELECT Satir_sayisi FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@adi", isim);
                    komut.Parameters.AddWithValue("@soyadi", soyisim);

                    object sonuc = komut.ExecuteScalar();
                    if (sonuc == null || sonuc == DBNull.Value)
                    {
                        MessageBox.Show("Satır sayısı bulunamadı.");
                        return;
                    }

                    S = Convert.ToDouble(sonuc) / 1000.0;
                }

                // GroupBox1 Temel Model Seçim (İş Gücü)
                //Temel - Ayrık
                if (CR1.Checked && CR4.Checked)
                {
                    K = 2.4 * (Math.Pow(S, 1.05));
                    lblGucHesap.Text = "İş Gücü: " + K.ToString();
                }
                //Temel - Yarı Gömülü
                else if (CR1.Checked && CR5.Checked)
                {
                    K = 3.0 * (Math.Pow(S, 1.12));
                    lblGucHesap.Text = "İş Gücü: " + K.ToString();
                }
                //Temel - Gömülü
                else if (CR1.Checked && CR6.Checked)
                {
                    K = 3.6 * (Math.Pow(S, 1.20));
                    lblGucHesap.Text = "İş Gücü: " + K.ToString();
                }

                // GroupBox1 Ara Model Seçim (İş Gücü)
                // Ara - Ayrık
                else if (CR2.Checked && CR4.Checked)
                {
                    K = 3.2 * (Math.Pow(S, 1.05));
                    lblGucHesap.Text = "İş Gücü: " + K.ToString();
                }
                // Ara - Yarı Gömülü
                else if (CR2.Checked && CR5.Checked)
                {
                    K = 3.0 * (Math.Pow(S, 1.12));
                    lblGucHesap.Text = "İş Gücü: " + K.ToString();
                }
                // Ara - Gömülü
                else if (CR2.Checked && CR6.Checked)
                {
                    K = 2.8 * (Math.Pow(S, 1.20));
                    lblGucHesap.Text = "İş Gücü: " + K.ToString();
                }
                else
                {
                    MessageBox.Show("Geçersiz Seçim");
                }
                

                // SQL’e K değerini yaz
                string guncelle = "UPDATE Kullanici SET Is_Gucu = @k WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand guncelleKomut = new SqlCommand(guncelle, baglanti))
                {
                    guncelleKomut.Parameters.AddWithValue("@k", K);
                    guncelleKomut.Parameters.AddWithValue("@adi", isim);
                    guncelleKomut.Parameters.AddWithValue("@soyadi", soyisim);
                    guncelleKomut.ExecuteNonQuery();
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

        private void bttnMaliyetGec_Click(object sender, EventArgs e)
        {
            maliyetEtmenii form6 = new maliyetEtmenii(isim, soyisim);
            form6.Show();
            this.Hide();
        }

        

        private void bttnZaman_Click(object sender, EventArgs e)
        {
            double T = 0;
            double K = 0;
            try
            {
                baglanti.Open();

                // SQL’den K (İş gücü) değerini al
                string sorgu = "SELECT Is_gucu FROM Kullanici WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@adi", isim);
                    cmd.Parameters.AddWithValue("@soyadi", soyisim);

                    object sonuc = cmd.ExecuteScalar();
                    if (sonuc == null || sonuc == DBNull.Value)
                    {
                        MessageBox.Show("İş gücü değeri bulunamadı.");
                        return;
                    }

                    K = Convert.ToDouble(sonuc);
                }
                // GroupBox1 Temel Model Seçim (Zaman)
                //Temel - Ayrık
                if (CR1.Checked && CR4.Checked)
                {
                    T = 2.5 * (Math.Pow(K, 0.38));
                    lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");

                }
                //Temel - Yarı Gömülü
                else if (CR1.Checked && CR5.Checked)
                {
                    T = 2.5 * (Math.Pow(K, 0.35));
                    lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");
                }
                //Temel - Gömülü
                else if (CR1.Checked && CR6.Checked)
                {
                    T = 2.5 * (Math.Pow(K, 0.32));
                    lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");
                }
                //ara - ayrık
                else if (CR2.Checked && CR4.Checked)
                {
                    T = 2.5 * (Math.Pow(K, 0.38));
                    lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");
                }
                // ara - yarı gömülü
                else if (CR2.Checked && CR5.Checked)
                {
                    T = 2.5 * (Math.Pow(K, 0.35));
                    lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");
                }
                //ara- gömülü
                else if (CR2.Checked && CR6.Checked)
                {
                    T = 2.5 * (Math.Pow(K, 0.32));
                    lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");

                }
                else
                {
                    MessageBox.Show("Geçersiz Seçim");
                }
                //  lblZamanHesap.Text = "Zaman (T): " + T.ToString("0.0000");

                // SQL’e T değerini yaz
                string guncelle = "UPDATE Kullanici SET Zaman = @t WHERE Adi = @adi AND Soyadi = @soyadi";
                using (SqlCommand guncelleKomut = new SqlCommand(guncelle, baglanti))
                {
                    guncelleKomut.Parameters.AddWithValue("@t", T);
                    guncelleKomut.Parameters.AddWithValue("@adi", isim);
                    guncelleKomut.Parameters.AddWithValue("@soyadi", soyisim);
                    guncelleKomut.ExecuteNonQuery();
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

        
    }
    
}
