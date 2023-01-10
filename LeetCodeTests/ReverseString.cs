using FluentAssertions;
using LeetCode.Exercises.Easy;

namespace LeetCodeTests
{
    public class ReverseStringTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new ReverseStrings();
            var result = sut.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            result.Should().BeEquivalentTo(new char[] { 'o', 'l', 'l', 'e', 'h' });
        }

        [Fact]
        public void Test2()
        {
            var sut = new ReverseStrings();
            var result = sut.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'i' , 'o' });
            result.Should().BeEquivalentTo(new char[] { 'o', 'i', 'l', 'l', 'e', 'h' });
        }
    }
}