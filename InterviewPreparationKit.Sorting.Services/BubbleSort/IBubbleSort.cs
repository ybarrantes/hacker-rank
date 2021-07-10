using System.Collections.Generic;

namespace InterviewPreparationKit.Sorting.Services.BubbleSort
{
    public interface IBubbleSort
    {
        BubbleSortStruct CountSwaps(List<int> a);
    }
}