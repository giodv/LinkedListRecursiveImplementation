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
            var nums = new int[] {  1, 2 ,3 ,4, 1 };
            var result = _sut.RemoveDuplicates(nums, 1);
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
           
        }
    }
}