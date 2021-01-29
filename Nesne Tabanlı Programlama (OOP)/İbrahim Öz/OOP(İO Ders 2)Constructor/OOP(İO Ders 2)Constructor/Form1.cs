using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  CONSTRUCTER METOD ==> Nesnenin RAM'da üretilmesini sağlayan metottur
// Constructer m.tanımlanmazsa varsayılan(default)metod geçerlidir.
// Con.m.'un overload'ı vardır.(Aşırı yükleme)
// Kendimiz sınıf(class)içerisinde constructer metod yazabiliriz
// Geriye dönüş tipi olmayan tek metottur.
// Class'a kendimiz constructer tanımlarsak varsayılan(default)con. iptal olur.
// Class içerisine imzaları farklı olmak suretiyle birden fazla Constructer tanımlayabiliriz.
Ve bu sınıftan örnek üretirken hangi  cons'a üretilen değerler gönderildiyse o consturcter çalışır. 
// Cons. metodlarının isimleri "CLASS ismi ile aynı olmak zorundadır".
// Con.metod void, int, string gibi şeyler almaz tek kullanılır. (public x) gibi
 */

namespace OOP_İO_Ders_2_Constructor
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel(); //Instance;
            p.Adi = "Mahmut";
            p.KayitTarihi = DateTime.Now;

            Personel p2 = new Personel("Enes");
            Personel p3 = new Personel("Enes", "Aydın", DateTime.Now, "23717388896");

            //OBJECT INITIALIZER ==>
            Personel p4 = new Personel
            {
                Adi="Mıho",
                Soyadi="Maraz",
                DogumTarihi=DateTime.Now,
                TC="23717388896",
            };
            Personel p5 = new Personel { Adi = "Maho" };
        }
    }
}