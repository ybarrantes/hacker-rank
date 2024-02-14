using System.Collections.Generic;
using HackerRank.Shared.Utils;
using HackerRank.InterviewPreparationKit.Sorting.Services.MarkAndToys;
using Xunit;

namespace HackerRank.InterviewPreparationKit.Sorting.Tests;

public class MarkAndToysTest
{
    private readonly IMarkAndToys _markAndToys;
        
    public MarkAndToysTest()
    {
        _markAndToys = new MarkAndToys();
    }
        
    public static IEnumerable<object[]> TestData() =>
        new List<object[]>()
        {
            new object[] {"1 2 3 4", 7, 3},
            new object[] {"3 7 2 9 4", 15, 3},
            new object[] {"1 12 5 111 200 1000 10", 50, 4},
        };
        
    [Theory]
    [MemberData(nameof(TestData))]
    public void WhenIsSuccess(string input, int k, int expected)
    {
        var inputList = StringToListConverterUtil.GetIntList(input);
        var actual = _markAndToys.GetMaximumToys(inputList, k);
            
        Assert.Equal(expected, actual);
    }
}