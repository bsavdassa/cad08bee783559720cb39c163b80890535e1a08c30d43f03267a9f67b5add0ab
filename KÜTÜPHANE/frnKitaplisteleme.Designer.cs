
namespace KÜTÜPHANE
{
    partial class frmKitaplisteleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitaplisteleme));
            this.cmbKitabınturu = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitabınbulunduğuraf = new System.Windows.Forms.TextBox();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.txtKitabınstoksayisi = new System.Windows.Forms.TextBox();
            this.txtKitabınsayfasayısı = new System.Windows.Forms.TextBox();
            this.txtYayınevi = new System.Windows.Forms.TextBox();
            this.txtKitabınyazari = new System.Windows.Forms.TextBox();
            this.txtKitabınadı = new System.Windows.Forms.TextBox();
            this.txtKitabınbarkodu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarkodarama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKitabınturu
            // 
            this.cmbKitabınturu.FormattingEnabled = true;
            this.cmbKitabınturu.Items.AddRange(new object[] {
            "Çocuk Kitapları",
            "Hikaye",
            "Roman"});
            this.cmbKitabınturu.Location = new System.Drawing.Point(199, 217);
            this.cmbKitabınturu.Name = "cmbKitabınturu";
            this.cmbKitabınturu.Size = new System.Drawing.Size(197, 21);
            this.cmbKitabınturu.TabIndex = 41;
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİptal.ForeColor = System.Drawing.Color.Red;
            this.btnİptal.Location = new System.Drawing.Point(126, 340);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(98, 71);
            this.btnİptal.TabIndex = 40;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Red;
            this.btnGüncelle.Location = new System.Drawing.Point(23, 340);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(81, 71);
            this.btnGüncelle.TabIndex = 39;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(451, 750);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Kitabın bulunduğu raf numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(84, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kitabın stok sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(158, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kitabın sayfa sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(100, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kitabın yayın evi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(114, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kitabın yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(125, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kitabın adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kitabın barkod numarası:";
            // 
            // txtKitabınbulunduğuraf
            // 
            this.txtKitabınbulunduğuraf.Location = new System.Drawing.Point(199, 299);
            this.txtKitabınbulunduğuraf.Name = "txtKitabınbulunduğuraf";
            this.txtKitabınbulunduğuraf.Size = new System.Drawing.Size(197, 20);
            this.txtKitabınbulunduğuraf.TabIndex = 29;
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Location = new System.Drawing.Point(523, 750);
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(197, 20);
            this.txtAçıklama.TabIndex = 28;
            // 
            // txtKitabınstoksayisi
            // 
            this.txtKitabınstoksayisi.Location = new System.Drawing.Point(199, 261);
            this.txtKitabınstoksayisi.Name = "txtKitabınstoksayisi";
            this.txtKitabınstoksayisi.Size = new System.Drawing.Size(197, 20);
            this.txtKitabınstoksayisi.TabIndex = 27;
            // 
            // txtKitabınsayfasayısı
            // 
            this.txtKitabınsayfasayısı.Location = new System.Drawing.Point(199, 171);
            this.txtKitabınsayfasayısı.Name = "txtKitabınsayfasayısı";
            this.txtKitabınsayfasayısı.Size = new System.Drawing.Size(197, 20);
            this.txtKitabınsayfasayısı.TabIndex = 26;
            // 
            // txtYayınevi
            // 
            this.txtYayınevi.Location = new System.Drawing.Point(199, 130);
            this.txtYayınevi.Name = "txtYayınevi";
            this.txtYayınevi.Size = new System.Drawing.Size(197, 20);
            this.txtYayınevi.TabIndex = 25;
            // 
            // txtKitabınyazari
            // 
            this.txtKitabınyazari.Location = new System.Drawing.Point(199, 91);
            this.txtKitabınyazari.Name = "txtKitabınyazari";
            this.txtKitabınyazari.Size = new System.Drawing.Size(197, 20);
            this.txtKitabınyazari.TabIndex = 24;
            // 
            // txtKitabınadı
            // 
            this.txtKitabınadı.Location = new System.Drawing.Point(199, 53);
            this.txtKitabınadı.Name = "txtKitabınadı";
            this.txtKitabınadı.Size = new System.Drawing.Size(197, 20);
            this.txtKitabınadı.TabIndex = 23;
            // 
            // txtKitabınbarkodu
            // 
            this.txtKitabınbarkodu.Location = new System.Drawing.Point(199, 14);
            this.txtKitabınbarkodu.Name = "txtKitabınbarkodu";
            this.txtKitabınbarkodu.Size = new System.Drawing.Size(197, 20);
            this.txtKitabınbarkodu.TabIndex = 22;
            this.txtKitabınbarkodu.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(458, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 328);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(256, 340);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 71);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(509, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Kitap barkodu arama";
            // 
            // txtBarkodarama
            // 
            this.txtBarkodarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodarama.Location = new System.Drawing.Point(692, 25);
            this.txtBarkodarama.Name = "txtBarkodarama";
            this.txtBarkodarama.Size = new System.Drawing.Size(197, 21);
            this.txtBarkodarama.TabIndex = 44;
            this.txtBarkodarama.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // KitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbKitabınturu);
            this.Controls.Add(this.txtBarkodarama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitabınbarkodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitabınadı);
            this.Controls.Add(this.txtKitabınyazari);
            this.Controls.Add(this.txtKitabınbulunduğuraf);
            this.Controls.Add(this.txtYayınevi);
            this.Controls.Add(this.txtAçıklama);
            this.Controls.Add(this.txtKitabınsayfasayısı);
            this.Controls.Add(this.txtKitabınstoksayisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap listeleme işlemleri Formu";
            this.Load += new System.EventHandler(this.KitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKitabınturu;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitabınbulunduğuraf;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.TextBox txtKitabınstoksayisi;
        private System.Windows.Forms.TextBox txtKitabınsayfasayısı;
        private System.Windows.Forms.TextBox txtYayınevi;
        private System.Windows.Forms.TextBox txtKitabınyazari;
        private System.Windows.Forms.TextBox txtKitabınadı;
        private System.Windows.Forms.TextBox txtKitabınbarkodu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarkodarama;
    }
}