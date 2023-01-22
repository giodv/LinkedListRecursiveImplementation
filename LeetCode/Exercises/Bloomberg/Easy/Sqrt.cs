namespace LeetCode.Exercises.Bloomberg.Easy
{
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            var response = 0;
            for (int i = 1; i < x / 2; i++)
            {
                if (x / i < i)
                {
                    break;
                }

                response = i;
            }

            return response;
        }
    }
}