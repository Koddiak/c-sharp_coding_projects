using System;

namespace assignment_page_140
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number <= 50)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine(number + " is less than or equal to 50.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine(number + " is greater than 50.");
            Console.ReadLine();
        }
    }
}
