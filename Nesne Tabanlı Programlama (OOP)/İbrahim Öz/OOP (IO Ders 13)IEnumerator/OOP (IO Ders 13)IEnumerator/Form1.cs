using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// BU KONU EKSİK. IENUMERATOR İLE İLGİLİ BİR ŞEY YOK :( BAŞKA VİDEOLARA GO GO :D


namespace OOP__IO_Ders_13_IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkm.Adi = "MeaSpor";
            tkm.KurulusYili = Convert.ToDateTime("13.01.1999");
            tkm.StadIsmi = "Mea Park";
        }
        Takim tkm = new Takim();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = txtOyuncu.Text;
            o.DogumTarihi = DateTime.Now;
            o.FormaNo = 13;
            o.Mevkii = "Forvet";
            o.Soyadi = "Aydın";
            o.Uyrugu = "Türkiye";
            tkm.Oyuncular.Add(o);
            listBox1.Items.Add(o.Adi);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

        }
    }
}
