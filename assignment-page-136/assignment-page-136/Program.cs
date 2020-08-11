using System;
using System.Collections.Generic;

namespace assignment_page_136
{
    class Program
    {
        static void Main()
        {
            string[] inputs = { "", "", "" };
            
            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine("Please enter some text to populate inputs[" + i + "]: ");
                inputs[i] = Console.ReadLine();
                Console.Write(Environment.NewLine);
            }

            for (int j = 0; j < inputs.Length; j++)
            {
                Console.WriteLine("The text in inputs[" + j + "] is: " + inputs[j]);
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
