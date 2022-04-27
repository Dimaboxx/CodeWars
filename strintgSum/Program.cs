using System;
using System.Numerics;
namespace StringSummInt
{

    //        Given the string representations of two integers, return the string representation of the sum of those integers.
    //         For example:
    //          sumStrings('1','2') // => '3'
    //          A string representation of an integer will contain no characters besides the ten numerals "0" to "9".   
    public static class Program
    {
        public static void Main()
        {
            float s; 
             Console.WriteLine(SummStringInt.sumStrings("1","11"));
        }
    }

    public static class SummStringInt
    {
        /// <summary>
        /// не знал что есть bigInteger
        /// </summary>
        public static string sumStringsviaChar(string a, string b)
        {
            char[] aar;
            char[] bar;
            if (a.Length > b.Length)
            {
                aar = a.ToCharArray();
                bar = b.ToCharArray();

            }
            else
            {
                aar = b.ToCharArray();
                bar = a.ToCharArray();
            }

            Array.Reverse(aar);
            Array.Reverse(bar);

            int extra = 0;
            char[] resar = new char[aar.Length + 1];
            Array.Fill(resar, '0');
            for (int i = 0; i < aar.Length; i++)
            {
                char c = '0';
                if (bar.Length > i)
                    c = bar[i];
                int temp = (byte)aar[i] + (byte)c - ((byte)'0') * 2 + extra;

                extra = temp / 10;
                temp %= 10;

                resar[i] = (char)(temp + (byte)'0');
            }
            if (extra > 0)
            {
                resar[^1] = '1';
            }
            Array.Reverse(resar);
            //return (long.Parse(a) + long.Parse(b)).ToString();
            string res = string.Empty;
            bool trimleeadzero = true;
            for (int i = 0; i < resar.Length; i++)
            {

                if (trimleeadzero)
                {
                    if (resar[i].Equals('0'))
                        continue;
                    else
                        trimleeadzero = false;
                }
                res += resar[i];
            }
            return res;
        }


        public static string sumStrings(string a, string b)
        {
            if (String.IsNullOrWhiteSpace(a) && String.IsNullOrEmpty(b))
                return null;
            else if (String.IsNullOrWhiteSpace(a))
                return b;
            else if (String.IsNullOrWhiteSpace(b))
                return a;
            else
            {
            BigInteger bigia = BigInteger.Parse(a);
            BigInteger bigib = BigInteger.Parse(b);

            string res = (bigia + bigib).ToString();
            return res;
        }
        }
    }

}
