using FluentAssertions;
using LeetCode.Exercises.Easy;
using LeetCode.Exercises.Random.Easy;

namespace LeetCodeTests
{
    public class FirstUniqCharTests
    {
        FirstUniqChar _sut;

        public FirstUniqCharTests()
        {
            _sut = new FirstUniqChar();
        }

        [Fact]
        public void Test1()
        {
            var indexOpt = _sut.GetFirstUniqCharOptimized("leetcode");
            indexOpt.Should().Be(0);
        }


        [Fact]
        public void Test2()
        {
            var index = _sut.GetFirstUniqCharOptimized("aabb");
            index.Should().Be(-1);
        }

        [Fact]
        public void Test3()
        {
            var index = _sut.GetFirstUniqCharOptimized("dddccdbba");
            index.Should().Be(8);
        }

        [Fact]
        public void Test4()
        {
            int[] arr = { 20, 32, 51, 106, 400 };
            int n = arr.Length;
            int x = 106;

            var index = BinarySearch.ArrayBinarySearch(arr, 0, n - 1, x);
        }

        
    }
}