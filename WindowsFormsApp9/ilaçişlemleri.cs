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
using static WindowsFormsApp9.loginform;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsFormsApp9
{

    public partial class ilaçişlemleri : Form
    {



        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1");
        public int sifre;
        private object dateEdit1;
        private DateTime dateEdit;
        private object komut;
        private object dateEditTarih;

        public ilaçişlemleri()
        {
            InitializeComponent();
            CustomizeGridControl();
            sifre = sifre;
        }
        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }





        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CustomizeGridControl()
        {
            // GridControl'de LookAndFeel ayarları
            gridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            gridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            gridControl2.BackColor = Color.LightGray;

            // GridView ayarları
            GridView view = gridControl2.MainView as GridView;
            view.Appearance.Row.BackColor = Color.White;
            view.Appearance.Row.ForeColor = Color.Black;
            view.Appearance.HeaderPanel.BackColor = Color.DarkSlateGray;
            view.Appearance.HeaderPanel.ForeColor = Color.White;
            view.Appearance.FocusedRow.BackColor = Color.LightBlue;
            view.Appearance.FocusedRow.ForeColor = Color.DarkRed;
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kayıt ekle
            ilaç_ekle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kayıt sil
            string seciliIlacAdi = SeciliIlacAdiGetir();

            if (!string.IsNullOrEmpty(seciliIlacAdi)) // Geçerli bir ilaç adı varsa
            {
                DialogResult onay = MessageBox.Show(
                    $"'{seciliIlacAdi}' isimli ilacı silmek istediğinizden emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    ilaçSil(seciliIlacAdi);

                    // Listeyi güncelle
                    // IlaclariListele();
                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan güncellenecek ilaç adı ve yeni bilgileri al
                string ilacAdi = txt_ilaçid.Text.Trim();
                string yeniIlacAdi = txt_ilaçadı.Text.Trim(); // Yeni ilaç adı
                decimal yeniFiyat = Convert.ToDecimal(txt_ilaçfiyatı.Text.Trim()); // Yeni fiyat
                DateTime yeniTarih =DateTime.Parse(txt_ilaçtarihi.Text); ; // Yeni tarih
                string yeniNeIseYaradi = txt_ilaçamacı.Text.Trim(); // Yeni ilaç açıklaması
                string yeniYanEtkiler = txt_ilaçyanetki.Text.Trim(); // Yeni yan etkiler

                // Bağlantıyı aç
                using (SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1"))
                {
                    bağlantı.Open();

                    // Güncelleme işlemi için komut oluştur
                    SqlCommand komut = new SqlCommand(@"
                UPDATE ilaçç
                SET ilaçadı = @yeniIlacAdi, fiyat = @yeniFiyat, tarih = @yeniTarih, 
                    ilaçneiseyaradığı = @yeniNeIseYaradi, ilaçyanetkileri = @yeniYanEtkiler
                WHERE ilaçadı = @ilacAdi AND şifre = @kullaniciSifre", bağlantı);

                    // Parametreleri ekle
                    komut.Parameters.AddWithValue("@ilacAdi", ilacAdi);
                    komut.Parameters.AddWithValue("@yeniIlacAdi", yeniIlacAdi);
                    komut.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                    komut.Parameters.AddWithValue("@yeniTarih", yeniTarih);
                    komut.Parameters.AddWithValue("@yeniNeIseyaradi", yeniNeIseYaradi);
                    komut.Parameters.AddWithValue("@yeniYanEtkiler", yeniYanEtkiler);
                    komut.Parameters.AddWithValue("@kullaniciSifre", OturumBilgileri.GirişYapanŞifre);

                    // Komutu çalıştır
                    int etkilenenSatirlar = komut.ExecuteNonQuery();

                    if (etkilenenSatirlar > 0)
                    {
                        MessageBox.Show("İlaç bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen ilaç bulunamadı ya da başka bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    

    private void button4_Click(object sender, EventArgs e)
    {
        //kayıtları listele
        İlaçlarıListele();

    }
    public void ilaç_ekle()
    {
            try
            {
                bağlantı.Open();
                SqlCommand com = new SqlCommand("INSERT INTO ilaçç (ilaçadı, fiyat, tarih, ilaçneiseyaradığı, ilaçyanetkileri,Şifre) VALUES (@ilaçadı, @fiyat, @tarih, @ilaçneiseyaradığı, @ilaçyanetkileri, @Şifre)", bağlantı);
                com.Parameters.AddWithValue("@ilaçadı", txt_ilaçadı.Text);
                com.Parameters.AddWithValue("@fiyat", decimal.Parse(txt_ilaçfiyatı.Text));
                com.Parameters.AddWithValue("@tarih", DateTime.Parse(txt_ilaçtarihi.Text));
                com.Parameters.AddWithValue("@ilaçneiseyaradığı", txt_ilaçamacı.Text);
                com.Parameters.AddWithValue("@ilaçyanetkileri", txt_ilaçyanetki.Text);
                com.Parameters.AddWithValue("@şifre", OturumBilgileri.GirişYapanŞifre);






                com.ExecuteNonQuery();
                XtraMessageBox.Show("İlaç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                bağlantı.Close();

            }

    }
    public void İlaçlarıListele()
    {

      
        try
        {
            if (bağlantı.State == ConnectionState.Closed)
                bağlantı.Open();

            // SQL sorgusu: Giriş yapan kullanıcının ilaçlarını getir
            SqlCommand komut = new SqlCommand(
                "SELECT ilaçadı, fiyat,tarih, ilaçneiseyaradığı, ilaçyanetkileri " +
                "FROM ilaçç WHERE şifre = @şifre", bağlantı);

            komut.Parameters.AddWithValue("@şifre", OturumBilgileri.GirişYapanŞifre);

            // Verileri DataTable'a yükle
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // GridControl veya DataGridView'e verileri bağla
            gridControl2.DataSource = table; // DevExpress GridControl kullanıyorsanız
                                             // dataGridView1.DataSource = table; // DataGridView kullanıyorsanız
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (bağlantı.State == ConnectionState.Open)
                bağlantı.Close();
        }
    }
    public void ilaçSil(string ilaçAdı)
    {
        /* try
         {
             // Bağlantıyı açıyoruz
             using (SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1"))
             {
                 bağlantı.Open();

                 // İlaç silme işlemi
                 SqlCommand com = new SqlCommand("DELETE FROM ilaçlar WHERE ilaçID = @ilaçID AND ilaçAdı = @ilaçAdı", bağlantı);
                 com.Parameters.AddWithValue("@ilaçID", ilaçID); // İlaç ID'sini parametre olarak ekliyoruz
                 com.Parameters.AddWithValue("@ilaçAdı", ilaçAdı); // İlaç Adı'nı parametre olarak ekliyoruz

                 // Silme işlemini gerçekleştirme
                 int result = com.ExecuteNonQuery();
                 if (result > 0)
                 {
                     MessageBox.Show("İlaç başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                     MessageBox.Show("İlaç bulunamadı veya silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
     }*/
        try
        {
            if (bağlantı.State == ConnectionState.Closed)
                bağlantı.Open();

            // SQL sorgusu: İlgili şifre ve ilaç adına göre ilaç sil
            SqlCommand komut = new SqlCommand(
                "DELETE FROM ilaçç WHERE ilaçadı = @ilaçadı AND şifre = @şifre", bağlantı);

            komut.Parameters.AddWithValue("@ilaçadı", ilaçAdı);
            komut.Parameters.AddWithValue("@şifre", OturumBilgileri.GirişYapanŞifre);

            int etkilenenSatır = komut.ExecuteNonQuery();
            if (etkilenenSatır > 0)
            {
                MessageBox.Show("İlaç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İlaç silinemedi. Seçtiğiniz ilaç size ait olmayabilir veya ilaç adı yanlış girilmiş olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (bağlantı.State == ConnectionState.Open)
                bağlantı.Close();
        }
    }
    private string SeciliIlacAdiGetir()
    {
        if (gridView2.GetFocusedRowCellValue("ilaçadı") != null)
        {
            return gridView2.GetFocusedRowCellValue("ilaçadı").ToString();
        }
        else
        {
            MessageBox.Show("Lütfen silmek istediğiniz ilacı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null; // Seçim yapılmadıysa null döndür
        }
    }



        private void IlacGuncelle(string yeniIlacAdi, decimal yeniFiyat, DateTime yeniTarih, string yeniNeIseYaradi, string yeniYanEtkiler)
        {
            try
            {
                if (bağlantı.State == ConnectionState.Closed)
                    bağlantı.Open();

                SqlCommand komut = new SqlCommand(
                    "UPDATE ilaçç " +
                    "SET ilaçadı = @yeniIlacAdi, fiyat = @yeniFiyat,tarih = @yeniTarih , ilaçneiseyaradığı = @yeniNeIseYaradi, ilaçyanetkileri = @yeniYanEtkiler"  +
                    "WHERE ilaçadı = @eskiIlacAdi AND şifre = @şifre", bağlantı);

                komut.Parameters.AddWithValue("@yeniIlacAdi", yeniIlacAdi);
                komut.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                komut.Parameters.AddWithValue("@yeniTarih", yeniTarih);

                komut.Parameters.AddWithValue("@yeniNeIseYaradi", yeniNeIseYaradi);
                komut.Parameters.AddWithValue("@yeniYanEtkiler", yeniYanEtkiler);
                komut.Parameters.AddWithValue("@şifre", OturumBilgileri.GirişYapanŞifre);

                int etkilenenSatır = komut.ExecuteNonQuery();
                if (etkilenenSatır > 0)
                {
                    MessageBox.Show("İlaç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İlaç güncellenemedi. Eski ilaç adı hatalı olabilir veya bu ilaç size ait olmayabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (bağlantı.State == ConnectionState.Open)
                    bağlantı.Close();
            }
        }





    }
}







    




    


    

