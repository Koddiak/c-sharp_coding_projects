using System;

namespace assignment_page_187
{
    public class Employee : Person, IQuittable
    {

        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Hello, my name is: ");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("I quit!");
            Console.ReadLine();
        }

        public static bool operator == (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
