using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests.Bloomberg
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        private readonly RemoveDuplicatesFromSortedArray _sut;

        public RemoveDuplicatesFromSortedArrayTests()
        {
            _sut = new RemoveDuplicatesFromSortedArray();
        }

        [Fact]
        public void Test1()
        {
            var nums = new int[2] { 1, 1 };
            var result = _sut.RemoveDuplicates(nums);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var nums = new int[3] { 1, 1, 2 };
            var result = _sut.RemoveDuplicates(nums);
            result.Should().Be(2);
            nums.Should().BeEquivalentTo(new int[] { 1, 2 });
        }
    }
}