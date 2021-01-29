using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Polymorphizm_Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Ekmek ekm = new Ekmek();
            ekm.Gramaj = 100;
            ekm.Fiyat = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            TekstilUrunu tu = new TekstilUrunu();
            tu.Adet = 5;
            tu.Fiyat = 10;
            tu.Rengi = "Kırmızı";
            spt.UrunEkle(tu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Elektronik elkt = new Elektronik();
            elkt.Fiyat = 150;
            spt.UrunEkle(elkt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
