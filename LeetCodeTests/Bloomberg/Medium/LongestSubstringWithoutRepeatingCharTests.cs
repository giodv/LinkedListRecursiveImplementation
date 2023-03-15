using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Medium;

namespace LeetCodeTests.Bloomberg.Medium
{
    public class LongestSubstringWithoutRepeatingCharTests
    {
        private readonly LongestSubstringWithoutRepeatingCharacters _sut;

        public LongestSubstringWithoutRepeatingCharTests()
        {
            _sut = new LongestSubstringWithoutRepeatingCharacters();
        }

        [Fact]
        public void Test1()
        {
            var test = "abcabcbb";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var test = "bbbbbb";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var test = "pwwkew";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(3);
        }

        [Fact]
        public void Test4()
        {
            var test = " ";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(1);
        }

        [Fact]
        public void Test5()
        {
            var test = "dvdf";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(3);
        }

        [Fact]
        public void Test6()
        {
            var test = "abba";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(2);
        }

        [Fact]
        public void Test7()
        {
            var test = "tmmzuxt";
            var result = _sut.LengthOfLongestSubstring(test);
            result.Should().Be(5);
        }

    }
}
