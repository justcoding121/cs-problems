using CS.Problems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CS.Problems.Tests.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-14-maximum-sum-increasing-subsequence/
    /// </summary>
    [TestClass]
    public class MaxIncreasingSumSequence_Tests
    {
        [TestMethod]
        public void LongestIncreasingSubSequence_Smoke_Test()
        {
            Assert.AreEqual(106, MaxSumIncreasingSequence
                .FindSum(new int[] { 1, 101, 2, 3, 100, 4, 5 }));

            Assert.AreEqual(20, MaxSumIncreasingSequence
               .FindSum(new int[] { 20, 1, 4, 3, 10 }));

            Assert.AreEqual(120, MaxSumIncreasingSequence
                .FindSum(new int[] { 20, 1, -40, 3, 100 }));

            Assert.AreEqual(520, MaxSumIncreasingSequence
                .FindSum(new int[] { 20, 1, 500, 3, 100 }));

            Assert.AreEqual(521, MaxSumIncreasingSequence
                .FindSum(new int[] { 1, 20, 500, 3, 100 }));

            Assert.AreEqual(501, MaxSumIncreasingSequence
                .FindSum(new int[] { -20, 1, 500, 3, 100 }));

            Assert.AreEqual(700, MaxSumIncreasingSequence
                .FindSum(new int[] { 700, 3, 600 }));

            Assert.AreEqual(603, MaxSumIncreasingSequence
             .FindSum(new int[] { 601, 3, 600 }));
        }
    }
}
