using System;

namespace assignment_page_164
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            try
            {
                Console.WriteLine("Please enter a single number or two numbers whose sum will be divided by 2.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter your first number: ");
                int input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number: ");
                string temp = Console.ReadLine();

                if (temp == "")
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Calculating...");
                    Console.WriteLine(input1 + " / 2 = " + myClass.Operation(input1));
                }
                else
                {
                    int input2 = Convert.ToInt32(temp);

                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Calculating...");
                    Console.WriteLine("(" + input1 + " + " + input2 + ") / 2 = " + myClass.Operation(input1, input2));
                }
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
