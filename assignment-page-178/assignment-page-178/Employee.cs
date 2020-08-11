using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_178
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is: ");
            base.SayName();
        }
    }
}
