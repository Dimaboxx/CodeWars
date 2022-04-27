using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Number
    {
        public int DigitalRoot(long n)
        {

            #region мое решение
            //long result;
            //result = 0;
            //while (n > 0)
            //{
            //    result += n % 10;
            //    n = n / 10;
            //}
            //while (result > 10)
            //    result = DigitalRoot(result);
            //return (int)result;
            // Your awesome code here!
            #endregion

            #region codewars solution
            return (int)(1 + (n - 1) % 9);
            #endregion

        }


        public void base9(long n)
        {
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine( $"{i,3} , {i%9 ,3} , { (i-1) % 9, 3} | { 1+(i - 1) % 9, 3}" );
            }
        }

        public void printbase9table()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(getline(i));
            }
        } 

        public string getline(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                res = res + $"{n+i*10,3} {(n + i * 10)%9,3} { 1+(n-1+i*10)%9,3 } |";
            }
            return res;
        }
    }
}
