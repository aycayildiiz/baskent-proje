namespace BarisCProje
{
    partial class Yeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni));
            this.btnakademisyenler = new System.Windows.Forms.Button();
            this.btnogrenciler = new System.Windows.Forms.Button();
            this.btnbitirmeprojeleri = new System.Windows.Forms.Button();
            this.btngenelliste = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnakademisyenler
            // 
            this.btnakademisyenler.Location = new System.Drawing.Point(37, 32);
            this.btnakademisyenler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnakademisyenler.Name = "btnakademisyenler";
            this.btnakademisyenler.Size = new System.Drawing.Size(144, 62);
            this.btnakademisyenler.TabIndex = 0;
            this.btnakademisyenler.Text = "Akademisyenler";
            this.btnakademisyenler.UseVisualStyleBackColor = true;
            this.btnakademisyenler.Click += new System.EventHandler(this.btnakademisyenler_Click);
            // 
            // btnogrenciler
            // 
            this.btnogrenciler.Location = new System.Drawing.Point(241, 34);
            this.btnogrenciler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnogrenciler.Name = "btnogrenciler";
            this.btnogrenciler.Size = new System.Drawing.Size(144, 60);
            this.btnogrenciler.TabIndex = 1;
            this.btnogrenciler.Text = "Öğrenciler";
            this.btnogrenciler.UseVisualStyleBackColor = true;
            this.btnogrenciler.Click += new System.EventHandler(this.btnogrenciler_Click);
            // 
            // btnbitirmeprojeleri
            // 
            this.btnbitirmeprojeleri.Location = new System.Drawing.Point(37, 128);
            this.btnbitirmeprojeleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbitirmeprojeleri.Name = "btnbitirmeprojeleri";
            this.btnbitirmeprojeleri.Size = new System.Drawing.Size(144, 57);
            this.btnbitirmeprojeleri.TabIndex = 2;
            this.btnbitirmeprojeleri.Text = "Bitirme Projeleri";
            this.btnbitirmeprojeleri.UseVisualStyleBackColor = true;
            this.btnbitirmeprojeleri.Click += new System.EventHandler(this.btnbitirmeprojeleri_Click);
            // 
            // btngenelliste
            // 
            this.btngenelliste.Location = new System.Drawing.Point(241, 128);
            this.btngenelliste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngenelliste.Name = "btngenelliste";
            this.btngenelliste.Size = new System.Drawing.Size(144, 57);
            this.btngenelliste.TabIndex = 3;
            this.btngenelliste.Text = "Genel Liste";
            this.btngenelliste.UseVisualStyleBackColor = true;
            this.btngenelliste.Click += new System.EventHandler(this.btngenelliste_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnogrenciler);
            this.panel1.Controls.Add(this.btngenelliste);
            this.panel1.Controls.Add(this.btnakademisyenler);
            this.panel1.Controls.Add(this.btnbitirmeprojeleri);
            this.panel1.Location = new System.Drawing.Point(149, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 217);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "BİTİRME PROJELERİ YÖNETİM SİSTEMİ";
            // 
            // Yeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Yeni";
            this.Text = "BPYS";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnakademisyenler;
        private System.Windows.Forms.Button btnogrenciler;
        private System.Windows.Forms.Button btnbitirmeprojeleri;
        private System.Windows.Forms.Button btngenelliste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}