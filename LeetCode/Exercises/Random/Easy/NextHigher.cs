using System;

namespace LeetCode.Exercises.Easy
{
    public class NextHigher
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var res = new List<int>();
            foreach (var n1 in nums1)
            {
                var index = Array.IndexOf(nums2, n1);
                var flag = false;
                for (int i = index; i < nums2.Count(); i++)
                {
                    var n2 = nums2[i];
                    if (index != i && n1 < n2)
                    {
                        res.Add(n2);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    res.Add(-1);
                }
            }
            return res.ToArray();
        }
    }
}