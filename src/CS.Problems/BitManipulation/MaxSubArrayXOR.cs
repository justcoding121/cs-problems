
using System;

namespace CS.Problems.BitManipulation
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/find-the-maximum-subarray-xor-in-a-given-array/
    /// </summary>
    public class MaxSubArrayXOR
    {
        private class BitTrieNode
        {
            public BitTrieNode[] Children = new BitTrieNode[2];
        }

        public static int FindMax(int[] x)
        {
            var root = new BitTrieNode();

            //init with zero
            Insert(root, 0);

            var max = int.MinValue;
            var prefixXor = 0;

            for (int i = 0; i < x.Length; i++)
            {
                prefixXor = prefixXor ^ x[i];
                Insert(root, prefixXor);
                max = Math.Max(max, QueryMax(root, prefixXor));
            }

            return max;
        }

        private static void Insert(BitTrieNode root, int value)
        {
            var current = root;

            for (int i = 31; i >= 0; i--)
            {
                var bit = (value >> i) & 1;
                if (current.Children[bit] == null)
                {
                    current.Children[bit] = new BitTrieNode();
                }
                current = current.Children[bit];
            }
        }

        /// <summary>
        /// Returns the maximum subarray XOR ending at the current prefix.
        /// </summary>
        private static int QueryMax(BitTrieNode root, int prefixXor)
        {
            var current = root;
            var partner = 0;

            for (int i = 31; i >= 0; i--)
            {
                var bit = (prefixXor >> i) & 1;
                var opposite = bit ^ 1;

                if (current.Children[opposite] != null)
                {
                    partner |= (opposite << i);
                    current = current.Children[opposite];
                }
                else
                {
                    partner |= (bit << i);
                    current = current.Children[bit];
                }
            }

            return prefixXor ^ partner;
        }
    }
}
