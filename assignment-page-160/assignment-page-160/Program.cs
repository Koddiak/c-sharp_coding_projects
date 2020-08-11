using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_160
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            Console.WriteLine("Please enter a number to be added, subtracted and multiplied by 10: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " + 10 = " + myClass.Add(input) + "\n" + input + " - 10 = " + myClass.Sub(input) + "\n" + input + " x 10 = " + myClass.Mul(input));

            Console.ReadLine();
        }
    }
}
