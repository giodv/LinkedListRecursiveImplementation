namespace LeetCode.Exercises.Bloomberg.Medium
{
    public class ThreeSumsArray
    {
        /*
         * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
         * such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
         */
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                var left = i + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    var threeSum = nums[i] + nums[left] + nums[right];
                    if (threeSum > 0)
                    {
                        right--;
                    }
                    else if (threeSum < 0)
                    {
                        left++;

                    }
                    else
                    {
                        list.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }

                }
            }

            return list;
        }
    }
}