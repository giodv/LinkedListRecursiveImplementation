using FluentAssertions;
using LeetCode.Exercises.Easy;

namespace LeetCodeTests
{
    public class NextHigherTests
    {
        [Fact]
        public void Test1()
        {
            var sut = new NextHigher();
            var result = sut.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
            result.Should().BeEquivalentTo(new int[] { -1, 3, -1 });
        }

    }
}
