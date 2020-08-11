using System;

namespace assignment_page_116
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.Write(Environment.NewLine);

            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);

                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);

                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    int quote = width * height * length * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
