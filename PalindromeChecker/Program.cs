using System;

namespace PalindromeChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("racecar"));
        }

        public static bool IsPalindrome(string input)
        {
            bool isItTrue = false;

            for(int i=0; i<input.Length; i++)
            {
                char lastChar = input[input.Length - 1 - i];
                char firstChar = input[i];

                //Console.Write(lastChar);
                //Console.Write(firstChar);

                if(firstChar == lastChar)
                {
                    isItTrue = true;
                }
                else
                {
                    isItTrue = false;
                    break;
                }
            }
            return isItTrue;
        }
    }
}
