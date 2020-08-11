using System;

namespace assignment_page_190
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
