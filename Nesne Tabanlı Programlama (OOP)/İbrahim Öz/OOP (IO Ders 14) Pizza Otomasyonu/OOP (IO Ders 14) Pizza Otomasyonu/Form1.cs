using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP__IO_Ders_14__Pizza_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat { Adi = "Maxi", Carpan = 2 };
            cmbEbat.Items.Add(kucuk);
            cmbEbat.Items.Add(orta);
            cmbEbat.Items.Add(buyuk);
            cmbEbat.Items.Add(maxi);


            Pizza klasik = new Pizza { Adi = "Klasik", Fiyat = 14 };
            Pizza karisik = new Pizza { Adi = "Karışık", Fiyat = 17 };
            Pizza Turkish = new Pizza { Adi = "Turkish", Fiyat = 20 };
            listPizzalar.Items.Add(klasik);
            listPizzalar.Items.Add(karisik);
            listPizzalar.Items.Add(Turkish);

            KenarTip ince = new KenarTip { Adi = "İnce Kenar", EkFiyat = 0 };
            KenarTip kalin = new KenarTip { Adi = "Kalın Kenar", EkFiyat = 2 };
            rdbInceKenar.Tag = ince;
            rdbKalinKenar.Tag = kalin;

        }
        Siparis siparis;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza pizza = (Pizza)listPizzalar.SelectedItem;
            pizza.Ebati = (Ebat)cmbEbat.SelectedItem;
            pizza.KenarTipi = rdbInceKenar.Checked ? (KenarTip)rdbInceKenar.Tag : (KenarTip)rdbKalinKenar.Tag;
            pizza.Malzemeler = new List<string>();
            
            foreach (CheckBox cb in groupBox1.Controls) 
            {
                if (cb.Checked)
                {
                    pizza.Malzemeler.Add(cb.Text);
                }
            }
            decimal tutar = nudAdet.Value * pizza.Tutar;
            txtTutar.Text = tutar.ToString();
            siparis = new Siparis();
            siparis.Pizza = pizza;
            siparis.Adet = (int)nudAdet.Value;
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (siparis != null)
            {
                listSepet.Items.Add(siparis);
            }
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            decimal ToplamTutar = 0;
            int adet = 0;
            foreach (Siparis spr in listSepet.Items)
            {
                ToplamTutar += spr.Adet + spr.Pizza.Tutar;
                adet++;
            }
            lblToplamTutar.Text = ToplamTutar.ToString();
            MessageBox.Show(string.Format("Toplam sipariş adetiniz: {0} \n Toplam sipariş tutarınız: {1}",adet,ToplamTutar));
        }
    }
}
