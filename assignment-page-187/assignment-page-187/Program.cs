using System;

namespace assignment_page_187
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Id = 12345;

            Employee employee2 = new Employee();
            employee2.Id = 12345;

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();

            Employee employee3 = new Employee();
            employee3.Id = 12345;

            Employee employee4 = new Employee();
            employee4.Id = 54321;

            Console.WriteLine(employee3 == employee4);
            Console.WriteLine(employee3 != employee4);
            Console.ReadLine();
        }
    }
}
