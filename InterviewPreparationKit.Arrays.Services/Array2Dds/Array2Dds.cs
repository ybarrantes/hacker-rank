using System.Collections.Generic;

namespace InterviewPreparationKit.Arrays.Services.Array2Dds
{
    public class Array2Dds : IArray2Dds
    {
        public int GetHourglassSum(List<List<int>> arr)
        {
            int maximum = int.MinValue;
            int countRows = arr.Count - 2;
            int countColumns = arr[0].Count - 2;
        
            for(int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    int sum = arr[i][j] + arr[i][j+1] + arr[i][j+2]
                              + arr[i+1][j+1]
                              + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                    
                    if (sum <= maximum)
                        continue;

                    maximum = sum;
                }
            }
        
            return maximum;
        }
    }
}