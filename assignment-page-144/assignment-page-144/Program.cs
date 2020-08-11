using System;
using System.Collections.Generic;

namespace assignment_page_144
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            stringList.Add("yes");
            stringList.Add("yes");
            stringList.Add("no");
            stringList.Add("yes");

            Console.WriteLine("Please enter yes or no: ");
            string guess = Console.ReadLine().ToLower();

            for (int i = 0; i < stringList.Count; i++)
            {
                if (guess == stringList[i])
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("stringList[" + i + "] = \"" + stringList[i] + "\"");
                }
            }

            Console.ReadLine();
        }
    }
}
