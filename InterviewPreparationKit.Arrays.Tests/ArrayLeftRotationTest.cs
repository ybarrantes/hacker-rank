using System.Collections.Generic;
using System.Linq;
using InterviewPreparationKit.Arrays.Services.ArrayLeftRotation;
using Xunit;

namespace InterviewPreparationKit.Arrays.Tests
{
    public class ArrayLeftRotationTest
    {
        private const char Separator = ' ';
        
        private readonly IArrayLeftRotation _arrayLeftRotation;

        public ArrayLeftRotationTest()
        {
            _arrayLeftRotation = new ArrayLeftRotation();
        }
        
        public static IEnumerable<object[]> TestData() =>
            new List<object[]>()
            {
                new object[]
                {
                    "1 2 3 4 5",
                    4,
                    "5 1 2 3 4"
                },
                new object[]
                {
                    "1 2 3 4 5",
                    5,
                    "1 2 3 4 5"
                },
                new object[]
                {
                    "33 47 70 37 8 53 13 93 71 72 51 100 60 87 97",
                    13,
                    "87 97 33 47 70 37 8 53 13 93 71 72 51 100 60"
                },
                new object[]
                {
                    "41 73 89 7 10 1 59 58 84 77 77 97 58 1 86 58 26 10 86 51",
                    10,
                    "77 97 58 1 86 58 26 10 86 51 41 73 89 7 10 1 59 58 84 77"
                },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void WhenResultIsSuccess(string input, int rotations, string expected)
        {
            var inputList = input.Split(Separator).Select(int.Parse).ToList();
            var arrayRotate = _arrayLeftRotation.Rotate(inputList, rotations);
            var actual = string.Join(Separator, arrayRotate);
            Assert.Equal(expected, actual);
        }
    }
}