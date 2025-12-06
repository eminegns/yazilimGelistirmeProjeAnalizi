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
    public partial class kullanici: Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1IHJLCN\SQLEXPRESS;Initial Catalog=ypgProjesi;Integrated Security=True;");
        private void bttnSonucGetir_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string kullaniciAdi = txtKullaniciAdi.Text.Trim();

                if (string.IsNullOrEmpty(kullaniciAdi))
                {
                    MessageBox.Show("Lütfen kullanıcı adını girin.");
                    return;
                }

                // Sadece gerekli sütunları çekiyoruz
                string sorgu = @"
        SELECT 
            Adi, 
            Soyadi, 
            TKF_Degeri, 
            IN_Degeri, 
            Is_Gucu, 
            Zaman, 
            Maliyet_Carpani, 
            Duzeltilmis_is_gucu, 
            Adam_Hafta 
        FROM Kullanici 
        WHERE Adi = @adi";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adi", kullaniciAdi);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;

                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                    dataGridView1.DataSource = null;
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
