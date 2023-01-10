using FluentAssertions;
using LeetCode.Data_Structures;
using LeetCode.Exercises.Bloomberg.Easy;

namespace LeetCodeTests
{
    public class RomanToIntegerTests
    {
        RomanToInteger _sut;

        public RomanToIntegerTests()
        {
            _sut = new RomanToInteger();
        }

        [Fact]
        public void Test1()
        {
            var indexOpt = _sut.RomanToInt("II");
            indexOpt.Should().Be(2);
        }


        [Fact]
        public void Test2()
        {
            var index = _sut.RomanToInt("IV");
            index.Should().Be(4);
        }

        [Fact]
        public void Test3()
        {
            var index = _sut.RomanToInt("III");
            index.Should().Be(3);
        }

        [Fact]
        public void Test4()
        {
            new StackDataStructure().CrudOperationStack();
            new QueueDataStructure().CrudOperations();
        }
    }
}