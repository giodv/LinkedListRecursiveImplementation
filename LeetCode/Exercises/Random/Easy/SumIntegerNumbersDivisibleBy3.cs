using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Exercises.Random.Easy
{
    public class SumIntegerNumbersDivisibleBy3
    {
        public int AverageValue(int[] nums)
        {
            var numbers = 0;
            var sumOfNumbers = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]% 3 == 0 && nums[i] % 2 == 0)
                {
                    sumOfNumbers += nums[i];
                    numbers++;
                }
            }

            if (numbers != 0)
            {
                return sumOfNumbers / numbers;
            }

            return 0;
        }
    }
}
