using System.Collections.Generic;
using HackerRank.Shared.Utils;
using HackerRank.InterviewPreparationKit.Sorting.Services.BubbleSort;
using Xunit;

namespace HackerRank.InterviewPreparationKit.Sorting.Tests;

public class BubbleSortTest
{
    private IBubbleSort _bubbleSort;

    public BubbleSortTest()
    {
        _bubbleSort = new BubbleSort();
    }
        
    public static IEnumerable<object[]> TestData() =>
        new List<object[]>()
        {
            new object[] {"1 2 3", 0, 1, 3},
            new object[] {"3 2 1", 3, 1, 3},
            new object[] {"4 2 3 1", 5, 1, 4},
        };

    [Theory]
    [MemberData(nameof(TestData))]
    public void WhenIsSuccess(string input, int expectedSwaps, int expectedFirst, int expectedLast)
    {
        var inputList = StringToListConverterUtil.GetIntList(input);
        var actual = _bubbleSort.CountSwaps(inputList);
            
        Assert.Equal(expectedSwaps, actual.Swaps);
        Assert.Equal(expectedFirst, actual.GetFirstElement());
        Assert.Equal(expectedLast, actual.GetLastElement());
    }
}