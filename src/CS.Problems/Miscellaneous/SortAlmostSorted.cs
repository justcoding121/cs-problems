using System;
using System.Collections.Generic;
using Advanced.Algorithms.DataStructures;
using Advanced.Algorithms.DataStructures.Heap.Min;


namespace CS.Problems.Miscellaneous
{

    public class SortAlmostSorted
    {
        /// <summary>
        /// Sort the given input
        /// where elements are misplaced almost by a distance k
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] Sort(int[] input, int k)
        {
            if (k > input.Length)
            {
                throw new Exception("K cannot exceed array length.");
            }

            var firstKElements = new int[k + 1];
            Array.Copy(input, firstKElements, k + 1);

            var minHeap = new BMinHeap<int>(firstKElements);

            var result = new List<int>();

            for (int i = k + 1; i < input.Length; i++)
            {
                result.Add(minHeap.ExtractMin());
                minHeap.Insert(input[i]);
            }

            while (minHeap.Count > 0)
            {
                result.Add(minHeap.ExtractMin());
            }

            return result.ToArray();
        }
    }
}
