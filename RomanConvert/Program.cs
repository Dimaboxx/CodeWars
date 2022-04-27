using System;
using System.Collections.Generic;
using System.Linq;
namespace RomanConvert
{

    public class RomanConvert
    {
        static Dictionary<int, string> RD = new Dictionary<int, string> {
            { 1,    "I" },
            { 5,    "V" },
            { 10,   "X" },
            { 50,   "L" },
            { 100,  "C" },
            { 500,  "D" },
            { 1000, "M" } };

        static string [,] RDarr = new string[,]  {
            { "", "M" ,  ""   },
            { "", "C" ,  "D"  },
            { "", "X" ,  "L"  },
            { "", "I" ,  "V"  } }       ;

        static string[,] RDarrfull = new string[,]  {
            { "", "M" , "MM", "MMM", ""  ,  "",  "" ,   "" , "", ""   },
            { "", "C" , "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"  },
            { "", "X" , "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"  },
            { "", "I" , "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"  } };



        public static string Solution(int n)
        {
            int i = 0;
            string res = "" ;
            int d = 1000;
            while(n > 0)
            {
                res += RDarrfull[i, n/d];
                i++;
                n %= d;
                d /= 10;
            }
            //int n1000 = n / 1000;
            //int n100 = (n % 1000) / 100;
            //int n10 = (n % 100) / 10;
            //int n1 = n % 10;

            //string res = string.Concat( Enumerable.Repeat(RD[1000], n1000)) ;
            return res;




            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanConvert.Solution(1));
            Console.WriteLine(RomanConvert.Solution(3));
            Console.WriteLine(RomanConvert.Solution(10));
            Console.WriteLine(RomanConvert.Solution(15));
            Console.WriteLine(RomanConvert.Solution(1776));
        }
    }
}


/*
 Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000
*/