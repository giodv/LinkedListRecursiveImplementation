namespace LeetCode.Exercises.Bloomberg.Medium
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dictionary = new Dictionary<char, int>();
            var max = 0;
            var current = 0;
            var currentIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(s[i]))
                {
                    current++;
                    dictionary[s[i]] = i;
                }
                else if (dictionary[s[i]] < currentIndex)
                {
                    dictionary[s[i]] = i;
                    current = dictionary[s[i]] - currentIndex + 1;

                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }

                    currentIndex = dictionary[s[i]] + 1;
                    current = i - dictionary[s[i]];
                    dictionary[s[i]] = i;

                }
            }

            return max > current ? max : current;
        }
    }
}