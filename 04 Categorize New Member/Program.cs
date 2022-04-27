using System;

using System.Collections.Generic;
using System.Linq;
namespace _04_Categorize_New_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new int[][] { new int[] { 18, 20 }, new int[] { 45, 2 }, new int[] { 61, 12 }, new int[] { 37, 6 }, new int[] { 21, 21 }, new int[] { 78, 9 } };
            var res = Kata.OpenOrSenior(set);
            foreach(var r in res )
            Console.WriteLine(r);
        }
    }



public class Kata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //your code here

            foreach (var m in data)
            {
                yield return ((m[0] >= 55) && (m[1] > 7) ? "Senior" : "Open");
            }
        }
    }
}
