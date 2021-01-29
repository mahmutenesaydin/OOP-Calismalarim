using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ders_2_MYDers45__Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Insan People = new Insan();
            People.Ad = "Mahmut Enes";
            People.Soyad = "Aydın";
            People.Yas = 20;
            People.Kilo = 86;

            Personel Employee = new Personel();
            Employee.Departman = "Eğitim";
            Employee.Yer = "Bağcılar";
            Employee.Boy = 172;

            label1.Text = People.Ad.ToString();
            label2.Text = People.Soyad.ToString();
            label3.Text = People.Yas.ToString();
            label4.Text = People.Kilo.ToString();

            label5.Text = Employee.Departman.ToString();
            label6.Text = Employee.Yer.ToString();
            label7.Text = Employee.Boy.ToString();

            Employee.Ad = "Cenk";
            Employee.Soyad = "Tosun";

            label8.Text = Employee.Ad.ToString();
            label9.Text = Employee.Soyad.ToString();

        }
    }
}
