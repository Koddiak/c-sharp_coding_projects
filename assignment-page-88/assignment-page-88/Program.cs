using System;

namespace assignment_page_88
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("---");
            Console.Write(Environment.NewLine);

            Console.WriteLine("Person 1");
            Console.WriteLine("Input Person 1's hourly rate: ");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Person 1's hours worked per week: ");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("Person 2");
            Console.WriteLine("Input Person 2's hourly rate: ");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Person 2's hours worked per week: ");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            int annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(annualSalary1);
            Console.Write(Environment.NewLine);

            int annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(annualSalary2);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);
            Console.ReadLine();
        }
    }
}
