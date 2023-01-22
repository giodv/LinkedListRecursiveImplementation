namespace LeetCode.Exercises.Random.Easy
{
    public class OrderNaiveApproach
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            return OrderArray(arr);
        }

        public bool OrderArray(int[] arr)
        {
            int? difference = null;

            for (var i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                if (i != 0)
                {
                    var current = arr[i] - arr[i - 1];
                    if (difference != null && difference != current)
                        return false;
                    difference = current;
                }
            }

            return true;
        }
    }
}