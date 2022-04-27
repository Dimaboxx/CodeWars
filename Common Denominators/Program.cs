using System;

namespace Common_Denominators
{
    class Program
    {
        static long[,] test = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };

        static void Main(string[] args)
        {
            Console.WriteLine(Fracts.convertFrac(test));
        }
    }



    public class Fracts
    {
        public static string convertFrac(long[,] lst)
        {
            int d=0;
            bool done;
            do
            {
                d++;
                done = true;
                for (int i = 0; i < lst.GetLength(0); i++)
                {
                    done &= (d % lst[i, 1]) == 0;
                }
            }
            while (!done);

            string res = string.Empty;
            for(int i =0; i < lst.GetLength(0); i++)
            {
                res += $"({d / lst[i, 1]},{d})";
            }

            return res;
        }
    }
}
