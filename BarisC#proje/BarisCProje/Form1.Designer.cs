namespace BarisCProje
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
            this.grpboxkullanicigirisi = new System.Windows.Forms.GroupBox();
            this.cmbkullaniciadi = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Şifre = new System.Windows.Forms.Label();
            this.bttngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpboxkullanicigirisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxkullanicigirisi
            // 
            this.grpboxkullanicigirisi.Controls.Add(this.cmbkullaniciadi);
            this.grpboxkullanicigirisi.Controls.Add(this.pictureBox1);
            this.grpboxkullanicigirisi.Controls.Add(this.label1);
            this.grpboxkullanicigirisi.Controls.Add(this.Şifre);
            this.grpboxkullanicigirisi.Controls.Add(this.bttngiris);
            this.grpboxkullanicigirisi.Controls.Add(this.txtsifre);
            this.grpboxkullanicigirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxkullanicigirisi.Location = new System.Drawing.Point(56, 28);
            this.grpboxkullanicigirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxkullanicigirisi.Name = "grpboxkullanicigirisi";
            this.grpboxkullanicigirisi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxkullanicigirisi.Size = new System.Drawing.Size(688, 426);
            this.grpboxkullanicigirisi.TabIndex = 8;
            this.grpboxkullanicigirisi.TabStop = false;
            this.grpboxkullanicigirisi.Text = "Kullanıcı Giriş ";
            this.grpboxkullanicigirisi.Enter += new System.EventHandler(this.grpboxkullanicigirisi_Enter);
            // 
            // cmbkullaniciadi
            // 
            this.cmbkullaniciadi.FormattingEnabled = true;
            this.cmbkullaniciadi.Items.AddRange(new object[] {
            "admin"});
            this.cmbkullaniciadi.Location = new System.Drawing.Point(323, 199);
            this.cmbkullaniciadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbkullaniciadi.Name = "cmbkullaniciadi";
            this.cmbkullaniciadi.Size = new System.Drawing.Size(188, 33);
            this.cmbkullaniciadi.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı :";
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.Location = new System.Drawing.Point(203, 261);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(63, 25);
            this.Şifre.TabIndex = 1;
            this.Şifre.Text = "Şifre :";
            // 
            // bttngiris
            // 
            this.bttngiris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttngiris.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttngiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttngiris.Location = new System.Drawing.Point(245, 345);
            this.bttngiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttngiris.Name = "bttngiris";
            this.bttngiris.Size = new System.Drawing.Size(157, 39);
            this.bttngiris.TabIndex = 4;
            this.bttngiris.Text = "Giriş Yap";
            this.bttngiris.UseVisualStyleBackColor = false;
            this.bttngiris.Click += new System.EventHandler(this.bttngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(323, 261);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(188, 30);
            this.txtsifre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 523);
            this.Controls.Add(this.grpboxkullanicigirisi);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Akademisyen Giriş Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxkullanicigirisi.ResumeLayout(false);
            this.grpboxkullanicigirisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxkullanicigirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Şifre;
        private System.Windows.Forms.Button bttngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbkullaniciadi;
    }
}

