using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace KÜTÜPHANE
{
    public partial class frmÜyeekleme : Form
    {
        public frmÜyeekleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into üyeler(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okudugukitap) values (@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okudugukitap)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTcnumarasi.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtKisininadiSoyadi.Text);
            komut.Parameters.AddWithValue("@yas", txtyasi.Text.ToString());
            komut.Parameters.AddWithValue("@cinsiyet", cmbKisicinsiyeti.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefonu.Text);
            komut.Parameters.AddWithValue("@adres", txtAdresi.Text);
            komut.Parameters.AddWithValue("@email", txtkisininepostası.Text);
            komut.Parameters.AddWithValue("@okudugukitap", int.Parse(txtOkudugukitapsaısı.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Sisteme Eklendi !!");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtOkudugukitapsaısı)
                    {
                        item.Text = "";
                    }


                }
            }
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
