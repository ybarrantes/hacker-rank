using System.Collections.Generic;

namespace HackerRank.InterviewPreparationKit.Arrays.UnitTests.Tests;

public class NewYearChaosTest
{
    private const string TooChaotic = "Too chaotic";

    private readonly INewYearChaos _newYearChaos =  new NewYearChaos();
        
    public static IEnumerable<object[]> TestData() =>
        new List<object[]>()
        {
            new object[] {"2 1 5 3 4", "3"},
            new object[] {"2 5 1 3 4", TooChaotic},
            new object[] {"5 1 2 3 7 8 6 4", TooChaotic},
            new object[] {"1 2 5 3 7 8 6 4", "7"},
            new object[] {"1 2 5 3 4 7 8 6", "4"},
            new object[] {ReadFileUtil.GetStringFileToInlineText(@"Inputs\NewYearChaos.001.txt"), "966"},
        };
        
    [Theory]
    [MemberData(nameof(TestData))]
    public void WhenIsSuccess(string input, string expected)
    {
        var inputList = StringToListConverterUtil.GetIntList(input);
        var actual = _newYearChaos.GetMinimumBribes(inputList);
        Assert.Equal(expected, actual);
    }
}