﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP__DH__Singleton_Design_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FxFunction fx = FxFunction.GetInstance();
            dataGridView1.DataSource = fx.GetData("Select * from Urunler");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FxFunction fx = FxFunction.GetInstance();
            dataGridView1.DataSource = fx.GetData("Select * from Kategoriler");
        }
    }
}
