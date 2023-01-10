using FluentAssertions;
using LeetCode.Exercises.Medium;

namespace LeetCodeTests
{
    public class LongestConsecutiveTests
    {
        LongestConsecutive _sut;

        public LongestConsecutiveTests()
        {
            _sut = new LongestConsecutive();
        }

        [Fact]
        public void Test1()
        {
            var indexOpt = _sut.GetLongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            indexOpt.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var indexOpt = _sut.GetLongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
            indexOpt.Should().Be(9);
        }

        [Fact]
        public void Test3()
        {
            var indexOpt = _sut.GetLongestConsecutive(new int[] { 1, 2, 0, 1 });
            indexOpt.Should().Be(3);
        }


        [Fact]
        public void Test4()
        {
            var indexOpt = _sut.GetLongestConsecutive(new int[] { 9, 1, -3, 2, 4, 8, 3, -1, 6, -2, -4, 7 });
            indexOpt.Should().Be(4);
        }

        [Fact]
        public void Test5()
        {
            var indexOpt = _sut.GetLongestConsecutive(new int[]
                { 7, -9, 3, -6, 3, 5, 3, 6, -2, -5, 8, 6, -4, -6, -4, -4, 5, -9, 2, 7, 0, 0 });
            indexOpt.Should().Be(4);
        }
    }
}