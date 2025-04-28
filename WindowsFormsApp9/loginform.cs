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

namespace WindowsFormsApp9
{

    public partial class loginform : Form
    {
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static class OturumBilgileri
        {
            public static string GirişYapanKullanıcıAdı { get; set; } // Kullanıcı adı
            public static int GirişYapanŞifre { get; set; }           // Şifre
        }

        public loginform()
        {
            InitializeComponent();


        }
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1");

        private bool KullanıcıGiriş(string kullanıcıadı, string şifre)
        {
            try
            {
                bağlantı.Open();
                SqlCommand com = new SqlCommand("SELECT*  FROM Kullanıcı WHERE kullanıcıadı = @kullanıcıadı AND şifre = @şifre", bağlantı);
                com.Parameters.AddWithValue("@kullanıcıadı", kullanıcıadı);
                com.Parameters.AddWithValue("@şifre", şifre);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    OturumBilgileri.GirişYapanKullanıcıAdı = reader["kullanıcıadı"].ToString();
                    OturumBilgileri.GirişYapanŞifre = Convert.ToInt32(reader["şifre"]);
                    reader.Close();
                    return true; // Giriş başarılı
                }
                else
                {
                    reader.Close();
                    return false; // Giriş başarısız
                }
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

        public void loginform_Load(object sender, EventArgs e)
        {




        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                string kullanıcıAdı = txt_kulanıcıadı.Text.Trim();
                string sifre = txt_şifre.Text.Trim();


                // Kullanıcı girişini kontrol et
                if (KullanıcıGiriş(kullanıcıAdı, sifre))
                {
                    MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ana ekrana geçiş
                    AnaSayfa anaEkran = new AnaSayfa();
                    anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz bilgilerde kullanıcı bulunamadı.Bilgilerinizi kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }

    /*private void btn_giris_Click(object sender, EventArgs e)
    {

        string kullanıcıAdı = txt_kulanıcıadı.Text; // Kullanıcı adı textbox
        string şifre = txt_şifre.Text; // Şifre textbox

        if (KullanıcıGiriş(kullanıcıAdı, şifre))
        {
            MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Yeni formu aç
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();

            this.Hide(); // Login formunu gizle
        }
        else
        {
            MessageBox.Show("Kayıt bulunamadı. Lütfen kullanıcı adı ve şifrenizi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}*/
}

