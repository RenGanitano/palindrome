namespace Palindrome.Extensions
{
    public static class StringExtensions
    {
        public static string ToLongestPalindrome(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            if (s.Length == 1)
            {
                return s;
            }
            if (s.Split(s[0]).Length - 1 == s.Length)
            {
                return s;
            }

            string lastPalindrome = $"{s[0]}";

            for (int i = 0; i < s.Length; i++)
            {
                int endIndex = i;

                while (i >= 0 && endIndex <= s.Length)
                {
                    endIndex++;
                    if (endIndex >= s.Length || s[i] == s[endIndex]) break;
                }

                // add 1 to start index to account for center of palindrome
                int palindromeLength = (endIndex - i) + 1;

                if (palindromeLength > lastPalindrome.Length && palindromeLength <= (s.Length - i))
                {
                    lastPalindrome = s.Substring(i, palindromeLength);
                }
            }

            return lastPalindrome;
        }
    }
}
