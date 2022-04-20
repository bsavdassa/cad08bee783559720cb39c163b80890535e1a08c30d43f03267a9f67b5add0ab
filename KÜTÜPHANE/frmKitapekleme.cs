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
    public partial class frmKitapekleme : Form
    {
        public frmKitapekleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;");
        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kitaplar(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi) values (@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", baglanti);
            //barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi
            komut.Parameters.AddWithValue("@barkodno", txtKitabınbarkodnumarası.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitabınadı.Text);
            komut.Parameters.AddWithValue("@yazari", txtKitabınyazarı.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtKitabınsayfasayisi.Text);
            komut.Parameters.AddWithValue("@turu", cmbKitabıntuırı.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtkitabınsayısı.Text);
            komut.Parameters.AddWithValue("@rafno", txtkitabınrafnumarası.Text);
            komut.Parameters.AddWithValue("@aciklama", txtKitabınaçıklaması.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kayıtı Sisteme Eklendi !!");
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
