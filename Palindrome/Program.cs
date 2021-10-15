using Palindrome.Extensions;
using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Given a string s, return the longest palindromic substring in s.
 
                Example 1:
                Input: s = "babad"
                Output: "bab"
                Note: "aba" is also a valid answer.
                Example 2:
                Input: s = "cbbd"
                Output: "bb"
                Example 3:
                Input: s = "a"
                Output: "a"
                Example 4:
                Input: s = "ac"
                Output: "a"

             */

            // assume current index is center of palindrome

            string testString = "aracecarp";
            string palindrome = testString.ToLongestPalindrome();
            Console.WriteLine($"this is our palindrome yay: {palindrome}");
        }
    }
}
