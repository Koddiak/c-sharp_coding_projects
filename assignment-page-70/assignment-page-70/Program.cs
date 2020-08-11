using System;

namespace assignment_page_70
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("---");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpQuery = Console.ReadLine();
            bool helpQue = Convert.ToBoolean(helpQuery);

            Console.WriteLine("Were there any positive experiences you'd like to provide? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursStu = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
