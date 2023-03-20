namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class RangeNumbers
    {
        /*
         * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
           Notice that the solution set must not contain duplicate triplets.
         */
        public IList<IList<int>> ThreeSumStupid(int[] nums)
        {
            IList<IList<int>> threeSumList = new List<IList<int>>();
            var hashSet = new HashSet<int>(nums);
            foreach (var i in hashSet)
            {
                foreach (var j in hashSet)
                {
                    foreach (var k in hashSet)
                    {
                        if (i != j && j != k && i != k && i + j + k == 0)
                        {
                            //doesn't resolve the duplicates.
                            threeSumList.Add(new List<int>() { i, j, k });
                        }
                    }
                }
            }

            return threeSumList;

        }

        //1,1,0,-1
        //[1,0,-1]
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var dict = new Dictionary<int, int>();
            var hashSet = new HashSet<int>(nums);

            for (int i = nums.Length - 1; i >= 0; i--)
                if (!dict.ContainsKey(nums[i]))
                    dict[nums[i]] = i;

            var result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    if (dict.TryGetValue(-nums[i] - nums[j], out int k) && k > j)
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                }
            }
            return result;
        }
    }
}