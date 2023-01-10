namespace LeetCode.Exercises.Medium
{
    public class LongestSubstring
    {
       
        public int LengthOfLongestSubstring(string s)
        {
            var currentSubstring = string.Empty;
            var maxSubstring = string.Empty;
            for (int i = 0; i< s.Length; i++)
            {
                var c = s[i];
                if (!currentSubstring.Contains(c))
                {
                    currentSubstring += c;
                }
                else
                {
                    currentSubstring = s[s[0..i].LastIndexOf(c)..i];
                }

                if (currentSubstring.Length > maxSubstring.Length)
                {
                    maxSubstring = currentSubstring;
                }
            }

            return maxSubstring.Length;
        }
    }
}
