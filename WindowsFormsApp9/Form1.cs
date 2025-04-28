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

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-RCG9EPL\SQLEXPRESS01;Initial Catalog=otomasyon;User ID=sa;Password=1");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_kayıtekrani_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
           
        }

        private void btn_hesapvar_Click(object sender, EventArgs e)
        {
            this.Hide();// Ana formu gizle*/
            loginform login = new loginform();
            login.ShowDialog();
           
        }

        private void lbl_2_Click(object sender, EventArgs e)
        {

        }
    }
}
