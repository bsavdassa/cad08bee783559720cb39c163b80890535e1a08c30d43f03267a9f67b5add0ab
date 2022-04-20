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
    public partial class frmÜyelisteleme : Form
    {
        public frmÜyelisteleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphaneotomasyonu.accdb;");
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from üyeler where tc like '" + txtKişinintcsi.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKişininadısoyadı.Text = read["adsoyad"].ToString();
                txtKisininyaşı.Text = read["yas"].ToString();
                cmbKisicinsiyeti.Text = read["cinsiyet"].ToString();
                txtKisinintelefonu.Text = read["telefon"].ToString();
                txtKisiadres.Text = read["adres"].ToString();
                txtKisieposta.Text = read["email"].ToString();
                txtOkuduğukitapsayısı.Text = read["okudugukitap"].ToString();
            }
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKişinintcsi.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        DataSet daset = new DataSet();
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["üyebilgileri"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from üyeler where tc like '%" + txtKisitcarama.Text + "%'", baglanti);
            adtr.Fill(daset, "üyebilgileri");
            dataGridView1.DataSource = daset.Tables["üyebilgileri"];
            baglanti.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Kaydı silmek istiyor musunuz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from üyeler where tc =@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılır!");
                daset.Tables["üyebilgileri"].Clear();
                uyelistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

        }
        private void uyelistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from üyeler ", baglanti);
            adtr.Fill(daset, "üyebilgileri");
            dataGridView1.DataSource = daset.Tables["üyebilgileri"];
            baglanti.Close();
        }
        private void UyeListeleme_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update üyeler set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okudugukitap=@okudugukitap where tc=@tc", baglanti);
            //adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okudugukitap=@okudugukitap where tc=@tc"
            komut.Parameters.AddWithValue("@tc", txtKişinintcsi.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtKişininadısoyadı.Text);
            komut.Parameters.AddWithValue("@yas", txtKisininyaşı.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbKisicinsiyeti.Text);
            komut.Parameters.AddWithValue("@telefon", txtKisinintelefonu.Text);
            komut.Parameters.AddWithValue("@adres", txtKisiadres.Text);
            komut.Parameters.AddWithValue("@email", txtKisieposta.Text);
            komut.Parameters.AddWithValue("@okudugukitap", int.Parse(txtOkuduğukitapsayısı.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti!");
            daset.Tables["üyebilgileri"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

    }



}

