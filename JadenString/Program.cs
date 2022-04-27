using System;

namespace JadenString
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            var res = phrase.ToCharArray();
            if (phrase.Length > 0)
                res[0] = Char.ToUpper(res[0]);
            for (int i = 0; i< res.Length; i++)
            {
                if (char.IsWhiteSpace(res[i]))
                {
                    res[i + 1] = Char.ToUpper(res[i + 1]);
                }
            }

          return new string(res);
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
