using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparationKit.Arrays.Services.ArrayLeftRotation;

public class ArrayLeftRotation : IArrayLeftRotation
{
    /*
     * Complete the 'rotLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER d
     */
    public List<int> Rotate(List<int> a, int d)
    {
        var steps = d % a.Count;
        if (steps == 0)
            return a;

        return a.Select((t, i) =>
        {
            var index = i + steps;
            index -= (index > a.Count - 1) ? a.Count : 0;
            return a[index];
        }).ToList();
    }
}