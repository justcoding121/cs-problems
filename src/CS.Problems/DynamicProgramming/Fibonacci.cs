using System.Collections.Generic;

namespace CS.Problems.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
    /// </summary>
    public class FibonacciGenerator
    {
        /// <summary>
        /// get Fibonacci numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> GetFibonacciNumbers(int number)
        {
            var result = new List<int>();

            var cache = new Dictionary<int, int>();

            Fibonacci(number, cache);

            foreach (var item in cache)
            {
                result.Add(item.Value);
            }

            return result;
        }

        /// <summary>
        /// Recursively compute
        /// </summary>
        /// <param name="number"></param>
        /// <param name="cache"></param>
        /// <returns></returns>
        private static int Fibonacci(int number, 
            Dictionary<int, int> cache)
        {
            if(cache.ContainsKey(number))
            {
                return cache[number];
            }

            if(number <= 2)
            {
                cache.Add(number, 1);
                return 1;
            }

            var result = Fibonacci(number - 1, cache)
                + Fibonacci(number - 2, cache);

            cache.Add(number, result);

            return result;
        }
    }
}
