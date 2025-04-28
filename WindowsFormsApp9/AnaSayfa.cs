using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApp9
{
    public partial class AnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Tam ekran
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
       

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            ilaçişlemleri ilaçislem = new ilaçişlemleri();
            ilaçislem.MdiParent = this;
            ilaçislem.Show();

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            this.BackColor = Color.DarkGray; // Arka plan rengini açık gri yap
           
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void btn_ilaçsil_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            ilaçişlemleri ilaçislem = new ilaçişlemleri();
            ilaçislem.MdiParent = this;
            ilaçislem.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_güncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            ilaçişlemleri ilaçislem = new ilaçişlemleri();
            ilaçislem.MdiParent = this;
            ilaçislem.Show();
        }

        private void btn_ilaçgüncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            ilaçişlemleri ilaçislem = new ilaçişlemleri();
            ilaçislem.MdiParent = this;
            ilaçislem.Show();
        }

        private void btn_kullanıcıgüncel_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            KULLANICIİŞLEMLERİ kullanıcı = new KULLANICIİŞLEMLERİ();
            kullanıcı.MdiParent = this;
            kullanıcı.Show();
        }

        private void btn_kullanıcısil_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            KULLANICIİŞLEMLERİ kullanıcı = new KULLANICIİŞLEMLERİ();
            kullanıcı.MdiParent = this;
            kullanıcı.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            registerform regis = new registerform();
            RANDEVU_İŞLEMLERİ randevu = new RANDEVU_İŞLEMLERİ();
            randevu.MdiParent = this;
            randevu.Show();
        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}