using System.Collections.Generic;

namespace HackerRank.InterviewPreparationKit.Sorting.Services.BubbleSort;

public class BubbleSort : IBubbleSort
{
    /*
     * Complete the 'countSwaps' function below.
     *
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public BubbleSortStruct CountSwaps(List<int> a)
    {
        var n = a.Count;
        var bubbleSortStruct = new BubbleSortStruct {ArrayList = a};
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                var pivot = bubbleSortStruct.ArrayList[j + 1];
                if (bubbleSortStruct.ArrayList[j] <= pivot) continue;
                bubbleSortStruct.ArrayList[j + 1] = bubbleSortStruct.ArrayList[j];
                bubbleSortStruct.ArrayList[j] = pivot;
                bubbleSortStruct.Swaps++;
            }
        }
        return bubbleSortStruct;
    }
}