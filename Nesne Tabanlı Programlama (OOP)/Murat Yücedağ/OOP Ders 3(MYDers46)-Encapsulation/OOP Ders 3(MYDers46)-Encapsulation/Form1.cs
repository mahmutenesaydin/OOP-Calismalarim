using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ders_3_MYDers46__Encapsulation
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

        private void button1_Click(object sender, EventArgs e)
        {
            Emlak Home = new Emlak();
            Home.Semt = textBox1.Text;
            Home.OdaSayısı = Convert.ToInt32(textBox2.Text);
            Home.KatNo = Convert.ToInt32(textBox3.Text);
            Home.Alan = Convert.ToInt32(textBox4.Text);

            ListViewItem Kayıt = new ListViewItem();
            Kayıt.Text = Home.Semt;
            Kayıt.SubItems.Add(Home.OdaSayısı.ToString());
            Kayıt.SubItems.Add(Home.KatNo.ToString());
            Kayıt.SubItems.Add(Home.Alan.ToString());

            listView1.Items.Add(Kayıt);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }
    }
}
