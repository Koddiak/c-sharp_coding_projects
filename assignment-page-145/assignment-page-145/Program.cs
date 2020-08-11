using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_145
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            stringList.Add("yes");
            stringList.Add("yes");
            stringList.Add("no");
            stringList.Add("yes");

            Console.WriteLine("Please enter yes or no: ");
            string guess = Console.ReadLine().ToLower();
            bool check = false;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (guess == stringList[i])
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("stringList[" + i + "] = \"" + stringList[i] + "\"");
                    check = true;
                }
            }

            if (check == false)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine(guess + " is not in the list.");
            }

            Console.ReadLine();
        }
    }
}
