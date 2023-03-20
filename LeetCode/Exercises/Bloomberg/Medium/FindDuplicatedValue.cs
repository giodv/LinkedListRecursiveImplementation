using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Exercises.Bloomberg.Medium
{
    public class FindDuplicatedValue
    {
        public int FindDuplicate(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var n in nums)
            {
                if (dictionary.ContainsKey(n))
                    return n;
                else
                    dictionary[n] = 0;
            }

            return 0;
        }
    }
}
