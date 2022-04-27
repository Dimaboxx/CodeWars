using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiples_of_3_or_5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            if (value < 0)
                return 0;
            HashSet<int> hs = new HashSet<int>();
            for(int i =0; i<value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    hs.Add(i);
            }
            // Magic Happens
            return hs.Sum(); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
