using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int MyProperty { get; set; }
        public Class1()
        {
            MyProperty = MyProperty + 2;
        }

        public Class1(int foo)
        {
            MyProperty = foo;
        }

        public void MyFunction()
        {
            var foo = new Stolpe();
            foo.Date = DateTime.Now;
            foo.propInt = MyProperty;
        }

    }
}
