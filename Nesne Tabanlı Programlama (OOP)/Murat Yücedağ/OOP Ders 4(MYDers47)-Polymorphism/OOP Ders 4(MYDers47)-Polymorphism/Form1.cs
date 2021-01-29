using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ders_4_MYDers47__Polymorphism
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
            Ekmek ekm = new Ekmek("Uno",2, "Somon", 125);
            spt.UrunEkle(ekm);
            MessageBox.Show(spt.ToplamTutar().ToString());
        }
    }
}
