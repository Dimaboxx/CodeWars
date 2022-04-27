using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Kata
    {
        public static int[] Divisors(int n)
        {
            if (n > 1)

                return getn(n).ToArray();
            else
                return null;
        }

        private static IEnumerable<int> getn(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    yield return i;
            }
        }
    }
}


