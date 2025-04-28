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
using DevExpress.XtraEditors;


namespace WindowsFormsApp9
{
    public partial class KULLANICIİŞLEMLERİ : Form
    {
        public KULLANICIİŞLEMLERİ()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1");

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool KullanıcıDoğrula(string kullanıcıAdı, String şifre)
        {
            try
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand(
                    "SELECT COUNT(*) FROM Kullanıcı WHERE kullanıcıadı = @kullanıcıAdı AND şifre = @şifre",
                    bağlantı);
                komut.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);
                komut.Parameters.AddWithValue("@şifre", şifre);

                int kullanıcıSayısı = Convert.ToInt32(komut.ExecuteScalar());

                return kullanıcıSayısı > 0; // Eğer kullanıcı varsa true döndür
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                bağlantı.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini al
            string eskiKullanıcıAdı = txt_eskikullanıcıadı.Text.Trim();
            string eskiŞifre = txt_eskişifre.Text.Trim();
            String yeniKullanıcıAdı = txt_yenikulanıcıadı.Text.Trim();
            string yeniŞifre = txt_yenişifre.Text.Trim();

            // Eski bilgilerin doğruluğunu kontrol et
            if (KullanıcıDoğrula(eskiKullanıcıAdı, eskiŞifre))
            {
                try
                {
                    // Veritabanı bağlantısını aç
                    bağlantı.Open();

                    // Kullanıcı bilgilerini güncelleyen sorgu
                    SqlCommand com = new SqlCommand(
                        "UPDATE Kullanıcı SET kullanıcıadı = @yeniKullanıcıAdı, şifre = @yeniŞifre WHERE kullanıcıAdı = @eskiKullanıcıAdı AND şifre = @eskiŞifre",
                        bağlantı);
                    com.Parameters.AddWithValue("@yeniKullanıcıAdı", yeniKullanıcıAdı);
                    com.Parameters.AddWithValue("@yeniŞifre", yeniŞifre);
                    com.Parameters.AddWithValue("@eskiKullanıcıAdı", eskiKullanıcıAdı);
                    com.Parameters.AddWithValue("@eskiŞifre", eskiŞifre);

                    // Güncelleme işlemini çalıştır
                    int etkilenenSatır = com.ExecuteNonQuery();

                    if (etkilenenSatır > 0)
                    {
                        MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız oldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Veritabanı bağlantısını kapat
                    bağlantı.Close();
                }
            }
            else
            {
                // Kullanıcı doğrulama başarısız olduysa
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini al
            string kullanıcıAdı = txt_kullanıcıadı.Text.Trim();
            int şifre;

            // Şifreyi kontrol et
            if (string.IsNullOrEmpty(kullanıcıAdı) || !int.TryParse(txt_şifre2.Text.Trim(), out şifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifreyi doğru giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bağlantı.Open();

                // Kullanıcıyı kontrol et
                SqlCommand kontrolKomutu = new SqlCommand(
                    "SELECT COUNT(*) FROM Kullanıcı WHERE kullanıcıadı = @kullanıcıAdı AND şifre = @şifre", bağlantı);
                kontrolKomutu.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);
                kontrolKomutu.Parameters.AddWithValue("@şifre", şifre);

                int kullanıcıVarMı = (int)kontrolKomutu.ExecuteScalar();

                if (kullanıcıVarMı > 0)
                {
                    // Silmeden önce onay al
                    DialogResult onay = MessageBox.Show("Hesabınız silinecek. Emin misiniz?", "Uyarı",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                        // Kullanıcıyı sil
                        SqlCommand silKomutu = new SqlCommand(
                            "DELETE FROM Kullanıcı WHERE kullanıcıadı = @kullanıcıadı AND şifre = @şifre", bağlantı);
                        silKomutu.Parameters.AddWithValue("@kullanıcıadı", kullanıcıAdı);
                        silKomutu.Parameters.AddWithValue("@şifre", şifre);
                        silKomutu.ExecuteNonQuery();

                        MessageBox.Show("Hesabınız başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formu kapat veya çıkışa yönlendir
                        this.Close(); // Mevcut formu kapat
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bağlantı.Close();
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}



    

