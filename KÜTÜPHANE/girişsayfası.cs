using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmÜyeekleme uyeekleformu = new frmÜyeekleme();
            uyeekleformu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmÜyelisteleme uyelistelemeformu = new frmÜyelisteleme();
            uyelistelemeformu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKitapekleme kitapekleformu = new frmKitapekleme();
            kitapekleformu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKitaplisteleme kitaplistelemeformu = new frmKitaplisteleme();
            kitaplistelemeformu.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmEmanetkitapverme emanetkitapverformu = new frmEmanetkitapverme();
            emanetkitapverformu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmEmanetkitaplistele emanetkitaplistele = new frmEmanetkitaplistele();
            emanetkitaplistele.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmEmanetKitap iadeformu = new frmEmanetKitap();
            iadeformu.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmÜyesıralama sıralamaformu = new frmÜyesıralama();
            sıralamaformu.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGrafik grafikformu = new frmGrafik();
            grafikformu.ShowDialog();
        }
    }
}
