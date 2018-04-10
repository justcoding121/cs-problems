using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.DynamicProgramming.Maximizing
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/maximum-profit-by-buying-and-selling-a-share-at-most-k-times/
    /// </summary>
    public class MaxProfitKTransactions
    {
        public static int GetProfit(int[] sharePrices, int k)
        {

           return GetProfit(sharePrices, k, sharePrices.Length - 1, 
                new Dictionary<string, int>());
        }

        /// <summary>
        /// DP top down
        /// </summary>
        /// <param name="sharePrices"></param>
        /// <param name="k"></param>
        /// <param name="day"></param>
        /// <param name="netBestProfit"></param>
        /// <returns></returns>
        private static int GetProfit(int[] sharePrices,
            int k, int day,  
            Dictionary<string, int> cache)
        {
            var cacheKey = $"{k}-{day}";

            if(cache.ContainsKey(cacheKey))
            {
                return cache[cacheKey];
            }

            //cannot make profit on day 0
            //or when we can't make any more transactions
            if (day == 0 || k == 0)
            {
                return 0;
            }

            var bestProfit = 0;

            for (int prevDay = 0; prevDay < day; prevDay++)
            {
                //profit when we buy previous day and 
                //sell current day share
                var pickProfit = 0;
                //only makes sense to buy & sell if prev share
                //is less than current
                if (sharePrices[prevDay] < sharePrices[day])
                { 
                    pickProfit = GetProfit(sharePrices, k - 1, prevDay, cache)
                        + (sharePrices[day] - sharePrices[prevDay]);
                }

                //see the result when we don't buy & sell this pair
                var skipProfit = GetProfit(sharePrices, k, prevDay, cache);

                //update local max
                bestProfit = Math.Max(bestProfit, Math.Max(pickProfit, skipProfit));
            }


            cache.Add(cacheKey, bestProfit);

            return bestProfit;
        }
    }
}
