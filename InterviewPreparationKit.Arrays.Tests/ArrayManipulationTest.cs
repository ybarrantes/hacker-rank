using System.Collections.Generic;
using InterviewPreparationKit.Arrays.Services.ArrayManipulation;
using InterviewPreparationKit.Arrays.Tests.Utils;
using Xunit;

namespace InterviewPreparationKit.Arrays.Tests
{
    public class ArrayManipulationTest
    {
        private readonly IArrayManipulation _arrayManipulation;

        public ArrayManipulationTest()
        {
            _arrayManipulation = new ArrayManipulation();
        }
        
        public static IEnumerable<object[]> TestData() =>
            new List<object[]>()
            {
                new object[] {"2 6 8|3 5 7|1 8 1|5 9 15", 10, 31},
                new object[] {"1 5 3|4 8 7|6 9 1", 10, 10},
                new object[] {"1 2 100|2 5 100|3 4 100", 5, 200},
                new object[] {ReadFileUtil.GetStringFileToInlineText(@"Inputs\ArrayManipulation.001.txt"), 10000000, 2497169732L},
            };
        
        [Theory]
        [MemberData(nameof(TestData))]
        public void WhenIsSuccess(string input, int n, long expected)
        {
            var inputList = StringToListConverterUtil.GetInt2DList(input);
            var actual = _arrayManipulation.GetMaximumArrayValue(n, inputList);
            Assert.Equal(expected, actual);
        }
    }
}