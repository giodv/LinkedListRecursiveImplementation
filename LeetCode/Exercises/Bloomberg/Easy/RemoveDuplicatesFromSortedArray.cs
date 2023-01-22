namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums, int val)
        {
            //1,2,3,4,1

            // i = -1, 1,2,3,4,1 
            //i = -1,  2, 1,3,4,1
            //i = 0;   3,1,2,4,1
            //i = 1;   3,4,1,2,1
            // i = 2;  3,4,2,1,1,
            int i = -1;
            foreach (int num in nums)
            {
                if (num != val)
                    nums[++i] = num;
            }
            return i + 1;
        }
    }
} 