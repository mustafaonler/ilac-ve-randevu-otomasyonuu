namespace WindowsFormsApp9
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_devamet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_devamet
            // 
            this.btn_devamet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_devamet.BackgroundImage")));
            this.btn_devamet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_devamet.Location = new System.Drawing.Point(803, 639);
            this.btn_devamet.Name = "btn_devamet";
            this.btn_devamet.Size = new System.Drawing.Size(242, 110);
            this.btn_devamet.TabIndex = 0;
            this.btn_devamet.UseVisualStyleBackColor = true;
            this.btn_devamet.Click += new System.EventHandler(this.btn_devamet_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 772);
            this.Controls.Add(this.btn_devamet);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_devamet;
    }
}