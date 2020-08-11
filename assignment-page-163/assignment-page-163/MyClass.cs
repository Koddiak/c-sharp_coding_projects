using System;

namespace assignment_page_163
{
    public class MyClass
    {
        public int Operation(int x, int y)
        {
            return x + y;
        }

        public int Operation(decimal x, decimal y)
        {
            return Convert.ToInt32(x - y);
        }

        public int Operation(string x, string y)
        {
            return Convert.ToInt32(x) * Convert.ToInt32(y);
        }
    }
}
