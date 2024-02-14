using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparationKit.Sorting.Services.BubbleSort;

public struct BubbleSortStruct
{
    public int Swaps { get; set; }
    public List<int> ArrayList { get; set; }

    public int GetFirstElement() => ArrayList.First();
    public int GetLastElement() => ArrayList.Last();

    public string Print() =>
        $"Array is sorted in {Swaps} swaps.\nFirst Element: {GetFirstElement()}\nLast Element: {GetLastElement()}";
}