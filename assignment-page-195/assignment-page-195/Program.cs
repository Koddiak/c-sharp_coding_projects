using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_195
{
    class Program
    {
        static void Main()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), DateTime.Today.AddDays(1).DayOfWeek.ToString().ToLower());
            bool check = true;

            while (check)
            {
                try
                {
                    if (day.ToString() != today.ToString().ToLower())
                    {
                        Console.WriteLine("Please enter the current day of the week: ");
                        day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine().ToLower());
                        Console.Write(Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine("Correct, {0} is the current day of the week.", day.ToString());
                        check = false;
                    }
                }
                catch (Exception)
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.Write(Environment.NewLine);
                }
            }

            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
