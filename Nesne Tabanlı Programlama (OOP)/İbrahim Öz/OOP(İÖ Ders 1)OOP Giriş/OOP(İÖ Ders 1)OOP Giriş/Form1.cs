using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*   ACCESS MODİFİERS -->

    + PRİVATE   = Sadece bulunduğu yerden erişilebilir. Başka yerden erişilemez.
    + INTERNAL  = Bulunduğu proje içerisinden her yerden erişim sağlar. Başka projeden erişime izin vermez. 
    + PROTECTED = Miras(Inheritance) alınan sınıflar içerisinden erişime izin verir.
    + PROTECTED INTERNAL = Hem miras alınan sınıflar içerisinden erişime izin verir, hemde bulunduğu proje içersiniden her yerden erişime izin verir
    + PUBLIC    = Her yerden, her şekilde erişime izin verir.      
*/

namespace OOP_İÖ_Ders_1_OOP_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Personel[] personeller = new Personel[30];
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Adi = textBox1.Text;
            p.Soyadi = textBox2.Text;
            p.DogumTarihi = dateTimePicker1.Value;
            p.TC = textBox3.Text;
            PersonelEkle(p);
            personeller[sayac] = p;
        }
        void PersonelEkle(Personel P)
        {//Veritabanına personel ekleme işlemi yapılır
            //MessageBox.Show(P.Adi);
        }
    }
}
