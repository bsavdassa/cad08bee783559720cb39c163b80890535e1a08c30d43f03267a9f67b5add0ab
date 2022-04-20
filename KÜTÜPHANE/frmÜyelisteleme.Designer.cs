namespace KÜTÜPHANE
{
    partial class frmÜyelisteleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜyelisteleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbKisicinsiyeti = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtOkuduğukitapsayısı = new System.Windows.Forms.TextBox();
            this.txtKisieposta = new System.Windows.Forms.TextBox();
            this.txtKisiadres = new System.Windows.Forms.TextBox();
            this.txtKisinintelefonu = new System.Windows.Forms.TextBox();
            this.txtKisininyaşı = new System.Windows.Forms.TextBox();
            this.txtKişininadısoyadı = new System.Windows.Forms.TextBox();
            this.txtKişinintcsi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtKisitcarama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbKisicinsiyeti
            // 
            this.cmbKisicinsiyeti.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKisicinsiyeti.FormattingEnabled = true;
            this.cmbKisicinsiyeti.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbKisicinsiyeti.Location = new System.Drawing.Point(174, 115);
            this.cmbKisicinsiyeti.Name = "cmbKisicinsiyeti";
            this.cmbKisicinsiyeti.Size = new System.Drawing.Size(100, 23);
            this.cmbKisicinsiyeti.TabIndex = 30;
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Black;
            this.btnİptal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİptal.ForeColor = System.Drawing.Color.Red;
            this.btnİptal.Location = new System.Drawing.Point(183, 308);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(81, 64);
            this.btnİptal.TabIndex = 29;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Red;
            this.btnGuncelle.Location = new System.Drawing.Point(100, 308);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 64);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtOkuduğukitapsayısı
            // 
            this.txtOkuduğukitapsayısı.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOkuduğukitapsayısı.Location = new System.Drawing.Point(174, 241);
            this.txtOkuduğukitapsayısı.Name = "txtOkuduğukitapsayısı";
            this.txtOkuduğukitapsayısı.Size = new System.Drawing.Size(100, 21);
            this.txtOkuduğukitapsayısı.TabIndex = 26;
            // 
            // txtKisieposta
            // 
            this.txtKisieposta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKisieposta.Location = new System.Drawing.Point(174, 215);
            this.txtKisieposta.Name = "txtKisieposta";
            this.txtKisieposta.Size = new System.Drawing.Size(100, 21);
            this.txtKisieposta.TabIndex = 25;
            // 
            // txtKisiadres
            // 
            this.txtKisiadres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKisiadres.Location = new System.Drawing.Point(174, 181);
            this.txtKisiadres.Name = "txtKisiadres";
            this.txtKisiadres.Size = new System.Drawing.Size(100, 21);
            this.txtKisiadres.TabIndex = 24;
            // 
            // txtKisinintelefonu
            // 
            this.txtKisinintelefonu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKisinintelefonu.Location = new System.Drawing.Point(174, 146);
            this.txtKisinintelefonu.Name = "txtKisinintelefonu";
            this.txtKisinintelefonu.Size = new System.Drawing.Size(100, 21);
            this.txtKisinintelefonu.TabIndex = 23;
            // 
            // txtKisininyaşı
            // 
            this.txtKisininyaşı.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKisininyaşı.Location = new System.Drawing.Point(174, 89);
            this.txtKisininyaşı.Name = "txtKisininyaşı";
            this.txtKisininyaşı.Size = new System.Drawing.Size(100, 21);
            this.txtKisininyaşı.TabIndex = 27;
            // 
            // txtKişininadısoyadı
            // 
            this.txtKişininadısoyadı.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKişininadısoyadı.Location = new System.Drawing.Point(174, 57);
            this.txtKişininadısoyadı.Name = "txtKişininadısoyadı";
            this.txtKişininadısoyadı.Size = new System.Drawing.Size(100, 21);
            this.txtKişininadısoyadı.TabIndex = 22;
            // 
            // txtKişinintcsi
            // 
            this.txtKişinintcsi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKişinintcsi.Location = new System.Drawing.Point(174, 22);
            this.txtKişinintcsi.Name = "txtKişinintcsi";
            this.txtKişinintcsi.Size = new System.Drawing.Size(100, 21);
            this.txtKişinintcsi.TabIndex = 21;
            this.txtKişinintcsi.TabStop = false;
            this.txtKişinintcsi.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(10, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Okuduğu kitap sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(75, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Epostası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(89, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(39, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kişinin telefonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(77, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cinsiyeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(61, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kişinin yaşı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kişinin adı Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kişi tcsi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(413, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Üye tcsi ile arama";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(13, 308);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 64);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtKisitcarama
            // 
            this.txtKisitcarama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKisitcarama.Location = new System.Drawing.Point(544, 351);
            this.txtKisitcarama.Name = "txtKisitcarama";
            this.txtKisitcarama.Size = new System.Drawing.Size(100, 21);
            this.txtKisitcarama.TabIndex = 32;
            this.txtKisitcarama.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // UyeListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(842, 433);
            this.Controls.Add(this.txtKisitcarama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbKisicinsiyeti);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOkuduğukitapsayısı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKisieposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKisiadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKisinintelefonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKisininyaşı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKişininadısoyadı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKişinintcsi);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye listeleme işlemleri Formu";
            this.Load += new System.EventHandler(this.UyeListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbKisicinsiyeti;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtOkuduğukitapsayısı;
        private System.Windows.Forms.TextBox txtKisieposta;
        private System.Windows.Forms.TextBox txtKisiadres;
        private System.Windows.Forms.TextBox txtKisinintelefonu;
        private System.Windows.Forms.TextBox txtKisininyaşı;
        private System.Windows.Forms.TextBox txtKişininadısoyadı;
        private System.Windows.Forms.TextBox txtKişinintcsi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtKisitcarama;
    }
}