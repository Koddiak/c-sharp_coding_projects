using System;

namespace assignment_page_222
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.Write(Environment.NewLine);

            try
            {
                Console.WriteLine("Please enter a number: ");
                DateTime dateTime = DateTime.Now.AddHours(Convert.ToDouble(Console.ReadLine()));
                Console.Write(Environment.NewLine);
                Console.WriteLine(dateTime.ToString("h:mm tt"));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
