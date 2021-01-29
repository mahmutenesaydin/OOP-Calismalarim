using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ŞA_Interpreter.Expression;

namespace ŞA_Interpreter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInterpret_Click(object sender, EventArgs e)
        {
            var tree = new List<Expression>()
            {
                new ThousandExpression(),
                new HundradExpression(),
                new TenExpression(),
                new OneExpression()
            };

            var context = new Context
            {
                Input = txtRoman.Text.Trim()
            };

            tree.ForEach(t => t.Interpret(context));
            txtDecimal.Text = context.Output.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }
    }
}
