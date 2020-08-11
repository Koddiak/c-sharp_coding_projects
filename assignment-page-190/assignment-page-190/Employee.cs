using System;
using System.Collections.Generic;

namespace assignment_page_190
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things { get; set; }
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

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
