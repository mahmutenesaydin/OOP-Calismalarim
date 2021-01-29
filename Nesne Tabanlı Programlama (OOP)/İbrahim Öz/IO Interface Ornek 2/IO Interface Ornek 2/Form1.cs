using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Interface_Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenkTosun ct23 = new CenkTosun();
            MessageBox.Show(SutCek(ct23,20.15f,45));
        }
        private string SutCek(IGolAtar gol,float Hiz,float Mesafe)
        {
            return gol.SutCeksin(Hiz, Mesafe);
        }
    }
}
