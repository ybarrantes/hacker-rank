using System.Collections.Generic;

namespace HackerRank.InterviewPreparationKit.Arrays.Services.ArrayManipulation;

public interface IArrayManipulation
{
    long GetMaximumArrayValue(int n, List<List<int>> queries);
}