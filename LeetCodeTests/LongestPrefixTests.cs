using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Random.Easy;

namespace LeetCodeTests
{
    public class LongestPrefixTests
    {
        [Fact]
        public void Test1()
        {
            var longest = new LongestPrefix();
            var r = longest.LongestCommonPrefix(new string[] { "doggy", "dog" });
            r.Should().Be("dog");
        }
    }
}
