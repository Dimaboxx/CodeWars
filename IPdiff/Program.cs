using System;
using System.Net;

namespace IPdiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip = "0.0.0.1";
            Console.WriteLine((long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(ip).Address));
            Console.WriteLine(IPAddress.Parse(ip).Address);
        }


        public static long IpsBetween(string start, string end)
        {
            int res =0;
            var startarr = start.Split('.');
            var endarr = end.Split('.');
            for (int i = 0; i<4; i++)
            {
                res *= 256;
                res += int.Parse(endarr[i]) - int.Parse(startarr[i]);
            }
            return res;
       }

        // решение чужое
            // return (long) (uint) IPAddress.NetworkToHostOrder((int) IPAddress.Parse(end).Address) - 
            //(long) (uint) IPAddress.NetworkToHostOrder((int) IPAddress.Parse(start).Address);
    }
}
