using System.Globalization;

namespace LeetCode.Exercises.Bloomberg.Medium
{
    public class PalindromicSequence
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 1) return s;
            Stack<char> myStack = new();
            var longestPalindrome = string.Empty;
            var currentLongestPalindrome = string.Empty;

            foreach (var character in s)
            {


                var picked = myStack.TryPeek(out char x);

                if (picked && x == character)
                {
                    currentLongestPalindrome = longestPalindrome + character + x;
                    myStack.Pop();
                }
                else
                {
                    myStack.Push(character);
                }

                if (longestPalindrome.Length < currentLongestPalindrome.Length)
                {
                    longestPalindrome = currentLongestPalindrome;
                }

                if (myStack.Count == 0)
                {

                    currentLongestPalindrome = string.Empty;
                }

            }
            return longestPalindrome;

        }

        public bool IsPalindrome(string s)
        {
            if (s.Length == 1) return true;

            Stack<char> myStack = new();
            foreach (var character in s)
            {
                var picked = myStack.TryPeek(out var x);
                if (picked && x == character)
                {
                    myStack.Pop();
                }
                else
                {
                    myStack.Push(x);
                }
            }

            return myStack.Count == 0;
        }

        public string LongestPalindromicSubstring(string s)
        {
            var absPalindromic = string.Empty;
            var localPalindromic = string.Empty;
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }
            for (int i = 1; i < s.Length; i++)
            {
                var left = i;
                var right = i + 1;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    localPalindromic = s[left..(right+1)];
                    left--;
                    right++;
                    if (localPalindromic.Length > absPalindromic.Length)
                    {
                        absPalindromic = localPalindromic;
                    }
                }

                (left, right) = (i,i);

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    localPalindromic = s[left..(right + 1)];
                    left--;
                    right++;
                    
                    if (localPalindromic.Length > absPalindromic.Length)
                    {
                        absPalindromic = localPalindromic;
                    }
                }

            }

            return absPalindromic;
        }
    }
}