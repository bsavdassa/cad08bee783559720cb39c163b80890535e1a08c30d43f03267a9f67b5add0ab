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
    public partial class frmEmanetKitap : Form
    {
        public frmEmanetKitap()
        {
            InitializeComponent();
        }
        DataSet set = new DataSet();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;Persist Security Info=False;");
        private void EmanetListele()
        {
            baglanti.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from emanet_kitap", baglanti);
            adapter.Fill(set, "kitaplar");
            dataGridView1.DataSource = set.Tables["kitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapİade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            set.Tables["kitaplar"].Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from emanet_kitap where tc like '%" + txtKisitcarama.Text + "%'", baglanti);
            adapter.Fill(set, "kitaplar");
            baglanti.Close();
            if (txtKisitcarama.Text == null)
            {
                set.Tables["kitaplar"].Clear();
                EmanetListele();
            }
        }

        private void txtBarkodara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            set.Tables["kitaplar"].Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from emanet_kitap where barkodno like '%" + txtkitapbarkodarama.Text + "%'", baglanti);
            adapter.Fill(set, "kitaplar");
            baglanti.Close();
            if (txtkitapbarkodarama.Text == null)
            {
                set.Tables["kitaplar"].Clear();
                EmanetListele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from emanet_kitap where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("update kitaplar set stoksayisi=stoksayisi+'" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() + "'where barkodno=@barkodno", baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitaplar teslim edildi");
            set.Tables["kitaplar"].Clear();
            EmanetListele();
        }
    }
}
