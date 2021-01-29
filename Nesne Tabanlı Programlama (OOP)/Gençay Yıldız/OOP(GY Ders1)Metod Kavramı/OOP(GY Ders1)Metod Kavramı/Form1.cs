using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GY_Ders1_Metod_Kavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                 OrnekMetod Ornek = new OrnekMetod();
                 Ornek.Metod1();
                 Ornek.Metod2("Mahmut Enes");
/*int sonuc=*/   Ornek.Metod3();
/*string sonuc=*/Ornek.Metod4("Aydın");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
