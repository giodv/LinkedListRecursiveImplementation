namespace LeetCode.Exercises.Easy
{
    public class ReverseStrings
    {
        public char[] ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var first = s[i];
                var last = s[s.Length - 1- i];
                s[i] = last;
                s[s.Length - 1 - i] = first;
            }

            return s;
        }
    }
}