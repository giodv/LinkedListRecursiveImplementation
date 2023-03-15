namespace LeetCode.Exercises.Bloomberg.Easy;

public class TwoSums
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Count(); i++)
        {
            for (int j = i + 1; j < nums.Count(); j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }


    public int[] TwoSumsOptimized(int[] nums, int target)
    {
        //reduce O(n^2)
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(target - nums[i]))
            {
                return new int[] { dictionary[target - nums[i]], i };
            }

            if (!dictionary.ContainsKey(nums[i]))
                dictionary.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}