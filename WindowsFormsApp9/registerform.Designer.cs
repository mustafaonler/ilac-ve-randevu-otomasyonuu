namespace WindowsFormsApp9
{
    partial class registerform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerform));
            this.lbl_şifre = new System.Windows.Forms.Label();
            this.lbl_kulanıcı_adı = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_kulanıcıadı = new System.Windows.Forms.TextBox();
            this.txt_şifre = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_şifre
            // 
            this.lbl_şifre.AutoSize = true;
            this.lbl_şifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_şifre.Location = new System.Drawing.Point(304, 527);
            this.lbl_şifre.Name = "lbl_şifre";
            this.lbl_şifre.Size = new System.Drawing.Size(162, 25);
            this.lbl_şifre.TabIndex = 4;
            this.lbl_şifre.Text = "şifrenizi giriniz :";
            // 
            // lbl_kulanıcı_adı
            // 
            this.lbl_kulanıcı_adı.AutoSize = true;
            this.lbl_kulanıcı_adı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_kulanıcı_adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kulanıcı_adı.Location = new System.Drawing.Point(305, 390);
            this.lbl_kulanıcı_adı.Name = "lbl_kulanıcı_adı";
            this.lbl_kulanıcı_adı.Size = new System.Drawing.Size(221, 24);
            this.lbl_kulanıcı_adı.TabIndex = 3;
            this.lbl_kulanıcı_adı.Text = "kulanıcı adınızı giriniz :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.Location = new System.Drawing.Point(304, 261);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(193, 25);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "soyisminizi giriniz :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(307, 125);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(159, 25);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "isminizi giriniz :";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_soyisim.Location = new System.Drawing.Point(609, 265);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(194, 22);
            this.txt_soyisim.TabIndex = 1;
            // 
            // txt_kulanıcıadı
            // 
            this.txt_kulanıcıadı.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_kulanıcıadı.Location = new System.Drawing.Point(609, 390);
            this.txt_kulanıcıadı.Name = "txt_kulanıcıadı";
            this.txt_kulanıcıadı.Size = new System.Drawing.Size(194, 22);
            this.txt_kulanıcıadı.TabIndex = 3;
            this.txt_kulanıcıadı.TextChanged += new System.EventHandler(this.txt_kulanıcıadı_TextChanged);
            // 
            // txt_şifre
            // 
            this.txt_şifre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_şifre.Location = new System.Drawing.Point(609, 527);
            this.txt_şifre.Name = "txt_şifre";
            this.txt_şifre.Size = new System.Drawing.Size(194, 22);
            this.txt_şifre.TabIndex = 4;
            // 
            // txt_isim
            // 
            this.txt_isim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_isim.Location = new System.Drawing.Point(609, 129);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(194, 22);
            this.txt_isim.TabIndex = 0;
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.BackColor = System.Drawing.Color.Transparent;
            this.btn_kayıt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kayıt.BackgroundImage")));
            this.btn_kayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.Location = new System.Drawing.Point(82, 618);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(280, 93);
            this.btn_kayıt.TabIndex = 3;
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(739, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 92);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 739);
            this.Controls.Add(this.txt_şifre);
            this.Controls.Add(this.txt_kulanıcıadı);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.lbl_şifre);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_kulanıcı_adı);
            this.Controls.Add(this.btn_kayıt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "registerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.registerform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_şifre;
        private System.Windows.Forms.Label lbl_kulanıcı_adı;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_kulanıcıadı;
        private System.Windows.Forms.TextBox txt_şifre;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.Button button1;
    }
}