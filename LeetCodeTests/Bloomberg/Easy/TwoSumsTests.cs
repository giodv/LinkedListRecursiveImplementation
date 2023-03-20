using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests.Bloomberg.Easy
{
    public class TwoSumsTests
    {
        private readonly TwoSums _sut;

        public TwoSumsTests()
        {
            _sut = new TwoSums();
        }

        [Fact]
        public void Test1()
        {
            int[] test = { 1, 2, 3 };
            var indices = _sut.TwoSum(test, 3);
            indices.Length.Should().Be(2);
            indices[0].Should().Be(0);
            indices[1].Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            int[] test = { 1, 2, 3 };
            var indices = _sut.TwoSum(test, 5);
            indices.Length.Should().Be(2);
            indices[0].Should().Be(1);
            indices[1].Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            int[] test = { 1, 2, 3, 4 };
            var indexResult = _sut.TwoSumsOptimized(test, 5);
            indexResult.Should().BeEquivalentTo(new int[] { 0, 3 });
        }
    }
}
