namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class MissingArrayNumber
    {
        /*
         * Given an array nums containing n distinct numbers in the range [0, n],
         * return the only number in the range that is missing from the array.
         */
        public int MissingNumberStupidApproach(int[] nums)
        {
            var numbers = new Range(0, nums.Length);
            var found = false;
            for (int i = numbers.Start.Value; i <= numbers.End.Value; i++)
            {
                foreach (var n in nums)
                {
                    if (n == i)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    return i;
                }

                found = false;
            }

            return -1;
        }

        public int MissingNumber(int[] nums)
        {
            var dictionary = new Dictionary<int, bool>();
            foreach (var element in Enumerable.Range(0, nums.Length + 1).ToArray())
            {
                dictionary.Add(element, false);
            }

            foreach (var n in nums)
            {
                dictionary[n] = true;
            }

            foreach (var a in dictionary)
            {
                if (!a.Value)
                    return a.Key;
            }

            return -1;
        }

        public int MissingNumberArrays(int[] nums)
        {
            var missingNumbers = new bool[nums.Length + 1];
            foreach (var n in nums)
            {
                missingNumbers[n] = true;
            }

            for (int i = 0; i < missingNumbers.Length; i++)
            {
                if (!missingNumbers[i])
                    return i;
            }

            return -1;
        }
    }
}