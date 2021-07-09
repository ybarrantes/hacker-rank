using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Arrays.Services.ArrayManipulation
{
    public class ArrayManipulation : IArrayManipulation
    {
        /*
         * Complete the 'arrayManipulation' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */
        public long GetMaximumArrayValue(int n, List<List<int>> queries)
        {
            var result = BuildArray(n);
            result = ProcessArray(queries, result);
            return GetMaxValue(result);
        }
        
        private static List<long> BuildArray(int n) =>
            Enumerable.Repeat(0L, n + 1).ToList();

        private static List<long> ProcessArray(List<List<int>> queries, List<long> list)
        {
            foreach (var q in queries)
            {
                var a = q[0] - 1;
                var b = q[1];
                var k = q[2];
                list[a] += k;
                list[b] -= k;
            }
            return list;
        }

        private static long GetMaxValue(List<long> list)
        {
            var sum = 0L;
            var max = 0L;
            foreach (var num in list)
            {
                sum += num;
                if (max < sum)
                    max = sum;
            }
            return max;
        }
    }
}