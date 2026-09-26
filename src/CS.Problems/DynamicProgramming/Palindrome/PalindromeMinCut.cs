using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Problems.DynamicProgramming
{
    public class PalindromeInfo
    {
        internal int i { get; set; }
        internal int j { get; set; }
    }

    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-17-palindrome-partitioning/
    /// </summary>
    public class PalindromeMinCut
    {
        public static List<PalindromeInfo> GetMinCut(string input)
        {
            var cache = new Dictionary<int, int>();
            MinParts(input, 0, cache);

            var result = new List<PalindromeInfo>();
            var start = 0;

            while (start < input.Length)
            {
                var bestParts = cache[start];
                var bestEnd = start;

                for (int end = start; end < input.Length; end++)
                {
                    if (!IsPalindrome(input, start, end))
                    {
                        continue;
                    }

                    var parts = 1 + (end + 1 < input.Length ? cache[end + 1] : 0);
                    if (parts == bestParts)
                    {
                        bestEnd = end;
                        break;
                    }
                }

                result.Add(new PalindromeInfo()
                {
                    i = start,
                    j = bestEnd
                });

                start = bestEnd + 1;
            }

            return result;
        }

        /// <summary>
        /// Minimum number of palindromic parts for the suffix starting at start.
        /// </summary>
        private static int MinParts(string input, int start, Dictionary<int, int> cache)
        {
            if (start >= input.Length)
            {
                return 0;
            }

            if (cache.ContainsKey(start))
            {
                return cache[start];
            }

            var minParts = int.MaxValue;

            for (int end = start; end < input.Length; end++)
            {
                if (IsPalindrome(input, start, end))
                {
                    minParts = Math.Min(minParts, 1 + MinParts(input, end + 1, cache));
                }
            }

            cache.Add(start, minParts);

            return minParts;
        }

        private static bool IsPalindrome(string input, int i, int j)
        {
            while (i < j)
            {
                if (input[i] != input[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
