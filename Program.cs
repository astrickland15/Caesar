using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "What-the-Hecz";
            Console.WriteLine(caesarCipher(word, 3));
            Console.ReadLine();
        }

        public static string caesarCipher(string s, int k)

        {
            string newString = "";
            foreach (char c in s)
            {
                newString += Convert.ToChar(getASCII(c, k)).ToString();
            }
            return newString;
        }

        public static int getASCII(char c, int num)
        {
            int result = 0;
            if (!isAlphaCharacter(c))
            {
                result = c;
            }
            else
            {
                result = (c + (num % 26));
                if ((result > 122 && isLowerCase(c)) || (result > 90 && isUpperCase(c)))
                {
                    result -= 26;
                }
            }
            return result;
        }

        public static bool isAlphaCharacter(char c)
        {
            return isLowerCase(c) || isUpperCase(c) ? true : false;
        }

        public static bool isLowerCase(char c)
        {
            if (c >= 97 && c <= 122)
            {
                return true;
            }
            return false;
        }

        public static bool isUpperCase(char c)
        {
            if (c >= 65 && c <= 90)
            {
                return true;
            }
            return false;
        }

    }
}

