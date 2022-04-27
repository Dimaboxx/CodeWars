using System;
using System.Linq;

namespace _03_Isogram
{


    /// <summary>
    /// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

///     isIsogram "Dermatoglyphics" == true
///     isIsogram "aba" == false
///     isIsogram "moOse" == false -- ignore letter case
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }




        public class Kata
    {
        public static bool IsIsogram(string str)
        {
            var chars = str.ToLower().ToCharArray();
            var res = chars.Where(c => Char.IsLetter(c)).Select(c => c).GroupBy(c=>c).ToArray();
            return chars.Length == res.Length;

          // Code on you crazy diamond!
          }
    }
}
