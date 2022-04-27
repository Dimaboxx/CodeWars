using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Console.WriteLine(number.DigitalRoot(16));
            Console.WriteLine(number.DigitalRoot(942));
            number.printbase9table();



            Console.ReadKey();
        }

    }
}


