public class ApplyOps
{
    public int[] ApplyOperations(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (i + 1 < nums.Length)
            {
                var next = nums[i + 1];
                if (current == next)
                {
                    current = current * 2;
                    next = 0;
                }
            }
        }

        var notZero = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[notZero] = nums[i];
                notZero++;
            }
        }
        return nums;
    }
}