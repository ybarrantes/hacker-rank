using System.Collections.Generic;
using InterviewPreparationKit.Arrays.Services.MinimumSwaps2;
using Utils;
using Xunit;

namespace InterviewPreparationKit.Arrays.Tests
{
    public class MinimumSwaps2Test
    {
        private const char Separator = ' ';
        
        private readonly IMinimumSwaps2 _minimumSwaps2;

        public MinimumSwaps2Test()
        {
            _minimumSwaps2 = new MinimumSwaps2();
        }

        public static IEnumerable<object[]> TestData() =>
            new List<object[]>()
            {
                new object[] {"4 3 1 2", 3},
                new object[] {"2 3 4 1 5", 3},
                new object[] {"1 3 5 2 4 6 7", 3},
                new object[] {"7 1 3 2 4 5 6", 5},
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void WhenIsSuccess(string input, int expected)
        {
            var inputList = StringToListConverterUtil.GetIntList(input).ToArray();
            var actual = _minimumSwaps2.GetMinimumSwaps(inputList);
            Assert.Equal(expected, actual);
        }
    }
}