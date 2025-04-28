namespace WindowsFormsApp9
{
    partial class RANDEVU_İŞLEMLERİ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RANDEVU_İŞLEMLERİ));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.cmbbölüm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbdoktor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_kullanıcıadı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cmb_dokotrsil = new System.Windows.Forms.ComboBox();
            this.cmb_bölümsil = new System.Windows.Forms.ComboBox();
            this.txt_tarihsil = new System.Windows.Forms.TextBox();
            this.txt_saatsil = new System.Windows.Forms.TextBox();
            this.txt_kullanıcıadısil = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.controlRandevular = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.otomasyonDataSet = new WindowsFormsApp9.otomasyonDataSet();
            this.otomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölüm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdoktor.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlRandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otomasyonDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(603, 836);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.button2);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.txt_saat);
            this.xtraTabPage2.Controls.Add(this.txt_tarih);
            this.xtraTabPage2.Controls.Add(this.cmbbölüm);
            this.xtraTabPage2.Controls.Add(this.cmbdoktor);
            this.xtraTabPage2.Controls.Add(this.button1);
            this.xtraTabPage2.Controls.Add(this.txt_kullanıcıadı);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(596, 786);
            this.xtraTabPage2.Text = "RANDEVU EKLE";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(321, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 105);
            this.button2.TabIndex = 23;
            this.button2.Text = "RANDEVU LİSTELE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "SAAT :";
            // 
            // txt_saat
            // 
            this.txt_saat.BackColor = System.Drawing.Color.Silver;
            this.txt_saat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_saat.Location = new System.Drawing.Point(378, 278);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(195, 28);
            this.txt_saat.TabIndex = 21;
            // 
            // txt_tarih
            // 
            this.txt_tarih.BackColor = System.Drawing.Color.Silver;
            this.txt_tarih.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarih.Location = new System.Drawing.Point(378, 162);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(195, 28);
            this.txt_tarih.TabIndex = 20;
            // 
            // cmbbölüm
            // 
            this.cmbbölüm.Location = new System.Drawing.Point(378, 390);
            this.cmbbölüm.Name = "cmbbölüm";
            this.cmbbölüm.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.cmbbölüm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbölüm.Properties.Appearance.Options.UseBackColor = true;
            this.cmbbölüm.Properties.Appearance.Options.UseFont = true;
            this.cmbbölüm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbölüm.Properties.Items.AddRange(new object[] {
            "Ortopedi",
            "Aile hekimliği",
            "Dahiliye",
            "İnsan hastalıkları"});
            this.cmbbölüm.Size = new System.Drawing.Size(195, 28);
            this.cmbbölüm.TabIndex = 19;
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.Location = new System.Drawing.Point(378, 511);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.cmbdoktor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdoktor.Properties.Appearance.Options.UseBackColor = true;
            this.cmbdoktor.Properties.Appearance.Options.UseFont = true;
            this.cmbdoktor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbdoktor.Properties.Items.AddRange(new object[] {
            "Dr.Mehmet can",
            "Dr.Ahmet enes",
            "Dr.Yusuf erge",
            "Dr.Mustafa önler"});
            this.cmbdoktor.Size = new System.Drawing.Size(195, 28);
            this.cmbdoktor.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(30, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 105);
            this.button1.TabIndex = 10;
            this.button1.Text = "RANDEVU AL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_kullanıcıadı
            // 
            this.txt_kullanıcıadı.BackColor = System.Drawing.Color.Silver;
            this.txt_kullanıcıadı.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanıcıadı.Location = new System.Drawing.Point(378, 53);
            this.txt_kullanıcıadı.Name = "txt_kullanıcıadı";
            this.txt_kullanıcıadı.Size = new System.Drawing.Size(195, 28);
            this.txt_kullanıcıadı.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOKTOR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "BÖLÜM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TARİH :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cmb_dokotrsil);
            this.xtraTabPage1.Controls.Add(this.cmb_bölümsil);
            this.xtraTabPage1.Controls.Add(this.txt_tarihsil);
            this.xtraTabPage1.Controls.Add(this.txt_saatsil);
            this.xtraTabPage1.Controls.Add(this.txt_kullanıcıadısil);
            this.xtraTabPage1.Controls.Add(this.button3);
            this.xtraTabPage1.Controls.Add(this.label11);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.label9);
            this.xtraTabPage1.Controls.Add(this.label8);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(608, 786);
            this.xtraTabPage1.Text = "RANDEVU SİL";
            // 
            // cmb_dokotrsil
            // 
            this.cmb_dokotrsil.BackColor = System.Drawing.Color.Silver;
            this.cmb_dokotrsil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_dokotrsil.FormattingEnabled = true;
            this.cmb_dokotrsil.Items.AddRange(new object[] {
            "Dr.Mehmet can",
            "Dr.Ahmet enes",
            "Dr.Yusuf erge",
            "Dr.Mustafa önler"});
            this.cmb_dokotrsil.Location = new System.Drawing.Point(329, 560);
            this.cmb_dokotrsil.Name = "cmb_dokotrsil";
            this.cmb_dokotrsil.Size = new System.Drawing.Size(205, 29);
            this.cmb_dokotrsil.TabIndex = 11;
            // 
            // cmb_bölümsil
            // 
            this.cmb_bölümsil.BackColor = System.Drawing.Color.Silver;
            this.cmb_bölümsil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_bölümsil.FormattingEnabled = true;
            this.cmb_bölümsil.Items.AddRange(new object[] {
            "Ortopedi",
            "Aile hekimliği",
            "Dahiliye",
            "İnsan hastalıkları"});
            this.cmb_bölümsil.Location = new System.Drawing.Point(329, 423);
            this.cmb_bölümsil.Name = "cmb_bölümsil";
            this.cmb_bölümsil.Size = new System.Drawing.Size(205, 29);
            this.cmb_bölümsil.TabIndex = 10;
            // 
            // txt_tarihsil
            // 
            this.txt_tarihsil.BackColor = System.Drawing.Color.Silver;
            this.txt_tarihsil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarihsil.Location = new System.Drawing.Point(329, 175);
            this.txt_tarihsil.Name = "txt_tarihsil";
            this.txt_tarihsil.Size = new System.Drawing.Size(205, 28);
            this.txt_tarihsil.TabIndex = 9;
            // 
            // txt_saatsil
            // 
            this.txt_saatsil.BackColor = System.Drawing.Color.Silver;
            this.txt_saatsil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_saatsil.Location = new System.Drawing.Point(329, 289);
            this.txt_saatsil.Name = "txt_saatsil";
            this.txt_saatsil.Size = new System.Drawing.Size(205, 28);
            this.txt_saatsil.TabIndex = 8;
            this.txt_saatsil.TextChanged += new System.EventHandler(this.txt_saatsil_TextChanged);
            // 
            // txt_kullanıcıadısil
            // 
            this.txt_kullanıcıadısil.BackColor = System.Drawing.Color.Silver;
            this.txt_kullanıcıadısil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanıcıadısil.Location = new System.Drawing.Point(329, 53);
            this.txt_kullanıcıadısil.Name = "txt_kullanıcıadısil";
            this.txt_kullanıcıadısil.Size = new System.Drawing.Size(205, 28);
            this.txt_kullanıcıadısil.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(116, 619);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 83);
            this.button3.TabIndex = 7;
            this.button3.Text = "RANDEVU SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(24, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "BÖLÜM :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(24, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "DOKTOR :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "SAAT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "TARİH :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "KULLANICI ADI :";
            // 
            // controlRandevular
            // 
            this.controlRandevular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.controlRandevular.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlRandevular.Location = new System.Drawing.Point(528, 0);
            this.controlRandevular.MainView = this.gridView1;
            this.controlRandevular.Name = "controlRandevular";
            this.controlRandevular.Size = new System.Drawing.Size(999, 766);
            this.controlRandevular.TabIndex = 24;
            this.controlRandevular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.controlRandevular.Click += new System.EventHandler(this.controlRandevular_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.controlRandevular;
            this.gridView1.Name = "gridView1";
            // 
            // otomasyonDataSet
            // 
            this.otomasyonDataSet.DataSetName = "otomasyonDataSet";
            this.otomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otomasyonDataSetBindingSource
            // 
            this.otomasyonDataSetBindingSource.DataSource = this.otomasyonDataSet;
            this.otomasyonDataSetBindingSource.Position = 0;
            // 
            // RANDEVU_İŞLEMLERİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 766);
            this.Controls.Add(this.controlRandevular);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "RANDEVU_İŞLEMLERİ";
            this.Text = "RANDEVU_İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbölüm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdoktor.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlRandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otomasyonDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_kullanıcıadı;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbölüm;
        private DevExpress.XtraEditors.ComboBoxEdit cmbdoktor;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl controlRandevular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource otomasyonDataSetBindingSource;
        private otomasyonDataSet otomasyonDataSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_dokotrsil;
        private System.Windows.Forms.ComboBox cmb_bölümsil;
        private System.Windows.Forms.TextBox txt_tarihsil;
        private System.Windows.Forms.TextBox txt_saatsil;
        private System.Windows.Forms.TextBox txt_kullanıcıadısil;
        private System.Windows.Forms.Button button3;
    }
}