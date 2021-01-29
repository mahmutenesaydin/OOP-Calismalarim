using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ders_1_MYDers32__Class_ve_Object
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil Oto = new Otomobil();

            Oto.Marka = "Fiat";
            Oto.Model = "Doblo";
            Oto.ModelYılı = 2003;
            Oto.Renk = "Beyaz";
            Oto.VitesTipi = "Manuel";

            string Marka = Oto.MarkaGetir();

            label6.Text = Oto.Marka.ToString();
            label7.Text = Oto.Model.ToString();
            label8.Text = Oto.ModelYılı.ToString();
            label9.Text = Oto.Renk.ToString();
            label10.Text = Oto.VitesTipi.ToString();

        }
    }
}
