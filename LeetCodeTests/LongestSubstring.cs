using FluentAssertions;
using LeetCode.Exercises.Medium;

namespace LeetCodeTests
{
    public class LongestSubstringTests
    {
        LongestSubstring _sut;

        public LongestSubstringTests()
        {
            _sut = new LongestSubstring();
        }

        [Fact]
        public void Test1()
        {
            var indexOpt = _sut.LengthOfLongestSubstring("pwwkew");
            indexOpt.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var indexOpt = _sut.LengthOfLongestSubstring("aab");
            indexOpt.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var indexOpt = _sut.LengthOfLongestSubstring("dvdf");
            indexOpt.Should().Be(3);
        }
    }
}