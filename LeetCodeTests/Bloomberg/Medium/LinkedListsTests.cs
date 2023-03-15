using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Medium;
using LeetCode.Exercises.Random;

namespace LeetCodeTests.Bloomberg.Medium
{
    public class LinkedListsTests
    {
        private readonly LinkedLists _sut;

        public LinkedListsTests()
        {
            _sut = new LinkedLists();
        }

        [Fact]
        public void AddTwoNumbersTestsWithNoCarry()
        {
            var l1 = new ListNode(1, new ListNode(2));
            var l2 = new ListNode(1, new ListNode(2));
            var l3 = _sut.AddTwoNumbers(l1,l2);
            l3.val.Should().Be(2);
            l3.next.val.Should().Be(4);
            l3.next.next.Should().Be(null);
        }

        [Fact]
        public void AddTwoNumbersTestsWithNoCarryAndDifferentLength()
        {
            var l1 = new ListNode(1, new ListNode(2));
            var l2 = new ListNode(1, null);
            var l3 = _sut.AddTwoNumbers(l1, l2);
            l3.val.Should().Be(2);
            l3.next.val.Should().Be(2);
            l3.next.next.Should().Be(null);
        }

        [Fact]
        public void AddTwoNumbersTestsWithCarry()
        {
            var l1 = new ListNode(9, new ListNode(2));
            var l2 = new ListNode(9, new ListNode(2));
            var l3 = _sut.AddTwoNumbers(l1, l2);
            l3.val.Should().Be(8);
            l3.next.val.Should().Be(5);
            l3.next.next.Should().Be(null);
        }

        [Fact]
        public void AddTwoNumbersTestsWithCarryAndDifferentLengths()
        {
            var l1 = new ListNode(9, new ListNode(2));
            var l2 = new ListNode(9);
            var l3 = _sut.AddTwoNumbers(l1, l2);
            l3.val.Should().Be(8);
            l3.next.val.Should().Be(3);
            l3.next.next.Should().Be(null);
        }
    }
}
