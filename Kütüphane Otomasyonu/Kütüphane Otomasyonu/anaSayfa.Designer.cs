
namespace Kütüphane_Otomasyonu
{
    partial class frmAnaSayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListeleme = new System.Windows.Forms.Button();
            this.btnUyeEkleme = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListeleme = new System.Windows.Forms.Button();
            this.btnKitapEkleme = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetKitapİade = new System.Windows.Forms.Button();
            this.btnEmanetKitapListeleme = new System.Windows.Forms.Button();
            this.btnEmanetKitapVerme = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListeleme);
            this.groupBox1.Controls.Add(this.btnUyeEkleme);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(67, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üyelik İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUyeListeleme
            // 
            this.btnUyeListeleme.Location = new System.Drawing.Point(26, 89);
            this.btnUyeListeleme.Name = "btnUyeListeleme";
            this.btnUyeListeleme.Size = new System.Drawing.Size(199, 43);
            this.btnUyeListeleme.TabIndex = 1;
            this.btnUyeListeleme.Text = "Üye Listeleme İşlemleri";
            this.btnUyeListeleme.UseVisualStyleBackColor = true;
            this.btnUyeListeleme.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUyeEkleme
            // 
            this.btnUyeEkleme.Location = new System.Drawing.Point(26, 28);
            this.btnUyeEkleme.Name = "btnUyeEkleme";
            this.btnUyeEkleme.Size = new System.Drawing.Size(199, 39);
            this.btnUyeEkleme.TabIndex = 0;
            this.btnUyeEkleme.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEkleme.UseVisualStyleBackColor = true;
            this.btnUyeEkleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnKitapListeleme);
            this.groupBox2.Controls.Add(this.btnKitapEkleme);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(447, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapListeleme
            // 
            this.btnKitapListeleme.Location = new System.Drawing.Point(18, 89);
            this.btnKitapListeleme.Name = "btnKitapListeleme";
            this.btnKitapListeleme.Size = new System.Drawing.Size(211, 44);
            this.btnKitapListeleme.TabIndex = 2;
            this.btnKitapListeleme.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListeleme.UseVisualStyleBackColor = true;
            this.btnKitapListeleme.Click += new System.EventHandler(this.btnKitapListeleme_Click);
            // 
            // btnKitapEkleme
            // 
            this.btnKitapEkleme.Location = new System.Drawing.Point(18, 28);
            this.btnKitapEkleme.Name = "btnKitapEkleme";
            this.btnKitapEkleme.Size = new System.Drawing.Size(211, 42);
            this.btnKitapEkleme.TabIndex = 1;
            this.btnKitapEkleme.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkleme.UseVisualStyleBackColor = true;
            this.btnKitapEkleme.Click += new System.EventHandler(this.btnKitapEkleme_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetKitapİade);
            this.groupBox3.Controls.Add(this.btnEmanetKitapListeleme);
            this.groupBox3.Controls.Add(this.btnEmanetKitapVerme);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(67, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetKitapİade
            // 
            this.btnEmanetKitapİade.Location = new System.Drawing.Point(26, 154);
            this.btnEmanetKitapİade.Name = "btnEmanetKitapİade";
            this.btnEmanetKitapİade.Size = new System.Drawing.Size(205, 43);
            this.btnEmanetKitapİade.TabIndex = 3;
            this.btnEmanetKitapİade.Text = "Emanet Kitap İade İşlemi";
            this.btnEmanetKitapİade.UseVisualStyleBackColor = true;
            this.btnEmanetKitapİade.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEmanetKitapListeleme
            // 
            this.btnEmanetKitapListeleme.Location = new System.Drawing.Point(26, 91);
            this.btnEmanetKitapListeleme.Name = "btnEmanetKitapListeleme";
            this.btnEmanetKitapListeleme.Size = new System.Drawing.Size(205, 41);
            this.btnEmanetKitapListeleme.TabIndex = 2;
            this.btnEmanetKitapListeleme.Text = "Emanet Kitap Listeleme İşlemi";
            this.btnEmanetKitapListeleme.UseVisualStyleBackColor = true;
            // 
            // btnEmanetKitapVerme
            // 
            this.btnEmanetKitapVerme.Location = new System.Drawing.Point(26, 26);
            this.btnEmanetKitapVerme.Name = "btnEmanetKitapVerme";
            this.btnEmanetKitapVerme.Size = new System.Drawing.Size(205, 40);
            this.btnEmanetKitapVerme.TabIndex = 1;
            this.btnEmanetKitapVerme.Text = "Emanet Kitap Verme İşlemi";
            this.btnEmanetKitapVerme.UseVisualStyleBackColor = true;
            this.btnEmanetKitapVerme.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.groupBox4.Location = new System.Drawing.Point(447, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 169);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafik İşlemleri";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(24, 82);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(205, 47);
            this.btnGrafik.TabIndex = 2;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            // 
            // btnSıralama
            // 
            this.btnSıralama.Location = new System.Drawing.Point(24, 38);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(205, 38);
            this.btnSıralama.TabIndex = 1;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.UseVisualStyleBackColor = true;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.libözel;
            this.ClientSize = new System.Drawing.Size(901, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "frmAnaSayfa";
            this.Opacity = 0D;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUyeListeleme;
        private System.Windows.Forms.Button btnUyeEkleme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapListeleme;
        private System.Windows.Forms.Button btnKitapEkleme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEmanetKitapListeleme;
        private System.Windows.Forms.Button btnEmanetKitapVerme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSıralama;
        private System.Windows.Forms.Button btnEmanetKitapİade;
    }
}

