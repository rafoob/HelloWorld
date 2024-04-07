using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2
    {

        public int Foo { get; }
        private string Bar { get; set; }

        public Class2(int foo, string bar)
        {
            Foo = foo;
            Bar = bar;
        }
        
        public void HelloDev()
        {
            //created in dev branch
        }

        public void DoWork()
        {

        }


        public void HelloMaster()
        {
            //created in master branch
        }

        public void HelloClassTwo()
        {

        }


    }
    
    
}
