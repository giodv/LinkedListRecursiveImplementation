using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Medium;

namespace LeetCodeTests.Bloomberg.Medium
{
    public class PalindromeTests
    {
        private readonly PalindromicSequence _sut;

        public PalindromeTests()
        {
            _sut = new PalindromicSequence();
        }

        [Fact]
        public void Test1()
        {
            var result = _sut.IsPalindrome("abba");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var result = _sut.IsPalindrome("abbab");
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var result = _sut.IsPalindrome("abcde");
            result.Should().BeFalse();

        }

        [Fact]
        public void Test4()
        {
            var result = _sut.LongestPalindromicSubstring("cbbd");
            result.Should().Be("bb");

        }

        [Fact]
        public void Test5()
        {
            var result = _sut.LongestPalindrome("babad");
            result.Should().Be("aba");

        }

        
    }
}
