using System.Collections.Generic;

namespace HackerRank.InterviewPreparationKit.Sorting.Services.BubbleSort;

public interface IBubbleSort
{
    BubbleSortStruct CountSwaps(List<int> a);
}