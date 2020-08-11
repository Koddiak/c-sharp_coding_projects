using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_230
{
    class MyClass
    {
        public MyClass(string a) : this(a, 50)
        {

        }

        public MyClass(string a, int b)
        {
            Prop1 = a;
            Prop2 = b;
        }

        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
}
