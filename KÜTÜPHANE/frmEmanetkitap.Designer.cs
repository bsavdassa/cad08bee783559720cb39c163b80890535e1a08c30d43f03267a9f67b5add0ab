
namespace KÜTÜPHANE
{
    partial class frmEmanetKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmanetKitap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtKisitcarama = new System.Windows.Forms.TextBox();
            this.txtkitapbarkodarama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnTeslim
            // 
            this.btnTeslim.BackColor = System.Drawing.Color.Black;
            this.btnTeslim.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeslim.ForeColor = System.Drawing.Color.Red;
            this.btnTeslim.Location = new System.Drawing.Point(674, 55);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(75, 65);
            this.btnTeslim.TabIndex = 2;
            this.btnTeslim.Text = "Teslim";
            this.btnTeslim.UseVisualStyleBackColor = false;
            this.btnTeslim.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Black;
            this.btnİptal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİptal.ForeColor = System.Drawing.Color.Red;
            this.btnİptal.Location = new System.Drawing.Point(674, 196);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 65);
            this.btnİptal.TabIndex = 3;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKisitcarama
            // 
            this.txtKisitcarama.Location = new System.Drawing.Point(448, 319);
            this.txtKisitcarama.Name = "txtKisitcarama";
            this.txtKisitcarama.Size = new System.Drawing.Size(100, 20);
            this.txtKisitcarama.TabIndex = 4;
            this.txtKisitcarama.TextChanged += new System.EventHandler(this.txtTCAra_TextChanged);
            // 
            // txtkitapbarkodarama
            // 
            this.txtkitapbarkodarama.Location = new System.Drawing.Point(186, 307);
            this.txtkitapbarkodarama.Name = "txtkitapbarkodarama";
            this.txtkitapbarkodarama.Size = new System.Drawing.Size(100, 20);
            this.txtkitapbarkodarama.TabIndex = 5;
            this.txtkitapbarkodarama.TextChanged += new System.EventHandler(this.txtBarkodara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(337, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kişi tcsi arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(63, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap barkodu arama:";
            // 
            // frmEmanetkitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.txtkitapbarkodarama);
            this.Controls.Add(this.txtKisitcarama);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmanetkitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet kitap iade Formu";
            this.Load += new System.EventHandler(this.EmanetKitapİade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtKisitcarama;
        private System.Windows.Forms.TextBox txtkitapbarkodarama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}