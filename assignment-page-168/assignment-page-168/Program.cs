using System;

namespace assignment_page_168
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            Console.WriteLine("Please enter a number to be divided by 2: ");
            int input = Convert.ToInt32(Console.ReadLine());

            myClass.Operation(input, out int result);

            Console.Write(Environment.NewLine);

            Console.WriteLine(input + " / 2 = " + result);

            Console.Write(Environment.NewLine);

            Console.WriteLine(MyStaticClass.Desc);
            Console.ReadLine();
        }
    }
}
