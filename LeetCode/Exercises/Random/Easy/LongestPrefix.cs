namespace LeetCode.Exercises.Random.Easy
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var longestPrefix = string.Empty;
            for (var w1 = 0; w1 < strs.Length; w1++)
            {
                var prefix = string.Empty;
                for (var w2 = w1 + 1; w2 < strs.Length; w2++)
                {
                    for (var charIndex = 0; charIndex < strs[w1].Length; charIndex++)
                    {
                        if (charIndex < strs[w2].Length && strs[w1][0..(charIndex + 1)] == strs[w2][0..(charIndex + 1)])
                        {
                            prefix = strs[w1][0..(charIndex + 1)];
                            if (prefix.Length > longestPrefix.Length)
                                longestPrefix = prefix;
                        }
                    }
                }
            }
            return longestPrefix;
        }
    }

}