using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Exercises.Bloomberg.Medium;

namespace LeetCodeTests.Bloomberg.Medium
{
    public class ThreeSumsTests
    {
        private readonly ThreeSumsArray _sut;

        public ThreeSumsTests()
        {
            _sut = new ThreeSumsArray();
        }

        [Fact]
        public void Test1()
        {
            var result = _sut.ThreeSum(new int[] { 0,0,0 });
        }
    }
}
