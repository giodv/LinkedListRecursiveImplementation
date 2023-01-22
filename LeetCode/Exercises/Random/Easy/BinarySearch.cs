namespace LeetCode.Exercises.Random.Easy
{
    public class BinarySearch
    {
        public static int ArrayBinarySearch(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }

                if (arr[mid] > x)
                {
                    return ArrayBinarySearch(arr, left, mid - 1, x);
                }

                return ArrayBinarySearch(arr, mid + 1, right, x);
            }

            return -1;
        }
    }
}