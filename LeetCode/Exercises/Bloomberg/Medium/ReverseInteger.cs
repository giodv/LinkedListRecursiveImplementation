namespace LeetCode.Exercises.Bloomberg.Medium
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var operand = "+";

            if (x is >= -9 and <= 9) return x;

            var stringReverse = x.ToString();

            if (x < 0)
            {
                operand = "-";
                stringReverse = stringReverse[1..stringReverse.Length];
            }
            
            long.TryParse(operand + ReverseString(stringReverse), out var number);
            
            return number is >= int.MaxValue or <= int.MinValue ? 0 : int.Parse(number.ToString());
        }

        private string ReverseString(string s)
        {
            if (s.Length >= 2)
            {
                return s[^1] + ReverseString(s[..^1]);
            }

            return s;

        }
    }
}