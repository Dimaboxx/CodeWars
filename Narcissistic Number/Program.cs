
    using System.Linq;
using System;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;

    namespace Narcissistic_Number
{

    public class Kata
    {
        [Benchmark]

        public void testLinq()
        {
            Narcissistic(1938);
            Narcissistic(19385784);
        }

        public static bool Narcissistic(int value= 1938)
        {
            var sum = from c in value.ToString() 
                    let n = value.ToString().Length
                        select  Math.Pow(int.Parse(c.ToString()),n);
            
            // var sum =  value.ToString().ToCharArray().Select((e, n) => Math.Pow(int.Parse(e.ToString()), n)).Sum();
           return value == (int)sum.Sum(); // Code me
        }

        [Benchmark]
        public void TestHands()
        {
            Narcissistic2(1938);
            Narcissistic2(19385784);
        }
        public static bool Narcissistic2(int value= 1938)
        {
            int v1 = value;
            int[] arr = new int[10];
            int i = 0;
            while (value > 0)
            {
                arr[i] = value % 10;
                value /= 10;
                i++;
            }// Code me

            int sum =0;
            for (int p = 0; p < i; p++)
            {
                sum += (int)Math.Pow(arr[p],i);
            }

            return sum == v1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

        }
    }
}
