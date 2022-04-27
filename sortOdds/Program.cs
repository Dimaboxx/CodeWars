using System;
using System.Linq;
namespace sortOdds
{
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            int[] odds = array.Select(e => e).Where(e => e % 2 != 0).ToArray();
            Array.Sort(odds);
            int oddnum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                    array[i] = odds[oddnum++];
          return array;
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
