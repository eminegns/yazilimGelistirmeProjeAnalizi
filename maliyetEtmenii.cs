using hesaplama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ypgProjesi
{
    public partial class maliyetEtmenii: Form
    {
        string isim;
        string soyisim;

        public maliyetEtmenii(string isim, string soyisim)
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
                // Her ComboBox için değeri al, "-" ise varsayılan olarak 1.00 ata
                double rely = GetComboValue(comboRELY);
                double data = GetComboValue(comboDATA);
                double cplx = GetComboValue(comboCPLX);

                double time = GetComboValue(comboTIME);
                double stor = GetComboValue(comboSTOR);
                double virt = GetComboValue(comboVIRT);
                double turn = GetComboValue(comboTURN);

                double acap = GetComboValue(comboACAP);
                double aexp = GetComboValue(comboAEXP);
                double pcap = GetComboValue(comboPCAP);
                double vexp = GetComboValue(comboVEXP);
                double lexp = GetComboValue(comboLEXP);

                double modp = GetComboValue(comboMODP);
                double tool = GetComboValue(comboTOOL);
                double sced = GetComboValue(comboSCED);

                // Maliyet Etmeni hesapla (çarpım)
                double maliyetEtmeni =
                    rely * data * cplx *
                    time * stor * virt * turn *
                    acap * aexp * pcap * vexp * lexp *
                    modp * tool * sced;

                // Sonucu göster
                lblMaliyetSonuc.Text="Maliyet Etmeni: " + maliyetEtmeni.ToString("F4");
                baglanti.Open();
                string guncelle = @"UPDATE Kullanici 
                            SET Maliyet_Carpani = @carpan 
                            WHERE Adi = @ad AND Soyadi = @soyad";

                using (SqlCommand komut = new SqlCommand(guncelle, baglanti))
                {
                    komut.Parameters.AddWithValue("@carpan", maliyetEtmeni);
                    komut.Parameters.AddWithValue("@ad", isim);
                    komut.Parameters.AddWithValue("@soyad", soyisim);

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

        // Yardımcı metod: ComboBox'tan double değeri al, "-" ise 1.00 döndür
        private double GetComboValue(ComboBox cmb)
        {
            if (cmb.SelectedItem == null || cmb.SelectedItem.ToString() == "-")
                return 1.00;
            else
                return Convert.ToDouble(cmb.SelectedItem.ToString(), CultureInfo.InvariantCulture);
        }

        private void maliyetEtmenii_Load(object sender, EventArgs e)
        {

        }

        private void SonFromGec_Click(object sender, EventArgs e)
        {
            
            DuzeltilmisİsGucu form7 = new DuzeltilmisİsGucu(isim, soyisim);
            form7.Show();
            this.Hide();
        }
    }
}
