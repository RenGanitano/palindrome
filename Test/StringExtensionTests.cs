using Palindrome.Extensions;
using Xunit;

namespace StringExtensionTests
{
    public class StringExtensionTests
    {
        [Fact]
        public void RacecarToLongestPalindromeHappyPath()
        {
            string palindrome = "racecar";
            string palindromeResult = palindrome.ToLongestPalindrome();
            Assert.Equal(palindrome, palindromeResult);
        }

        [Fact]
        public void ToLongestPalindromeHappyPath()
        {
            string palindrome = "babad";
            string palindromeResult = palindrome.ToLongestPalindrome();
            Assert.Contains(palindromeResult, new string[] { "bab", "aba" });
        }

        [Fact]
        public void ToLongestPalindromeSingleCharacterHappyPath()
        {
            string palindrome = "a";
            string palindromeResult = palindrome.ToLongestPalindrome();
            Assert.Equal(palindrome, palindromeResult);
        }

        [Fact]
        public void ToLongestPalindromeSameCharacterHappyPath()
        {
            string palindrome = "dddddddddddd";
            string palindromeResult = palindrome.ToLongestPalindrome();
            Assert.Equal(palindrome, palindromeResult);
        }

        [Fact]
        public void ToLongestPalindromeAllCharactersHappyPath()
        {
            string palindrome = "afa[yyuyy[433";
            string palindromeResult = palindrome.ToLongestPalindrome();
            Assert.Equal("[yyuyy[", palindromeResult);
        }
    }
}
