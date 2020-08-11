using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_181
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is: ");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("I quit!");
            Console.ReadLine();
        }
    }
}
