using System.Collections;

namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
                return false;

            var dict = new Dictionary<char, char>
            {
                { '[', ']' },
                { '{', '}' },
                { '(', ')' }
            };

            var firstPar = s[..(s.Length / 2)];
            var lastPar = s[(s.Length / 2)..s.Length];

            for (var i = 0; i < firstPar.Length; i++)
            {
                var leftPar = firstPar[i];
                var rightPar = lastPar[lastPar.Length - 1 - i];
                if (dict[leftPar] != rightPar)
                    return false;
            }

            return true;
        }
        public bool IsValid2(string s)
        {
            if (s.Length % 2 == 1)
                return false;

            var brackets = new Dictionary<char, char>
            {
                { '[', ']' },
                { '{', '}' },
                { '(', ')' }
            };
            var stack = new Stack<char>();

            brackets.Add('(', ')');
            brackets.Add('{', '}');
            brackets.Add('[', ']');

            foreach (var c in s)
            {
                if (brackets.ContainsKey(c)) stack.Push(c);
                else if (stack.Count == 0 || brackets[stack.Pop()] != c) return false;
            }

            return stack.Count == 0;
        }

       
    }
}