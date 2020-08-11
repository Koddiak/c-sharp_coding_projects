using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_page_141
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            stringList.Add("Apple");
            stringList.Add("Orange");
            stringList.Add("Banana");
            stringList.Add("Apricot");
            stringList.Add("Peach");
            stringList.Add("Pineapple");
            stringList.Add("Lemon");
            stringList.Add("Avocado");
            stringList.Add("Mango");
            stringList.Add("Guava");

            Console.WriteLine("Please guess a word in the list: ");
            StringBuilder input = new StringBuilder(Console.ReadLine());
            input[0] = Char.ToUpper(input[0]);
            string guess = input.ToString();

            foreach (string fruit in stringList)
            {
                if (guess == fruit)
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Correct guess. " + fruit + " is in the list.");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
