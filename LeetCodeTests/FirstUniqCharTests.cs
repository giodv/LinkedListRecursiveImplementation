using FluentAssertions;
using LeetCode.Exercises.Easy;

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

        
    }
}