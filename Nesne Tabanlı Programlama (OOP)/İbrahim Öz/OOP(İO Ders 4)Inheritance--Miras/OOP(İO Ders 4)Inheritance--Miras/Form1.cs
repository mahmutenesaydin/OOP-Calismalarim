using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_İO_Ders_4_Inheritance__Miras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            InsanEkle(o);
            Ogretmen ogr = new Ogretmen();
            InsanEkle(ogr);

            Mudur m = new Mudur();
        }
        void InsanEkle(Insan ins)
        {

        }
    }
}
