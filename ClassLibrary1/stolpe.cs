using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Stolpe
    {
        public int propInt { get; set; }
        public DateTime Date { get; set;}

        public void Foo()
        {
            DateTime myDate = DateTime.Now.AddDays(1);
            Date = myDate;
        }
    }
}
