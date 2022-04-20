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
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphaneotomasyonu.accdb;");
        private void Grafik_Load(object sender, EventArgs e)
        {

        }
    }
}
