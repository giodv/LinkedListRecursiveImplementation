using FluentAssertions;
using LeetCode.Data_Structures;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests
{
    public class SquaredTest
    {
        Sqrt _sut;

        public SquaredTest()
        {
            _sut = new Sqrt();
        }

        [Fact]
        public void Test1()
        {
            var res = _sut.MySqrt(4);
            res.Should().Be(2);
        }


        [Fact]
        public void Test2()
        {
            var res = _sut.MySqrt(5);
            res.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var res = _sut.MySqrt(2);
            res.Should().Be(1);
        }

        [Fact]
        public void Test4()
        {
            var res = _sut.MySqrt(6);
            res.Should().Be(2);
        }

        [Fact]
        public void Test5()
        {
            var res = _sut.MySqrt(2147483647);
            res.Should().Be(46340);
        }
    }
}