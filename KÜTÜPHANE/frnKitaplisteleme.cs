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
    public partial class frmKitaplisteleme : Form
    {
        public frmKitaplisteleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;");
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from kitaplar ", baglanti);
            adtr.Fill(daset, "kitapbilgisi");
            dataGridView1.DataSource = daset.Tables["kitapbilgisi"];
            baglanti.Close();
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitaplar set barkodno=@barkodno,kitapadi=@kitapadi,yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno ", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtKitabınbarkodu.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitabınadı.Text);
            komut.Parameters.AddWithValue("@yazari", txtKitabınyazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtKitabınsayfasayısı.Text);
            komut.Parameters.AddWithValue("@turu", cmbKitabınturu.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtKitabınstoksayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtKitabınbulunduğuraf.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAçıklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti!");
            daset.Tables["kitapbilgisi"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Kaydı silmek istiyor musunuz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from kitaplar where barkodno =@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılır!");
                daset.Tables["kitapbilgisi"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitapbilgisi"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from kitaplar where barkodno like '%" + txtBarkodarama.Text + "%'", baglanti);
            adtr.Fill(daset, "kitapbilgisi");
            dataGridView1.DataSource = daset.Tables["kitapbilgisi"];
            baglanti.Close();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitaplar where barkodno like '" + txtKitabınbarkodu.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitabınadı.Text = read["kitapadi"].ToString();
                txtKitabınyazari.Text = read["yazari"].ToString();
                txtYayınevi.Text = read["yayinevi"].ToString();
                txtKitabınsayfasayısı.Text = read["sayfasayisi"].ToString();
                cmbKitabınturu.Text = read["turu"].ToString();
                txtKitabınstoksayisi.Text = read["stoksayisi"].ToString();
                txtKitabınbulunduğuraf.Text = read["rafno"].ToString();
                txtAçıklama.Text = read["aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitabınbarkodu.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
        }
    }
}
