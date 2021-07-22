using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Sorting.Services.MarkAndToys
{
    public class MarkAndToys : IMarkAndToys
    {
        /*
         * Complete the 'maximumToys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY prices
         *  2. INTEGER k
         */
        public int GetMaximumToys(List<int> prices, int k)
        {
            int total = 0;
            int count = 0;
            prices.Sort();
            foreach (var price in prices)
            {
                if (total + price >= k || price > k)
                    break;
                total += price;
                count++;
            }
            return count;
        }
    }
}