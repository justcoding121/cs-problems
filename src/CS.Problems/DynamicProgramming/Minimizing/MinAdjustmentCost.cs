using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Problems.DynamicProgramming.Minimizing
{
    /// <summary>
    /// Problem statement below
    /// https://www.geeksforgeeks.org/find-minimum-adjustment-cost-of-an-array/
    /// </summary>
    public class MinAdjustmentCost
    {
        public static int Compute(int[] a, int target)
        {
            return computeR(a, target, a.Length, 0, new Dictionary<string, int>());
        }

        private static int computeR(int[] a, int target, int index, int lastValue, 
            Dictionary<string, int> cache)
        {
            if (index < 0)
            {
                return 0;
            }

            var cacheKey = $"{index}-{lastValue}";

            if(cache.ContainsKey(cacheKey))
            {
                return cache[cacheKey];
            }

            var prevDiff = index < a.Length ? Math.Abs(a[index] - lastValue) : 0;
            var minCost = int.MaxValue;
            for (int i = 0; i <= 100; i++)
            {
                if (index < a.Length
                    && Math.Abs(lastValue - i) > target)
                {
                    continue;
                }

                var diff = prevDiff + computeR(a, target, index - 1, i, cache);
                minCost = Math.Min(minCost, diff);
            }
            cache[cacheKey] = minCost;
            return minCost;
        }
    }
}
