using System;
using System.Collections.Generic;
using HackerRank.InterviewPreparationKit.Arrays.Contracts;

namespace HackerRank.InterviewPreparationKit.Arrays;

public class NewYearChaos : INewYearChaos
{
    private const string TooChaotic = "Too chaotic";
        
    public string GetMinimumBribes(List<int> q)
    {
        try
        {
            return GetBribes(q).ToString();
        }
        catch (Exception e)
        {
            return TooChaotic;
        }
    }

    private static int GetBribes(List<int> q)
    {
        var bribes = 0;
        var lastMin = int.MaxValue - 2;
        var lastMax = int.MaxValue - 1;
        for(var i = q.Count - 1; i >= 0; i--)
        {
            var item = q[i];
            var diff = item - (i + 1);
            if (diff > 2)
                throw new Exception();

            if (item > lastMax)
                bribes += 2;
            else if (item > lastMin)
                bribes++;
                
            if (item < lastMin)
            {
                lastMax = lastMin;
                lastMin = item;
            }
            else if (item < lastMax)
            {
                lastMax = item;
            }
        }
        return bribes;
    }
}