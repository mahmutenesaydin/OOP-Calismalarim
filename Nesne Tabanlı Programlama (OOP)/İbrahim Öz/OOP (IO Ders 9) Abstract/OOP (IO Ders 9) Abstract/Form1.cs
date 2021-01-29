using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  ABSTRACT(soyut) = Sadece miras verilmek için tasarlanan sınıflardır.
    Abstractlar bir sınıfa özel değildir. Bir property, bir metot veya
    herhangi bir eleman abstract olabilir.

 -- Abstract sınıflar içerisindeki abstract olan property veya metotların gövdesi
    olmadığı için bu metotlara erişilmesin diye abstract sınıflardan "instance" üretilmez;
 */

namespace OOP__IO_Ders_9__Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGitar_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            //MessageBox.Show(gtr.Cal());
            MuzikAletiCal(gtr);
        }

        private void btnBateri_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            MessageBox.Show(btr.Cal());
        }

        private void btnKeman_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();
            MessageBox.Show(kmn.Cal());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void MuzikAletiCal(MuzikAletleri mzkAlet)
        {
            MessageBox.Show(mzkAlet.Cal());
        }
    }
}
