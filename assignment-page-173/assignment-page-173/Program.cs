using System;

namespace assignment_page_173
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
