using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞA_Flyweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string document = textBox1.Text;
            char[] chars = document.ToCharArray();
            var factory = new CharacterFactory();
            int pointSize = 10;
            foreach (char c in chars)
            {
                var character = factory[c];
                character.Display(pointSize,listBox1);
            }
        } 
    }
}
