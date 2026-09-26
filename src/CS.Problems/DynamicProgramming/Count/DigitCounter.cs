using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Problems.DynamicProgramming.Count
{
    public class DigitCounter
    {
        /// <summary>
        ///  Counts the appearences of given digit (0-9) in all numbers from 0 to given number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static int Count(int number, int digit)
        {
            if(digit < 0 || digit > 9)
            {
                throw new ArgumentException("Invalid digit.");
            }

            if(number < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            if (number < 10)
            {
                if(digit <= number)
                {
                    return 1;
                }

                return 0;
            }

            return Count(number, digit, new Dictionary<string, int>());
        }
        /// <summary>
        /// Counts the appearences of given digit (0-9) in all numbers from 0 to number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="digit"></param>
        public static int Count(int number, int digit, Dictionary<string, int> cache)
        {
            var cacheKey = number + "-" + digit;

            if (cache.ContainsKey(cacheKey))
            {
                return cache[cacheKey];
            }

            int result;

            if (number < 10)
            {
                result = digit <= number ? 1 : 0;
            }
            else if (digit == 0)
            {
                return CountZeros(number, cache);
            }
            else
            {
                //comments below explains each step with the assumption number = 898
                //898 => 3
                var digits = (int)Math.Log10(number) + 1;

                //most significant 
                //898 => 8
                var msd = (int)(number / Math.Pow(10, digits - 1));

                //898 => count(0-99) * 8
                result = Count((int)Math.Pow(10, digits - 1) - 1, digit, cache) * msd;

                //(for 600 - 699)
                //6 < 8
                if (digit < msd)
                {
                    //+100 (for 600 - 699)
                    result += (int)Math.Pow(10, digits - 1);
                }

                //898 => 98
                var remaining = number - msd * (int)Math.Pow(10, digits - 1);

                if(remaining > 0)
                {
                   result += Count(remaining, digit, cache);
                }
              
                //6 == 8?
                // (for 800 - 898)
                if (digit == msd)
                {
                    //+98 (for 800 - 898)
                    //+1 for 800
                    result += remaining + 1;
                }
            }

            cache.Add(cacheKey, result);

            return result;
        }

        /// <summary>
        /// Counts digit 0 from 0 to number (number 0 counts once; no leading zeros).
        /// </summary>
        private static int CountZeros(int number, Dictionary<string, int> cache)
        {
            var cacheKey = number + "-0";

            if (cache.ContainsKey(cacheKey))
            {
                return cache[cacheKey];
            }

            if (number < 10)
            {
                cache.Add(cacheKey, 1);
                return 1;
            }

            var digits = (int)Math.Log10(number) + 1;
            var pow = (int)Math.Pow(10, digits - 1);
            var msd = number / pow;
            var remaining = number % pow;

            // zeros in 0 .. pow-1
            var result = CountZeros(pow - 1, cache);

            // full blocks with leading digit 1 .. msd-1
            if (msd > 1)
            {
                result += (msd - 1) * (digits - 1) * (pow / 10);
            }

            // lower digits in the last block (leading zeros in lower places count)
            result += CountZerosFixedWidth(remaining, digits - 1, cache);

            cache.Add(cacheKey, result);

            return result;
        }

        /// <summary>
        /// Zero digits in zero-padded width-digit forms of 0..number.
        /// </summary>
        private static int CountZerosFixedWidth(int number, int width, Dictionary<string, int> cache)
        {
            if (width <= 0 || number < 0)
            {
                return 0;
            }

            var cacheKey = number + "-fw" + width;

            if (cache.ContainsKey(cacheKey))
            {
                return cache[cacheKey];
            }

            var pow = (int)Math.Pow(10, width - 1);
            var msd = number / pow;
            var remaining = number % pow;
            int result;

            if (msd > 0)
            {
                // 0 .. pow-1: leading zero at this place plus zeros in lower places
                result = pow + CountZerosFixedWidth(pow - 1, width - 1, cache);

                if (msd > 1)
                {
                    result += (msd - 1) * (width - 1) * (pow / 10);
                }

                result += CountZerosFixedWidth(remaining, width - 1, cache);
            }
            else
            {
                // number < pow: every value has a leading zero here
                result = (number + 1) + CountZerosFixedWidth(number, width - 1, cache);
            }

            cache.Add(cacheKey, result);

            return result;
        }
    }
}
