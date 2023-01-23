using FluentAssertions;
using LeetCode.Data_Structures;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests
{
    public class MyQueueTests
    {
        MyStack _sut;

        public MyQueueTests()
        {
            _sut = new MyStack();
        }

        [Fact]
        public void Test1()
        {
           _sut.Push(1);
           _sut.Push(2);
           var result = _sut.Top();
           result.Should().Be(2);
           var result2 = _sut.Pop();
           result2.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            //["MyStack","push","pop","empty"]
            var sut = new MyStack();
            sut.Push(1);
            sut.Pop();
            var isEmpty = sut.Empty();
            isEmpty.Should().BeTrue();
        }
    }
}