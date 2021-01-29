using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP__IO_Ders_10__Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = "Mahmut";
            o.Yasi = 20;
            o.YasamDegeri = 100;
            o.Silahi = new Kanas();  /* Kanas kns= new Kanas      o.Silahi = kns;  */ // aynı şey bebe;
            MessageBox.Show(o.NisanAl());
        }
    }
}
