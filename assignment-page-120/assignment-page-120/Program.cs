using System;

namespace assignment_page_120
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Apples or Oranges?");
            string answer1 = Console.ReadLine().ToLower();
            bool check1 = true;
            Console.Write(Environment.NewLine);

            while (check1)
            {
                switch (answer1)
                {
                    case "apples":
                        Console.WriteLine("You like apples!");
                        Console.ReadLine();
                        check1 = false;
                        break;
                    case "oranges":
                        Console.WriteLine("You like oranges!");
                        Console.ReadLine();
                        check1 = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        Console.Write(Environment.NewLine);
                        Console.WriteLine("Apples or Oranges?");
                        answer1 = Console.ReadLine().ToLower();
                        Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("Peaches or Grapes?");
            string answer2 = Console.ReadLine().ToLower();
            bool check2 = true;
            Console.Write(Environment.NewLine);

            do
            {
                switch (answer2)
                {
                    case "peaches":
                        Console.WriteLine("You like peaches!");
                        Console.ReadLine();
                        check2 = false;
                        break;
                    case "grapes":
                        Console.WriteLine("You like grapes!");
                        Console.ReadLine();
                        check2 = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        Console.Write(Environment.NewLine);
                        Console.WriteLine("Peaches or Grapes?");
                        answer2 = Console.ReadLine().ToLower();
                        Console.ReadLine();
                        break;
                }
            }
            while (check2);
        }
    }
}
