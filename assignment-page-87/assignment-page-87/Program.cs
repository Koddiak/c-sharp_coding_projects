using System;

namespace assignment_page_87
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer to be multiplied by 50: ");
            int product = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine("Your integer multiplied by 50 is: " + product);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Please input an integer to be added by 25: ");
            int sum = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine("Your integer added by 25 is: " + sum);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Please input an integer to be divided by 12.5: ");
            double quotient = Convert.ToInt32(Console.ReadLine()) / 12.5;
            Console.WriteLine("Your integer divided by 12.5 is: " + quotient);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Please input an integer to compare whether or not it's greater than 50: ");
            int myNum = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = myNum > 50;
            Console.WriteLine("It's " + greaterThan + " that " + myNum + " is greater than 50.");
            Console.Write(Environment.NewLine);

            Console.WriteLine("Please input an integer to be divided by 7, we will find the resulting remainder: ");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("The remainder is: " + remainder);
            Console.ReadLine();
        }
    }
}
