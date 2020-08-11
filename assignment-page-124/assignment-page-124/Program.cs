using System;
using System.Text;

namespace assignment_page_124
{
    class Program
    {
        static void Main()
        {
            string s1 = "Hello";
            string s2 = ", ";
            string s3 = "World!";

            Console.WriteLine(s1 + s2 + s3.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("\tThis is the first sentence of the StringBuilder object. ");
            sb.Append("This is the second sentence of the StringBuilder object. ");
            sb.Append("This is the third sentence of the StringBuilder object. ");
            sb.Append("This is the fourth sentence of the StringBuilder object. ");
            sb.Append("This is the fifth sentence of the StringBuilder object. ");
            sb.Append("This is the sixth sentence of the StringBuilder object. ");
            sb.Append("This is the seventh sentence of the StringBuilder object. ");
            sb.Append("This is the eight sentence of the StringBuilder object. ");
            sb.Append("This is the ninth sentence of the StringBuilder object. ");
            sb.Append("This is the tenth sentence of the StringBuilder object. ");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
