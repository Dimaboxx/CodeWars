using System;
using System.Collections.Generic;
using System.Linq;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        public static List<string> movingShift(string s, int shift)
        {
            int partLength = s.Length % 5 == 0 ? s.Length / 5 : s.Length / 5 + 1;
            int c = 0;
            List<string> reslist = new List<string>() { String.Empty, String.Empty, String.Empty, String.Empty, String.Empty };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < partLength; j++, c++)
                {
                    if (c == s.Length) break;
                    int @base = (int)'a';
                    if (Char.IsLetter(s[c]))
                    {
                        if (Char.IsUpper(s[c]))
                            @base = (int)'A';
                        reslist[i] += (char)(charshift(((int)s[c] - @base), c + shift) + @base);
                       // reslist[i] += (char)(charshift(((int)s[c] - @base), i * 10 + j + shift) + @base);
                    }
                    else
                        reslist[i] += (char)s[c];
                }

            }
            return reslist;
        }

        private static int charshift(int c, int shift)
        {
            int tmp = c + shift;

            while (tmp > 25) tmp -= 26;
            return tmp;
        }

        private static int charreshift(int c, int shift)
        {
            int tmp = c - shift;
            while (tmp < 0) tmp += 26;
            return tmp;
        }





        public static string demovingShift(List<string> s, int shift)
        {
            int resLenght = 0;
            foreach (string s2 in s)
            {
                resLenght += s2.Length;
            }
            Char[] reschars = new char[resLenght];
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < s[i].Length; j++, c++)
                {
                    if (Char.IsLetter(s[i][j]))
                    {
                        int @base = (int)'a';
                        if (Char.IsUpper(s[i][j]))
                            @base = (int)'A';
                        reschars[c] = (char)(charreshift(((int)s[i][j] - @base), c + shift) + @base);
                        //reschars[c] = (char)(charreshift(((int)s[i][j] - @base), i * 10 + j + shift) + @base);
                    }
                    else
                        reschars[c] = (char)s[i][j];

                }
            }

            return new String(reschars);
        }
    }
}
