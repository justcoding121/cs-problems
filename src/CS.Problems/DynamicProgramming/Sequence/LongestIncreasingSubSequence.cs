using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Problems.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-3-longest-increasing-subsequence/
    /// </summary>
    public class LongestIncreasingSubSequence
    {
        public int FindSequence(int[] input)
        {
            if (input.Length <= 1)
                return input.Length;

            var cache = new Dictionary<int, int>();

            findSequence(input, input.Length - 1, cache);

            return cache.Select(x => x.Value).Max();
        }

        private int findSequence(int[] input, int j,
         Dictionary<int, int> cache)
        {
            if (cache.ContainsKey(j))
            {
                return cache[j];
            }

            if (j == 0)
            {
                cache.Add(j, 1);
                return 1;
            }

            var currentLongest = 1;

            for (int i = 0; i < j; i++)
            {
                //from 0 to i
                var subLongest = findSequence(input, i, cache);

                //if 0 to i sequence last value (i) is less than current value j
                //And if it improves our current Longest
                if (input[i] < input[j])
                {
                    currentLongest = Math.Max(currentLongest, subLongest + 1);
                }
            }

            cache.Add(j, currentLongest);

            return currentLongest;
        }
    }
}
