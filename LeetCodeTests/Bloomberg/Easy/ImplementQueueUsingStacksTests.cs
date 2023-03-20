using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests.Bloomberg.Easy
{
    public class ImplementQueueUsingStacksTests
    {
        private readonly ImplementingQueueUsingStacks.MyQueue _sut;
        public ImplementQueueUsingStacksTests()
        {
            _sut = new ImplementingQueueUsingStacks.MyQueue();
        }

        [Fact]
        public void Test1()
        {
            _sut.Push(1);
            _sut.Push(2);
            var res = _sut.Push(3);
            res.Should().BeEquivalentTo(new int[] { 1, 2, 3 });

            var res2 = _sut.Peek();
            res2.Should().Be(1);
            var res_pop = _sut.Pop();
            res_pop.Should().Be(1);
            res = _sut.Push(4);
            res.Should().BeEquivalentTo(new int[] { 2, 3,4 });
        }
    }
}
