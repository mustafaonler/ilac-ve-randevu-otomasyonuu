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
    public partial class registerform : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1");


        public registerform()
        {
            InitializeComponent();
        }

        private void registerform_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public int kayıt_ekle()
        {
            int result = 0;

            try
            {
                // Veritabanı bağlantısını açıyoruz
                bağlantı.Open();

                // Kullanıcıyı veritabanına ekleme işlemi
                SqlCommand com = new SqlCommand("INSERT INTO Kullanıcı(isim, soyisim, kullanıcıadı, şifre) " +
                                                "VALUES(@isim, @soyisim, @kullanıcıadı, @şifre)", bağlantı);
                com.Parameters.AddWithValue("@isim", txt_isim.Text);
                com.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
                com.Parameters.AddWithValue("@kullanıcıadı", txt_kulanıcıadı.Text);
                com.Parameters.AddWithValue("@şifre", txt_şifre.Text);

                // Veriyi ekliyoruz
                result = com.ExecuteNonQuery();

                // Sonuç başarılıysa
                if (result == 1)
                {
                    MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                if (bağlantı.State == ConnectionState.Open)
                {
                    bağlantı.Close();
                }
            }

            return result;
        }

            private void btn_kayıt_Click(object sender, EventArgs e)
        {
            int sonuç = kayıt_ekle();
            if (sonuç == 1)
            {
                MessageBox.Show("Kayıt başarılı! " , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt sırasında bir sorun oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                loginform loginegit = new loginform();
                loginegit.Show();
                this.Hide();
            }

        private void txt_kulanıcıadı_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
