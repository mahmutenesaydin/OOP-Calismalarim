using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP__GY_Ders_9_Singleton_Design_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Singleton nesne1 = Singleton.NesneVer();
            Singleton nesne2 = Singleton.NesneVer();
            if (nesne1.Equals(nesne2))
            {
                MessageBox.Show("Test");
            }
        }

        //Diğeri kullanımı için ;

        Singleton nesne1 = Singleton.NesneVerr;

    }
}
