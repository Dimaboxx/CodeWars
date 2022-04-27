using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "world";
            string res = string.Empty;
            for (int i = 1; i<= str.Length;i++)
            {
                res += str[^i];
            }

            Console.WriteLine(res);
        }
    }
}
