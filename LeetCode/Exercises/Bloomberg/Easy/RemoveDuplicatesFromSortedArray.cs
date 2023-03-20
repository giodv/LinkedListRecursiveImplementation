namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums, int val)
        {
            var index = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}