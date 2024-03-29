﻿namespace LeetCode.Exercises.Easy
{
    public class TwoSums
    {
        //        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //        You can return the answer in any order.

        public int[] TwoSum(int[] nums, int target)
        {
            var newNums = nums.Distinct().OrderBy(x => x).ToArray();
            for (int i = 0; i < newNums.Count(); i++)
            {
                for (int j = 0; j < newNums.Count(); j++)
                {
                    if (i != j && newNums[i] + newNums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}
