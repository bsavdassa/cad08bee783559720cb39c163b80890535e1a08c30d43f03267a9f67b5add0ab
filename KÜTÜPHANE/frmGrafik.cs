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
    public partial class frmGrafik : Form
    {
        public frmGrafik()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;");
        private void Grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select adsoyad,okudugukitap from üyeler", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["okunankitap"].Points.AddXY(read["adsoyad"], read["okudugukitap"]);
            }
            baglanti.Close();
            chart1.Series["okunankitap"].Color = Color.Red;
        }
    }
}
