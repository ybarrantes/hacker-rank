using HackerRank.InterviewPreparationKit.Arrays.Contracts;

namespace HackerRank.InterviewPreparationKit.Arrays;

public class MinimumSwaps2 : IMinimumSwaps2
{
    public int GetMinimumSwaps(int[] arr)
    {
        int swaps = 0;
        for(var i = 0; i < arr.Length; i++)
        {
            var number = i + 1;
            if (arr[i] == number)
                continue;
            for (var j = number; j < arr.Length; j++)
            {
                if (arr[j] != number)
                    continue;
                    
                arr[j] = arr[i];
                arr[i] = number;
                swaps++;
                break;
            }
        }
        return swaps;
    }
}