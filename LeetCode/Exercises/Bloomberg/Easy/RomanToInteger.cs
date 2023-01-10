namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var value = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var currentValue = FromRomanToNumber(s[i]);
                var nextValue = i + 1 < s.Length ? FromRomanToNumber(s[i + 1]) : currentValue;
                if (currentValue < nextValue)
                {
                    //IV
                    value -= currentValue;
                }
                else
                {
                    //II
                    value += currentValue;
                }
            }

            return value;
        }

        private int FromRomanToNumber(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'C' => 100,
                'L' => 50,
                'D' => 500,
                'M' => 1000,
                _ => throw new NotImplementedException("unrecognized number")
            };
        }
    }
}