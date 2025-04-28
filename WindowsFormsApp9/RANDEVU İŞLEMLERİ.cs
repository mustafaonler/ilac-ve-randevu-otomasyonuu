using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

using System.Windows.Forms;



namespace WindowsFormsApp9
{
    public partial class RANDEVU_İŞLEMLERİ : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1");
        private object dateEditTarih;
        private object timeEditSaat;
        private object dgvRandevular;
        private object gridControlRandevular;
        private object chartControl1;

        // private object comboBoxEditBölüm;
        //private object comboBoxEditDoktor;

        public RANDEVU_İŞLEMLERİ()
        {
            InitializeComponent();
        }
        private void RandevuForm_Load(object sender, EventArgs e)
        {
            
            cmbbölüm.Properties.Items.Add("Kardiyoloji");
            cmbbölüm.Properties.Items.Add("Nöroloji");
            cmbbölüm.Properties.Items.Add("Ortopedi");
            BölümleriListele();
        }
        // Bölümleri listeleme
        private void BölümleriListele()
        {
            try
            {
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("SELECT DISTINCT Bölüm FROM Doktorlar", bağlantı);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    cmbbölüm.Properties.Items.Add(reader["Bölüm"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                bağlantı.Close();
            }
        }

        // Bölüm seçildiğinde doktorları listeleme
        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Properties.Items.Clear();
            if (cmbbölüm.SelectedItem.ToString() == "Kardiyoloji")
            {
                cmbdoktor.Properties.Items.Add("Dr. Ahmet Yılmaz");
                cmbdoktor.Properties.Items.Add("Dr. Ayşe Demir");
            }
            else if (cmbbölüm.SelectedItem.ToString() == "Nöroloji")
            {
                cmbdoktor.Properties.Items.Add("Dr. Mehmet Kaya");
                cmbdoktor.Properties.Items.Add("Dr. Elif Çelik");
            }
            else if (cmbbölüm.SelectedItem.ToString() == "Ortopedi")
            {
                cmbdoktor.Properties.Items.Add("Dr. Ali Can");
                cmbdoktor.Properties.Items.Add("Dr. Zeynep Şahin");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lar üzerinden verileri alıyoruz
            string tarihMetni = txt_tarih.Text; // Tarih için TextBox
            string saatMetni = txt_saat.Text;  // Saat için TextBox

            // Kullanıcı adı gibi diğer bilgiler
            string kullanıcıAdı = txt_kullanıcıadı.Text; // Kullanıcı adı için TextBox
            string bölüm = cmbbölüm.Text;              // Bölüm için TextBox
            string doktor = cmbdoktor.Text;            // Doktor için TextBox

            DateTime tarih;
            TimeSpan saat;

            // Tarih ve saat formatlarını doğrulama
            if (!DateTime.TryParse(tarihMetni, out tarih))
            {
                MessageBox.Show("Tarih formatı hatalı! Lütfen doğru formatta giriniz (yyyy-MM-dd).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TimeSpan.TryParse(saatMetni, out saat))
            {
                MessageBox.Show("Saat formatı hatalı! Lütfen doğru formatta giriniz (HH:mm).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // SQL Bağlantısı
                using (SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1"))
                {
                    bağlantı.Open();

                    // Randevu kontrolü
                    string kontrolSorgusu = "SELECT COUNT(*) FROM Randevu WHERE Doktor = @doktor AND tarih = @tarih AND saat = @saat";
                    SqlCommand kontrolKomutu = new SqlCommand(kontrolSorgusu, bağlantı);
                    kontrolKomutu.Parameters.AddWithValue("@doktor", doktor);
                    kontrolKomutu.Parameters.AddWithValue("@tarih", tarih);
                    kontrolKomutu.Parameters.AddWithValue("@saat", saat);

                    int randevuVarMı = (int)kontrolKomutu.ExecuteScalar();

                    if (randevuVarMı > 0)
                    {
                        MessageBox.Show("Bu saat dolu. Lütfen başka bir saat seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Randevu ekleme
                        string ekleSorgusu = "INSERT INTO Randevu (KullanıcıAdı, Tarih, Saat, Bölüm, Doktor) VALUES (@kullanıcıAdı, @tarih, @saat, @bölüm, @doktor)";
                        SqlCommand ekleKomutu = new SqlCommand(ekleSorgusu, bağlantı);
                        ekleKomutu.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);
                        ekleKomutu.Parameters.AddWithValue("@bölüm", bölüm);
                        ekleKomutu.Parameters.AddWithValue("@doktor", doktor);
                        ekleKomutu.Parameters.AddWithValue("@tarih", tarih);
                        ekleKomutu.Parameters.AddWithValue("@saat", saat);

                        ekleKomutu.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla alındı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcı adını TextBox'tan alıyoruz.
            string kullanıcıAdı = txt_kullanıcıadı.Text;

            if (string.IsNullOrEmpty(kullanıcıAdı))
            {
                XtraMessageBox.Show("Lütfen kullanıcı adınızı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SQL bağlantısını oluştur.
                using (SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1"))
                {
                    bağlantı.Open();

                    // Kullanıcının randevularını getir.
                    string listeleSorgusu = @"
                SELECT 
                    Tarih AS [Tarih], 
                    Saat AS [Saat], 
                    Bölüm AS [Bölüm], 
                    Doktor AS [Doktor]
                FROM Randevu 
                WHERE KullanıcıAdı = @kullanıcıAdı";

                    SqlCommand listeleKomutu = new SqlCommand(listeleSorgusu, bağlantı);
                    listeleKomutu.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);

                    // DataTable oluştur ve verileri doldur.
                    DataTable randevuTablosu = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(listeleKomutu);
                    adapter.Fill(randevuTablosu);

                    // Eğer randevular varsa GridControl'e bağla.
                    if (randevuTablosu.Rows.Count > 0)
                    {
                        controlRandevular.DataSource = randevuTablosu; // DataSource'u ayarla
                        controlRandevular.Refresh(); // GridControl'ü yenile
                        XtraMessageBox.Show("Randevularınız listelendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Hiçbir randevunuz bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        controlRandevular.DataSource = null; // GridControl'ü temizle
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınacak bilgiler
            string kullanıcıAdı = txt_kullanıcıadısil.Text; // Kullanıcı giriş yapmışsa buradan alabilirsiniz
            DateTime randevuTarihi;
            TimeSpan randevuSaati;
            string bölüm = cmb_bölümsil.SelectedItem?.ToString();
            string doktor = cmb_dokotrsil.SelectedItem?.ToString();

            // Girişlerin kontrol edilmesi
            if (string.IsNullOrEmpty(kullanıcıAdı) ||
                !DateTime.TryParse(txt_tarihsil.Text, out randevuTarihi) ||
                !TimeSpan.TryParse(txt_saatsil.Text, out randevuSaati) ||
                string.IsNullOrEmpty(bölüm) ||
                string.IsNullOrEmpty(doktor))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doğru bir şekilde doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Onay mesajı
            DialogResult result = XtraMessageBox.Show(
                "Randevu işleminizi silmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Eğer kullanıcı "Hayır" derse işlemi iptal et
            if (result != DialogResult.Yes)
            {
                XtraMessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1"))
                {
                    bağlantı.Open();

                    // Silme işlemi için SQL sorgusu
                    string silSorgusu = @"
                DELETE FROM Randevu
                WHERE KullanıcıAdı = @kullanıcıAdı
                AND Tarih = @randevuTarihi
                AND Saat = @randevuSaati
                AND Bölüm = @bölüm
                AND Doktor = @doktor";

                    SqlCommand silKomutu = new SqlCommand(silSorgusu, bağlantı);
                    silKomutu.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);
                    silKomutu.Parameters.AddWithValue("@randevuTarihi", randevuTarihi);
                    silKomutu.Parameters.AddWithValue("@randevuSaati", randevuSaati);
                    silKomutu.Parameters.AddWithValue("@bölüm", bölüm);
                    silKomutu.Parameters.AddWithValue("@doktor", doktor);

                    int etkilenenSatır = silKomutu.ExecuteNonQuery();

                    if (etkilenenSatır > 0)
                    {
                        XtraMessageBox.Show("Randevunuz başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // GridControl'ü yenileyebilirsiniz
                        controlRandevular.Refresh();
                    }
                    else
                    {
                        XtraMessageBox.Show("Silinecek randevu bulunamadı. Lütfen bilgilerinizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void controlRandevular_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            gridView1.Appearance.HeaderPanel.Font = new Font("Arial", 10, FontStyle.Bold);
            gridView1.Appearance.HeaderPanel.ForeColor = Color.DarkBlue;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.BackColor = Color.LightGray; // Satırların arka plan rengi
            gridView1.Appearance.Row.ForeColor = Color.Black;    // Yazı rengi

            gridView1.Appearance.HeaderPanel.BackColor = Color.DarkGray; // Kolon başlığı rengi

        }

        private void txt_saatsil_TextChanged(object sender, EventArgs e)
        {

        }
    }


        
    }


     
    

