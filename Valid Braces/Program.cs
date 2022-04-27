using System;
using System.Linq;
using System.Collections.Generic;

namespace Valid_Braces
{
    class Program
    {
        static void Main(string[] args)
        {




//            "(){}[]"   =>  True
//"([{}])"   =>  True
//"(}"       =>  False
//"[(])"     =>  False
//"[({})](]" =>  False
            Console.WriteLine(Brace.validBraces("(){}[]"));
            Console.WriteLine(Brace.validBraces("([{}])"));
            Console.WriteLine(Brace.validBraces("(}"));
            Console.WriteLine(Brace.validBraces("[(])"));
            Console.WriteLine(Brace.validBraces("[({})](]"));
        }
    }




public class Brace
    {

        public static bool validBraces(String braces)
        {
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
            keyValuePairs.Add('(',')');
            keyValuePairs.Add('[',']');
            keyValuePairs.Add('{','}');

            Stack<char> stack = new Stack<char>();

            foreach( var c in braces)
            {
                if ( stack.Count == 0)
                {
                    stack.Push(c);
                }
                else
                    if (!c.Equals(keyValuePairs.GetValueOrDefault(stack.Peek())) )
                        stack.Push(c);
                    else
                        stack.Pop();
                
            }


            return stack.Count == 0;
        }
    }
}
