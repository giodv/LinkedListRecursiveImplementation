using FluentAssertions;
using LeetCode.Exercises.Random.Easy;

namespace LeetCodeTests
{
    public class OrderArrayTest
    {
        OrderNaiveApproach _sut;

        public OrderArrayTest()
        {
            _sut = new OrderNaiveApproach();
        }

        [Fact]
        public void Test1()
        {
            var result = _sut.OrderArray(new int[] { 100, 4, 200, 1, 3, 2 });
            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var result = _sut.OrderArray(new int[] { 2, 4, 8, 6 });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test3()
        {
            var result = _sut.OrderArray(new int[] { -2, -4, -8, -6, 0, 2 });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test4()
        {
            var result = _sut.OrderArray(new int[] { -2, -4 });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test5()
        {
            var result = _sut.OrderArray(new int[] { });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test6()
        {
            var result = _sut.OrderArray(new int[] { 1 });
            result.Should().BeTrue();
        }
    }
}