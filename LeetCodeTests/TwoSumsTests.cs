using FluentAssertions;
using LeetCode.Exercises.Easy;

namespace LeetCodeTests
{
    public class TwoSumsTests
    {
        [Fact]
        public void Test1()
        {
            var nums = new int[] { 1, 2, 3 };
            var target = 4;
            var sut = new TwoSums();
            var res = sut.TwoSum(nums, target);
            res.Should().HaveCount(2);
            res.Should().Contain(new int[] { 0, 2 });
        }
    }
}
