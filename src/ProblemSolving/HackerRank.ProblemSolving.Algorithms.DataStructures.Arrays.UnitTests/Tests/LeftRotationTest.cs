namespace HackerRank.ProblemSolving.Algorithms.DataStructures.Arrays.UnitTests.Tests;

public class LeftRotationTest
{
    private readonly IArrayLeftRotation _arrayLeftRotation;

    public LeftRotationTest()
    {
        _arrayLeftRotation = new LeftRotation();
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
        var inputList = StringToListConverterUtil.GetIntList(input);
        var arrayRotate = _arrayLeftRotation.Rotate(inputList, rotations);
        var actual = string.Join(StringToListConverterUtil.DefaultSeparator, arrayRotate);
        Assert.Equal(expected, actual);
    }
}