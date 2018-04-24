using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Problems.Miscellaneous
{
    public class LongestOnesWithKFlips
    {
        //k*n time complexity & k space complexity
        public static int ComputeR(string a, int k)
        {
            var max = 0;

            for (int i = 0; i < a.Length; i++)
            {
                max = Math.Max(max, Compute(a.ToCharArray(), k, a.Length - 1));
            }

            return max;
        }

        private static int Compute(char[] a, int k, int i)
        {

            if (i < 0)
            {
                return 0;
            }

            if (a[i] == '1')
            {
                return Compute(a, k, i - 1) + 1;
            }

            if (k == 0)
            {
                return 0;
            }

            return Compute(a, k - 1, i - 1) + 1;
        }
    }
}
