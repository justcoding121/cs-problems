using System.Collections.Generic;

namespace CS.Problems.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-7-coin-change/
    /// </summary>
    public class CoinChangeProblems
    {

        //O(amount * n^n) without memoization?
        //O(amount * n) with memoization
        public static int MinCoinChangeRecursive(int amount, int n, int[] coins, Dictionary<int, int> memoizingCache)
        {
            if (amount == 0)
            {
                return 0;
            }

            if (amount < 0 || n <= 0)
            {
                return -1;
            }

            var key = amount;

            if (memoizingCache.ContainsKey(key))
            {
                return memoizingCache[key];
            }

            var min = int.MaxValue;

            for (int j = 0; j < n; j++)
            {
                //if this coin size is greater than the sum skip it; no use of this coin
                if (coins[j] <= amount)
                {
                    var prevMin = MinCoinChangeRecursive(amount - coins[j], n, coins, memoizingCache);

                    if (prevMin >= 0 && prevMin + 1 < min)
                    {
                        min = prevMin + 1;
                    }
                }
            }

            var result = min == int.MaxValue ? -1 : min;

            memoizingCache.Add(key, result);

            return result;

        }

    

        //O(amount * n^n) without memoization?
        //O(amount * n) with memoization
        public static int MaxCoinChangeRecursive(int amount, int n, int[] coins, Dictionary<int, int> memoizingCache)
        {
            if (amount == 0)
            {
                return 0;
            }

            if (amount < 0 || n <= 0)
            {
                return -1;
            }

            var key = amount;

            if (memoizingCache.ContainsKey(key))
            {
                return memoizingCache[key];
            }

            var max = -1;

            for (int j = 0; j < n; j++)
            {
                //if this coin size is greater than the sum skip it; no use of this coin
                if (coins[j] <= amount)
                {
                    var prevMax = MaxCoinChangeRecursive(amount - coins[j], n, coins, memoizingCache);

                    if (prevMax >= 0 && prevMax + 1 > max)
                    {
                        max = prevMax + 1;
                    }
                }
            }

            memoizingCache.Add(key, max);

            return max;

        }
    }
}
