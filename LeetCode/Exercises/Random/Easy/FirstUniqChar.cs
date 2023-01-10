namespace LeetCode.Exercises.Easy
{
    public class FirstUniqChar
    {

        public int GetFirstUniqCharOptimized(string s)
        {
            int i = 0;
            var distinctChars = s.Distinct();

            foreach (var c in distinctChars)
            {
                if (s.Count(x => x == c) == 1)
                    return s.IndexOf(c);
                i++;
            }
            return -1;
        }

    }
}
