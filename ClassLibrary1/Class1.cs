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
            MyProperty = 911;
        }

        public Class1(int foo)
        {
            MyProperty = foo;
        }

    }
}
