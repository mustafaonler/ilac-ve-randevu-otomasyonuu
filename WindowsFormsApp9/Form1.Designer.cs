namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kayıtekrani = new System.Windows.Forms.Button();
            this.btn_hesapvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kayıtekrani
            // 
            this.btn_kayıtekrani.BackColor = System.Drawing.Color.White;
            this.btn_kayıtekrani.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kayıtekrani.BackgroundImage")));
            this.btn_kayıtekrani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayıtekrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıtekrani.Location = new System.Drawing.Point(12, 609);
            this.btn_kayıtekrani.Name = "btn_kayıtekrani";
            this.btn_kayıtekrani.Size = new System.Drawing.Size(298, 105);
            this.btn_kayıtekrani.TabIndex = 0;
            this.btn_kayıtekrani.UseVisualStyleBackColor = false;
            this.btn_kayıtekrani.Click += new System.EventHandler(this.btn_kayıtekrani_Click);
            // 
            // btn_hesapvar
            // 
            this.btn_hesapvar.BackColor = System.Drawing.Color.White;
            this.btn_hesapvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hesapvar.BackgroundImage")));
            this.btn_hesapvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hesapvar.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hesapvar.Location = new System.Drawing.Point(784, 609);
            this.btn_hesapvar.Name = "btn_hesapvar";
            this.btn_hesapvar.Size = new System.Drawing.Size(289, 105);
            this.btn_hesapvar.TabIndex = 1;
            this.btn_hesapvar.UseVisualStyleBackColor = false;
            this.btn_hesapvar.Click += new System.EventHandler(this.btn_hesapvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 719);
            this.Controls.Add(this.btn_hesapvar);
            this.Controls.Add(this.btn_kayıtekrani);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ilaç otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_kayıtekrani;
        private System.Windows.Forms.Button btn_hesapvar;
    }
}

