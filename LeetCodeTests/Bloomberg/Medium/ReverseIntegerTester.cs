using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Medium;

namespace LeetCodeTests.Bloomberg.Medium
{
    public class ReverseIntegerTester
    {
        private readonly ReverseInteger _sut;

        public ReverseIntegerTester()
        {
            _sut = new ReverseInteger();
        }

        [Fact]
        public void Test1()
        {
            var result = _sut.Reverse(-12);
            result.Should().Be(-21);
        }

        [Fact]
        public void Test2()
        {
            var result = _sut.Reverse(123);
            result.Should().Be(321);
        }

        [Fact]
        public void Test3()
        {
            var result = _sut.Reverse(120);
            result.Should().Be(21);
        }


        [Fact]
        public void Test4()
        {
            var result = _sut.Reverse(1534236469);
            result.Should().Be(0);
        }


        [Fact]
        public void Test5()
        {
            var result = _sut.Reverse(-2147483648);
            result.Should().Be(0);
        }

        
    }
}
