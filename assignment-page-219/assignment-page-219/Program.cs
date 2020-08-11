using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment_page_219
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();

            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt", input);
            string log = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt");

            Console.WriteLine(log);
            Console.ReadLine();
        }
    }
}
