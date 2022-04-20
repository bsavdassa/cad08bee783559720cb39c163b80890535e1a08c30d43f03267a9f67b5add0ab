using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE
{
    public partial class frmEmanetkitapverme : Form
    {
        public frmEmanetkitapverme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphaneotomasyonu.accdb;");
        DataSet daset = new DataSet();
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from sepetbilgisi ", baglanti);
            adtr.Fill(daset, "sepetbilgisi");
            dataGridView1.DataSource = daset.Tables["sepetbilgisi"];
            baglanti.Close();
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Sepet (barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values (@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            //barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) 
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNO.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazarı.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayısı.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepetinize eklenmiştir", "Ekleme İşlemi");
            daset.Tables["sepetbilgisi"].Clear();
            sepetlistele();
            lblkitapsayısı1.Text = "";
            kitapsayisi();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtKitapSayısı)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void kitapsayisi()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select sum(kitapsayisi) from sepetbilgisi", baglanti);
            lblKitapsayısı2.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }


        private void EmanetKitapVer_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from üyeler where tc like'" + txtTcarama.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKişininadısoyadı.Text = read["adsoyad"].ToString();
                txtKisininyaşı.Text = read["yas"].ToString();
                txtKisinintelefonnumaras.Text = read["telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("select sum(kitapsayisi) from emanet_kitaplar where tc='" + txtTcarama.Text + "'", baglanti);
            lblkitapsayısı1.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTcarama.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }


                }
                lblkitapsayısı1.Text = "";
            }
        }

        private void txtBarkodNO_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitaplar where barkodno like '" + txtBarkodNO.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdı.Text = read["kitapadi"].ToString();
                txtYazarı.Text = read["yazari"].ToString();
                txtYayınEvi.Text = read["yayinevi"].ToString();
                txtSayfaSayısı.Text = read["sayfasayisi"].ToString();

            }
            baglanti.Close();
            if (txtBarkodNO.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {

                        if (item != txtKitapSayısı)
                        {
                            item.Text = "";
                        }
                    }
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult dialog;
            dialog = MessageBox.Show("Kayıdı silmek istiyor musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from sepetbilgisi where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "' ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi", "Silme");
                daset.Tables["sepetbilgisi"].Clear();
                sepetlistele();
                lblkitapsayısı1.Text = "";
                kitapsayisi();
            }

        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapsayısı2.Text != "")
            {
                if (lblkitapsayısı1.Text == "" && int.Parse(lblKitapsayısı2.Text) <= 3 || lblkitapsayısı1.Text != "" && int.Parse(lblkitapsayısı1.Text) + int.Parse(lblkitapsayısı1.Text) <= 3)
                {
                    if (txtTcarama.Text != "" && txtKişininadısoyadı.Text != "" && txtKisininyaşı.Text != "" && txtKisinintelefonnumaras.Text != "")
                    {

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            OleDbCommand komut = new OleDbCommand("insert into emanet_kitaplar (tc,adsoyad,yas,telefon,barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi) ", baglanti);
                            komut.Parameters.AddWithValue("@tc", txtTcarama.Text);
                            komut.Parameters.AddWithValue("@adsoyad", txtKişininadısoyadı.Text);
                            komut.Parameters.AddWithValue("@yas", txtKisininyaşı.Text);
                            komut.Parameters.AddWithValue("@telefon", txtKisinintelefonnumaras.Text);
                            komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("@yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            OleDbCommand komut2 = new OleDbCommand("update üyeler set okudugukitap=okudugukitap+'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "'where tc='" + txtTcarama.Text + "'", baglanti);
                            komut2.ExecuteNonQuery();
                            OleDbCommand komut3 = new OleDbCommand("update kitaplar set stoksayisi=-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        OleDbCommand komut4 = new OleDbCommand("delete from sepetbilgisi", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap emanet verildi");
                        daset.Tables["sepetbilgisi"].Clear();
                        sepetlistele();
                        txtTcarama.Text = "";
                        lblkitapsayısı1.Text = "";
                        kitapsayisi();
                        lblkitapsayısı1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Üye ismi seçin");
                    }

                }

                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz");
                }
            }
            else
            {
                MessageBox.Show("Önce sepete kitap ekleyin");
            }

        }
    }
}
