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
    public partial class frmEmanetkitaplistele : Form
    {
        public frmEmanetkitaplistele()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphaneotomasyonu.accdb;");
        DataSet daset = new DataSet();
        private void EmanetKitapListele_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanet_kitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                EmanetListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {



                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanet_kitaplar where '" + DateTime.Now.ToShortTimeString() + "'>iadetarihi", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {



                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from emanet_kitaplar where '" + DateTime.Now.ToShortTimeString() + "'<=iadetarihi", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                baglanti.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
