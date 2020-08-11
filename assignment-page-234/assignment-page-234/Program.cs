using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_234
{
    class Program
    {
        static void Main()
        {
            try
            {
                int age = 0;
                Console.WriteLine("What is your age?");
                bool validAnswer = int.TryParse(Console.ReadLine(), out age);
                int year = DateTime.Today.Year - age;

                Console.Write(Environment.NewLine);

                if (!validAnswer)
                {
                    Console.WriteLine("Please enter an integer representation of the year you were born.");
                }
                else if (age < 1)
                {
                    Console.WriteLine("Please enter a valid age.");
                }
                else
                {

                    Console.WriteLine("You were born in the year {0}.", year);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }
    }
}
