using System.Collections.Generic;

namespace CS.Problems.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/count-possible-decodings-given-digit-sequence/
    /// </summary>
    public class CountDecodings
    {
        public static int Count(string input)
        {
            return Count(input, input.Length, new Dictionary<int, int>());
        }

        /// <summary>
        /// Dp top down
        /// </summary>
        /// <param name="input"></param>
        /// <param name="i"></param>
        /// <param name="cache"></param>
        /// <returns></returns>
        private static int Count(string input, int i,
            Dictionary<int, int> cache)
        {
            if(cache.ContainsKey(i))
            {
                return cache[i];
            }

            if (i == 0)
            {
                return 1;
            }

            var result = 0;

            // single digit decode (1-9); 0 is invalid alone
            if (input[i - 1] != '0')
            {
                result += Count(input, i - 1, cache);
            }

            // two consecutive digits decode when in 10..26
            if (i >= 2)
            {
                var twoDigit = int.Parse(input.Substring(i - 2, 2));
                if (twoDigit >= 10 && twoDigit <= 26)
                {
                    result += Count(input, i - 2, cache);
                }
            }

            cache.Add(i, result);

            return result;
        }
    }
}
