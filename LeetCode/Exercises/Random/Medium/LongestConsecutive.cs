namespace LeetCode.Exercises.Medium
{
    public class LongestConsecutive
    {
        public int GetLongestConsecutive(int[] nums)
        {
            var ordered = nums.Distinct().OrderBy(x => x).ToList();
            var maxCounter = 0;
            var currentMaxCounter = 1;
            var last = ordered.Count;
            for (int i = 0; i < last; i++)
            {
                int? comparingElement = i + 1 < last ? ordered[i + 1] : null;
                if (comparingElement != null && ordered[i] + 1 == comparingElement)
                {
                    currentMaxCounter++;
                }
                else
                {

                    if (currentMaxCounter > maxCounter)
                    {
                        maxCounter = currentMaxCounter;

                    }

                    currentMaxCounter = 1;
                }
            }
            return maxCounter;
        }
    }
}