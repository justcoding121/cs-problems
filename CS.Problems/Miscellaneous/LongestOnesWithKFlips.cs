using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Problems.Miscellaneous
{
    public class LongestOnesWithKFlips
    {
        //k*n time complexity & k space complexity recursive approach
        public static int ComputeRecursive(string a, int k)
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

        //O(n) time complexity iterative approach
        public static int ComputeIterative(string a, int k)
        {
            var c = a.ToCharArray();
            int left = 0, right = 0;
            int max = 0;

            //fill first k 0'z with 1's creating a window
            while(k>0 && right < a.Length)
            {
                if (c[right] == '1')
                {
                    right++;
                }
                else
                {
                    k--;
                    right++;
                }
            }
            max = Math.Max(max, right - left);

            //slide window till end updating new maximum
            while (right < a.Length)
            {
                if (c[right] == '1')
                {
                    right++;
                }
                else
                {
                    while (c[left] == '1')
                        left++;

                    left++;
                    right++;
                }

                max = Math.Max(max, right - left);
            }

            return max;
        }

    }
}
