using LeetCode.Exercises.Bloomberg.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCodeTests.Bloomberg.Easy
{
    public class MissingArrayNumberTests
    {
        private readonly MissingArrayNumber _sut;

        public MissingArrayNumberTests()
        {
            _sut = new MissingArrayNumber();
        }

        [Fact]
        public void Test1()
        {
            var missing = _sut.MissingNumberStupidApproach(new int[]{0,1});
            missing.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var missing = _sut.MissingNumber(new int[] { 0, 1 });
            missing.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var missing = _sut.MissingNumberArrays(new int[] { 0, 1 });
            missing.Should().Be(2);
        }
    }
}
