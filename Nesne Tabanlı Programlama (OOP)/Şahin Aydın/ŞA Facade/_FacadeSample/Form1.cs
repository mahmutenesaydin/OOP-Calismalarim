using _FacadeSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _FacadeSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            using (FacadeDBEntities db = new FacadeDBEntities())
            {
                Customer cst = db.Customers.Find(Convert.ToInt32(txtCustomerID.Text));
                Facade facade = new Facade();
                bool uygn = facade.Uygunmu(cst, Convert.ToDecimal(txtAmount.Text));
                MessageBox.Show(uygn ? "Uygun" : "Değil");
            }
        }
    }
}
