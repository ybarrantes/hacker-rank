using System.Collections.Generic;

namespace InterviewPreparationKit.Arrays.Services.ArrayManipulation
{
    public interface IArrayManipulation
    {
        long GetMaximumArrayValue(int n, List<List<int>> queries);
    }
}