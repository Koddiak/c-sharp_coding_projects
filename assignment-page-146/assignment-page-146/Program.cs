using System;
using System.Collections.Generic;

namespace assignment_page_146
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            stringList.Add("Apple");
            stringList.Add("Orange");
            stringList.Add("Banana");
            stringList.Add("Apple");
            stringList.Add("Apple");
            stringList.Add("Orange");
            stringList.Add("Apple");

            Dictionary<string, int> check = new Dictionary<string, int>();

            foreach (string fruit in stringList)
            {
                if (!check.ContainsKey(fruit))
                {
                    check.Add(fruit, 1);
                }
                else
                {
                    check[fruit]++;

                    if (check[fruit] == 2) { Console.WriteLine(fruit + " has already appeared on the list once."); }
                }
            }

            Console.Write(Environment.NewLine);

            foreach (KeyValuePair<string, int> fruit in check)
            {
                if (fruit.Value == 1)
                {
                    Console.WriteLine("There is {1} iteration of \"{0}\" in the list.", fruit.Key, fruit.Value);
                }
                else
                {
                    Console.WriteLine("There are {1} iterations of \"{0}\" in the list.", fruit.Key, fruit.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
