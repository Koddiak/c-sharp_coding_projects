using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_203
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Doe", Id = 1 },
                new Employee { FirstName = "Joe", LastName = "Schmoe", Id = 2},
                new Employee { FirstName = "James", LastName = "Smith", Id = 3},
                new Employee { FirstName = "John", LastName = "Johnson", Id = 4},
                new Employee { FirstName = "Robert", LastName = "Williams", Id = 5},
                new Employee { FirstName = "Mary", LastName = "Jones", Id = 6},
                new Employee { FirstName = "Patricia", LastName = "Brown", Id = 7},
                new Employee { FirstName = "Linda", LastName = "Davis", Id = 8},
                new Employee { FirstName = "Barbara", LastName = "Miller", Id = 9},
                new Employee { FirstName = "Elizabeth", LastName = "Wilson", Id = 10},
            };

            List<Employee> joes1 = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes1.Add(employee);
                }
            }

            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> ids = employees.Where(x => x.Id > 5).ToList();
        }
    }
}
