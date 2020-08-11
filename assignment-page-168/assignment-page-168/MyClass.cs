using System;

namespace assignment_page_168
{
    public class MyClass
    {
        public int Operation(int x)
        {
            return x / 2;
        }
        public void Operation(int x, out int result)
        {
            result = x / 2;
        }
    }

    public static class MyStaticClass
    {
        public static string desc = "Hello, I am a static class.";

        public static string Desc { get => desc; set => desc = value; }
    }
}
