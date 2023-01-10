using FluentAssertions;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests
{
    public class ValidPaenthesesTests
    {
        ValidParentheses _sut;

        public ValidPaenthesesTests()
        {
            _sut = new ValidParentheses();
        }

        [Fact]
        public void Test1()
        {
            var indexOpt = _sut.IsValid("()");
            indexOpt.Should().Be(true);
        }


        [Fact]
        public void Test2()
        {
            var index = _sut.IsValid("([");
            index.Should().Be(false);
        }

        [Fact]
        public void Test3()
        {
            var index = _sut.IsValid("([])");
            index.Should().Be(true);
        }

        [Fact]
        public void Test4()
        {
            var index = _sut.IsValid2("()[]");
            index.Should().Be(true);
        }
    }
}