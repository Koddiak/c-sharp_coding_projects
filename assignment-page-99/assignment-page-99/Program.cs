using System;

namespace assignment_page_99
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && speedingTickets <= 3);
            Console.ReadLine();
        }
    }
}
