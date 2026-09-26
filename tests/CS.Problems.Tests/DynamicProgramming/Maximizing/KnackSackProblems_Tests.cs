using CS.Problems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CS.Problems.Tests.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-10-0-1-knapsack-problem/
    /// </summary>
    [TestClass]
    public class KnackSackProblems_Tests
    {
        [TestMethod]
        public void KnackSack10_Tests()
        {
            //sample inputs
            int[] weights = new int[] { 10, 20, 30 };
            int[] values = new int[] { 60, 100, 120 };

            //max weight capacity of bag
            int W = 49;

            var result = KnackSackProblems.KnackSack_10_Recursive(W, weights, values, weights.Length, new Dictionary<string, int>());

            Assert.AreEqual(result, 180);

            // cache key must separate capacity from item count
            var manyWeights = new int[21];
            var manyValues = new int[21];
            manyWeights[0] = 11;
            manyValues[0] = 100;
            for (int i = 1; i < 21; i++)
            {
                manyWeights[i] = 1;
                manyValues[i] = 1;
            }
            Assert.AreEqual(100, KnackSackProblems.KnackSack_10_Recursive(
                11, manyWeights, manyValues, manyWeights.Length, new Dictionary<string, int>()));

        }

        /// <summary>
        /// Gets the minimum number of coins to fit in the amount 
        /// </summary>
        [TestMethod]
        public void KnackSack_Fractional_Tests()
        {
            //sample inputs
            int[] weights = new int[] { 5, 20, 10, 12 };
            int[] values = new int[] { 50, 140, 60, 60 };

            //max weight capacity of bag
            int W = 30;

            var result = KnackSackProblems.KnackSack_Fractional(W, weights, values);

            Assert.AreEqual(result, 220);

            // unsorted ratios: prefer the higher ratio item first
            Assert.AreEqual(80, KnackSackProblems.KnackSack_Fractional(
                10, new int[] { 10, 5 }, new int[] { 60, 50 }));
        }
    }
}
