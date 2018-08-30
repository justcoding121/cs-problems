using System;
using System.Collections.Generic;

namespace CS.Problems.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-3-longest-increasing-subsequence/
    /// </summary>
    public class MaxSumIncreasingSequence
    {
        public static int FindSum(int[] input)
        {
            var netMax = 0;

            var result = FindMaxSum(input, input.Length - 1, ref netMax, new Dictionary<int, int>());

            return netMax;
        }

        /// <summary>
        /// DP top down
        /// </summary>
        /// <param name="input"></param>
        /// <param name="j"></param>
        /// <param name="netMax"></param>
        /// <returns></returns>
        private static int FindMaxSum(int[] input,
            int j, ref int netMax, Dictionary<int, int> cache)
        {

            if (cache.ContainsKey(j))
            {
                return cache[j];
            }            

            var currentMax = input[j];

            for (int i = 0; i < j; i++)
            {
                var subMax = FindMaxSum(input, i, ref netMax, cache);

                //if values at j > i (increasing sequence)
                //And if subMax of values from (0, 1, .., i) + value at j is better
                if (input[i] < input[j])    
                {
                    currentMax = Math.Max(currentMax, Math.Max(subMax, subMax + input[j]));
                }
      
            }

            netMax = Math.Max(netMax, currentMax);

            cache.Add(j, currentMax);

            return currentMax;
        }
    }
}
