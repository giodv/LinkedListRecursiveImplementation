namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int index = 1;

            for (int pos = 0; pos < nums.Length - 1; pos++)
            {
                if (nums[pos] != nums[pos + 1])
                {
                    nums[index++] = nums[pos + 1];
                }
            }

            return index;
        }
    }
}