using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞA_Facade
{
    public class SubSystem1
    {
        public void Method1()
        {
            MessageBox.Show(this.GetType().Name + "Method 1");
        }
    }
    public class SubSystem2
    {
        public void Method2()
        {
            MessageBox.Show(this.GetType().Name + "Method 2");
        }
    }
    public class SubSystem3
    {
        public void Method3()
        {
            MessageBox.Show(this.GetType().Name + "Method 3");
        }
    }
    public class SubSystem4
    {
        public void Method4()
        {
            MessageBox.Show(this.GetType().Name + "Method 4");
        }
    }
    public class SubSystem5
    {
        public void Method5()
        {
            MessageBox.Show(this.GetType().Name + "Method 5");
        }
    }

    public class Facade
    {
        private SubSystem1 _sub1;
        private SubSystem2 _sub2;
        private SubSystem3 _sub3;
        private SubSystem4 _sub4;
        private SubSystem5 _sub5;

        public Facade()
        {
            _sub1 = new SubSystem1();
            _sub2 = new SubSystem2();
            _sub3 = new SubSystem3();
            _sub4 = new SubSystem4();
            _sub5 = new SubSystem5();

        }
        public void MethodA()
        {
            _sub3.Method3();
            _sub5.Method5();
        }
        public void MethodB()
        {
            _sub1.Method1();
            _sub2.Method2();
        }
    }
}
