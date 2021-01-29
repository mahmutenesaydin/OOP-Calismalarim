using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_İO_Ders_3_Encapsulation__Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            //u.Adi = "Mahmut";
            u.Adi = "Enes";
            u.Fiyat = 10;
            u.Soyadi = "Aydın";
            MessageBox.Show(u.Adi);
            MessageBox.Show(u.KdvliFiyat.ToString());
            MessageBox.Show(u.Soyadi);
           


           // Urun u = new Urun();
           // u.AdiYaz("Mahmut");
           // u.AdiYaz("Enes");
           // MessageBox.Show(u.Adi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
