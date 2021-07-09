using System.Collections.Generic;
using InterviewPreparationKit.Arrays.Services.Array2Dds;
using InterviewPreparationKit.Arrays.Tests.Utils;
using Xunit;

namespace InterviewPreparationKit.Arrays.Tests
{
    public class Array2DdsTest
    {
        private readonly IArray2Dds _array2Dds;

        public Array2DdsTest()
        {
            _array2Dds = new Array2Dds();
        }
        
        public static IEnumerable<object[]> TestData() =>
            new List<object[]>()
            {
                new object[] {"1 1 1 0 0 0|0 1 0 0 0 0|1 1 1 0 0 0|0 0 2 4 4 0|0 0 0 2 0 0|0 0 1 2 4 0", 19},
                new object[] {"1 1 1 0 0 0|0 1 0 0 0 0|1 1 1 0 0 0|0 9 2 -4 -4 0|0 0 0 -2 0 0|0 0 -1 -2 -4 0", 13},
                new object[] {"-9 -9 -9 1 1 1|0 -9 0 4 3 2|-9 -9 -9 1 2 3|0 0 8 6 6 0|0 0 0 -2 0 0|0 0 1 2 4 0", 28},
            };
        
        [Theory]
        [MemberData(nameof(TestData))]
        public void WhenIsSuccess(string input, int expected)
        {
            var inputList = StringToListConverterUtil.GetInt2DList(input);
            var actual = _array2Dds.GetHourglassSum(inputList);
            Assert.Equal(expected, actual);
        }
    }
}