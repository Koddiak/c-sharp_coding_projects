using System;

namespace assignment_page_163
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            try
            {
                Console.WriteLine("For this first method we will add two numbers of type int with a number of type int as a result.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter your first number: ");
                int input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number: ");
                int input2 = Convert.ToInt32(Console.ReadLine());

                Console.Write(Environment.NewLine);
                Console.WriteLine("Calculating...");
                Console.WriteLine(input1 + " + " + input2 + " = " + myClass.Operation(input1, input2));
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.Write(Environment.NewLine);

            try
            {
                Console.WriteLine("For this second method we will subtract two numbers of type decimal with a number of type int as a result.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter your first number: ");
                decimal input1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter your second number: ");
                decimal input2 = Convert.ToDecimal(Console.ReadLine());

                Console.Write(Environment.NewLine);
                Console.WriteLine("Calculating...");
                Console.WriteLine(input1 + " - " + input2 + " = " + myClass.Operation(input1, input2));
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.Write(Environment.NewLine);

            try
            {
                Console.WriteLine("For this third method we will multiply two numbers of type string with a number of type int as a result.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter your first number: ");
                string input1 = Console.ReadLine();

                Console.WriteLine("Please enter your second number: ");
                string input2 = Console.ReadLine();

                Console.Write(Environment.NewLine);
                Console.WriteLine("Calculating...");
                Console.WriteLine(input1 + " x " + input2 + " = " + myClass.Operation(input1, input2));
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
