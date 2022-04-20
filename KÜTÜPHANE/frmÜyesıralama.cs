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
    public partial class frmÜyesıralama : Form
    {
        public frmÜyesıralama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphaneotomasyonu.accdb;");
        DataSet set = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Sıralama_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from üyeler order by okudugukitap desc", baglanti);
            adtr.Fill(set, "üyebilgileri");
            dataGridView1.DataSource = set.Tables["üyebilgileri"];
            baglanti.Close();
            label3.Text = null;
            label4.Text = null;
            label3.Text = set.Tables["üyebilgileri"].Rows[0]["adsoyad"].ToString() + " = ";
            label3.Text += set.Tables["üyebilgileri"].Rows[0]["okudugukitap"].ToString();
            label4.Text = set.Tables["üyebilgileri"].Rows[dataGridView1.Rows.Count - 2]["adsoyad"].ToString() + " = ";
            label4.Text += set.Tables["üyebilgileri"].Rows[dataGridView1.Rows.Count - 2]["okudugukitap"].ToString();
        }
    }
}
